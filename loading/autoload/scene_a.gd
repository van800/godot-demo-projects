extends Panel

func _enter_tree() -> void:
	get_tree()

func _on_goto_scene_pressed() -> void:
	#print("se6")
	get_tree()
	global.goto_scene("res://scene_b.tscn")

class A1:
	class B1:
		var array: Array
		class C1:
			class D1:
				func pp():
					pass
