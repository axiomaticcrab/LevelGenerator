using BookGenerator.ConsoleApp.Domain.Enemy.Behaviours;
using BookGenerator.ConsoleApp.Domain.Level;
using BookGenerator.ConsoleApp.Render;

namespace BookGenerator.ConsoleApp.Domain.Enemy.Instances
{
    public class TextObstacleEnemy : Enemy,ISlowPlayer
    {
        private readonly float _movementSpeedWhenWalkedOn;
        static readonly IRenderer renderer = new TextBasedRenderer("T");

        public TextObstacleEnemy(Vector2 position, float movementSpeedWhenWalkedOn) : base(renderer,"Text Obstacle Enemy", position)
        {
            _movementSpeedWhenWalkedOn = movementSpeedWhenWalkedOn;
        }

        double ISlowPlayer.MovementSpeedWhenWalkedOn
        {
            get { return _movementSpeedWhenWalkedOn; }
        }

    }
}