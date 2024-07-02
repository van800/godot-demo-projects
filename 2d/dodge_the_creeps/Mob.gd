extends RigidBody2D

#warning-ignore-all:unused_class_variable
@export var min_speed = 150
@export var max_speed = 250

func _ready():
	$AnimatedSprite2D.playing = true
	var mob_types = $AnimatedSprite2D.frames.get_animation_names()
	$AnimatedSprite2D.animation = mob_types[randi() % mob_types.size()]


func _on_VisibilityNotifier2D_screen_exited():
	queue_free()


func _on_start_game():
	queue_free()
