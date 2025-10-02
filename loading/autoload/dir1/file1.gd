extends Node

#@export var texture_albedo2 : Texture = preload("./../dir2/file2.gd") 
#@export var texture_albedo : Texture = preload("../dir2/file2.gd") 
#@export var texture_albedo1  : Texture= preload("res://dir2/file2.gd") 

@export var texture_albedo21 : Texture = load("./../dir2/file2.gd") 
@export var texture_albedo12 : Texture = load("../dir2/file2.gd") 
@export var texture_albedo13 : Texture = ResourceLoader.load("res://dir2/file2.gd")


#func test():
	#if 3>1:
		#print("s")
		#pass
	#else:
		#print("s")
		##no pass, just press Enter
		#pass
		
	
		
		
	
