using Godot;
using System;

public class Mob : RigidBody2D
{
    [Export]
    public int minSpeed;

    [Export]
    public int maxSpeed;

    public override void _Ready()
    {
        string[] mobTypes = GetNode<AnimatedSprite>("AnimatedSprite").Frames.GetAnimationNames();
        GetNode<AnimatedSprite>("AnimatedSprite").Animation = mobTypes[GD.Randi() % mobTypes.Length];
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
