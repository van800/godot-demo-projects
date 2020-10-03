using Godot;
using System;

public class Mob : RigidBody2D
{
    [Export] public int minSpeed; // Minimum speed range.

    [Export] public int maxSpeed; // Maximum speed range.

    private readonly string[] _mobTypes = {"walk", "swim", "fly"};

    // We use 'System.Random' as an alternative to GDScript's random methods.
    private static readonly Random _random = new Random();

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
