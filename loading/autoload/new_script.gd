enum _Anim {
	FLOOR,
	AIR,
}

var anim : _Anim = _Anim.FLOOR

func stop_counting_on_signal(the_signal):
	the_signal.connect(func():
		the_signal.connect(func():
			pass))
