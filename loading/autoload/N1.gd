extends Node

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass

func _ready():
	# Qualifier is a bare class id: calledOnPsi.text == "Outer"
	# calledOn resolves to "Outer"
	Outer.s()                  # static OK
	Outer.STATIC_VAL           # static OK
	Outer.i()                  # non-static should be filtered out by static context
	Outer.instance_val         # non-static should be filtered out
