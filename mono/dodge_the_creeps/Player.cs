using Godot;

namespace DodgeTheCreeps
{
    public partial class Player : Area2D
    {
        [Signal]
        public delegate void HitEventHandler();

        // These only need to be accessed in this script, so we can make them private.
        // Private variables in C# in Godot have their name starting with an
        // underscore and also have the "private" keyword instead of "public".
        [Export]
        private int _speed = 400; // How fast the player will move (pixels/sec).

        private Vector2 _screenSize; // Size of the game window.

        public override void _Ready()
        {
            _screenSize = GetViewportRect().Size;
            Hide();
        }

        public override void _Process(double delta)
        {
            
        }

        public void Start(Vector2 pos)
        {
            Position = pos;
            Show();
            // Must be deferred as we can't change physics properties on a physics callback.
            GetNode<CollisionShape2D>("CollisionShape2D").SetDeferred("disabled", false);
        }

        public void OnPlayerBodyEntered(PhysicsBody2D body)
        {
            Hide(); // Player disappears after being hit.
            EmitSignal(nameof(HitEventHandler));
            // Must be deferred as we can't change physics properties on a physics callback.
            GetNode<CollisionShape2D>("CollisionShape2D").SetDeferred("disabled", true);
        }
    }
}
