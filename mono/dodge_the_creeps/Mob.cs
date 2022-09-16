using Godot;

namespace DodgeTheCreeps
{
    public partial class Mob : RigidBody2D
    {
        [Export]
        public int minSpeed;

        [Export]
        public int maxSpeed;

        public override void _Ready()
        {
            var animSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
            animSprite.Playing = true;
            string[] mobTypes = animSprite.Frames.GetAnimationNames();
            animSprite.Animation = mobTypes[GD.Randi() % mobTypes.Length];
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
}
