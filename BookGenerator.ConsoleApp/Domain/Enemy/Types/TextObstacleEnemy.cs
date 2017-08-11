using LevelGenerator.ConsoleApp.Domain.Enemy.Behaviours;
using LevelGenerator.ConsoleApp.Domain.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Domain.Enemy.Types
{
    public class TextObstacleEnemy : Enemy,ISlowPlayer
    {
        private readonly double _movementSpeedWhenWalkedOn;
        static readonly IRenderer renderer = new TextBasedRenderer("T");

        public TextObstacleEnemy(Vector2 position, double movementSpeedWhenWalkedOn) : base(renderer,"Text Obstacle Enemy", position)
        {
            _movementSpeedWhenWalkedOn = movementSpeedWhenWalkedOn;
        }

        double ISlowPlayer.MovementSpeedWhenWalkedOn
        {
            get { return _movementSpeedWhenWalkedOn; }
        }

    }
}