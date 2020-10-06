using Godot;
using System;

public class Mob : RigidBody2D
{
    [Export]
    public int minSpeed;

    [Export]
    public int maxSpeed;

    private readonly string[] _mobTypes = {"walk", "swim", "fly"};

    public override void _Ready()
    {
        GetNode<AnimatedSprite>("AnimatedSprite").Animation = _mobTypes[GD.Randi() % _mobTypes.Length];
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
