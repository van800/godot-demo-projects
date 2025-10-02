class_name A extends Node

func show_ability_info(ability: Ability, s21:String) -> void:
	var info_label = $InfoLabel
	if info_label and ability:
		var info_text = "%s\nTP Cost: %d\n%s" % [
		ability.display_name,
		ability.tp_cost,
		ability.description
		]
		info_label.text = info_text


func _show_attack_options(abilities: Array[Ability]) -> void:
	# Show attack menu if there are abilities
	if abilities.size() > 0:
		for ability in abilities:
			var ability_button = Button.new()
			ability_button.text = ability.display_name + " (TP: " + str(ability.tp_cost) + ")"
			# Connect the button to show ability range and description
			ability_button.pressed.connect(
			func(): 
					show_ability_info(ability, "")
			)
			print(ability_button)
		
	var testnode : Node2D = Node2D.new()
	#testnode.name = "test"
	testnode.position = Vector2(100,100)
	pass
