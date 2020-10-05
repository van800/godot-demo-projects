using Godot;
using System;

public class Mob : RigidBody2D
{
    [Export] private int _minSpeed; // Minimum speed range.

    [Export] private int _maxSpeed; // Maximum speed range.

    private readonly string[] _mobTypes = {"walk", "swim", "fly"};

    // We use 'System.Random' as an alternative to GDScript's random methods.
    private readonly Random _random = new Random();

    public override void _Ready()
    {
        GetNode<AnimatedSprite>("AnimatedSprite").Animation = _mobTypes[_random.Next(0, _mobTypes.Length)];
    }

    public void OnVisibilityScreenExited()
    {
        QueueFree();
    }

    public void OnStartGame()
    {
        QueueFree();
    }
}
