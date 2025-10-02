func test():
	var projectile := Node2D.new()
	var lifetime := Timer.new()
	lifetime.timeout.connect(func():
		if is_instance_valid(projectile):
			projectile.queue_free()
	)


func asd():
	print(
		func():
			if 0 > 0:
				pass
			elif 0 < 0:
				pass
	)
	var when = "when"
	print(when)
