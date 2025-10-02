extends Area2D

signal hit

@export var speed = 400 # How fast the player will move (pixels/sec).
var screen_size # Size of the game window.

func _ready():
	screen_size = get_viewport_rect().size
	hide()


@export var input_prefix: StringName = ""

func _process(delta):
	var velocity = Vector2.ZERO # The player's movement vector.
	var right = input_prefix + StringName("move_right")
	var left = input_prefix + StringName("move_left")
	var down = input_prefix + StringName("move_down")
	var up = input_prefix + StringName("move_up")
	if Input.is_action_pressed(right):
		velocity.x += 1

	if Input.is_action_pressed(left):
		velocity.x -= 1
	if Input.is_action_pressed(down):
		velocity.y += 1
	if Input.is_action_pressed(up):
		velocity.y -= 1

	if velocity.length() > 0:
		velocity = velocity.normalized() * speed
		$AnimatedSprite2D.play()
	else:
		$AnimatedSprite2D.stop()

	position += velocity * delta
	position = position.clamp(Vector2.ZERO, screen_size)

	if velocity.x != 0:
		$AnimatedSprite2D.animation = &"right"
		$AnimatedSprite2D.flip_v = false
		$Trail.rotation = 0
		$AnimatedSprite2D.flip_h = velocity.x < 0
	elif velocity.y != 0:
		$AnimatedSprite2D.animation = &"up"
		rotation = PI if velocity.y > 0 else 0


func start(pos):
	position = pos
	rotation = 0
	show()
	$CollisionShape2D.disabled = false


func _on_body_entered(_body):
	hide() # Player disappears after being hit.
	hit.emit()
	# Must be deferred as we can't change physics properties on a physics callback.
	$CollisionShape2D.set_deferred(&"disabled", true)
