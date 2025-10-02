extends SceneTree
func _init():
	var es = EditorInterface.get_editor_settings()
	var use_external = es.get_setting("text_editor/external/use_external")
	var exec_path = es.get_setting("text_editor/external/exec_path")
	var exec_flags = es.get_setting("text_editor/external/exec_flags")
	print("text_editor/external/use_external=", use_external)
	print("text_editor/external/exec_path=", exec_path)
	print("text_editor/external/exec_flags=", exec_flags)
	quit()
