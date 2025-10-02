class_name Player
extends Node3D

enum Test {
	A,
	B,
	C
}

enum Tile{
	Ground,
	Wall,
	Empty
}

func test():
#	var testClass = TestClass.new()
#	print(testClass.a)
	var testClass = TestClass.new()
	print(testClass.a)


class TestClass: # Wrong indent
	var a: String

func stop_counting_on_signal(the_signal):
	the_signal.connect(test():
		set_process(false)
		pass)
