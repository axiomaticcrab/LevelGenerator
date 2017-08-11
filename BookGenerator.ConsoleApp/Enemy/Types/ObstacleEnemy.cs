using LevelGenerator.ConsoleApp.Enemy.Behaviours;
using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class ObstacleEnemy : Enemy, ISlowPlayer
    {
        private readonly double _movementSpeedWhenWalkedOn;

        public ObstacleEnemy(Vector2 position, double movementSpeedWhenWalkedOn, IRenderer renderer) : base(EnemyType.Obstacle, position, renderer)
        {
            _movementSpeedWhenWalkedOn = movementSpeedWhenWalkedOn;
        }


        double ISlowPlayer.MovementSpeedWhenWalkedOn
        {
            get { return _movementSpeedWhenWalkedOn; }
        }
    }
}
