extends Node


# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func test(point: Vector2) -> void:
	match point:
		[0, 0]:
			print("Origin")
		[_, 0]:
			print("Point on X-axis")
		[0, _]:
			print("Point on Y-axis")
		[var x, var y] when y == x:
			print("Point on line y = x")
		[var x, var y] when y > x:
			print("Point on line y > x")
