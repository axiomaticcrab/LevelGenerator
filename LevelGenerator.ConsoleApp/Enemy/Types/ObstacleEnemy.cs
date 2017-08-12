using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy.Behaviours;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class ObstacleEnemy : Enemy, ISlowPlayer
    {
        private readonly double movementSpeedWhenWalkedOn;

        public ObstacleEnemy(Vector2 position, double movementSpeedWhenWalkedOn, IEnemyRenderer enemyRenderer) : base(EnemyType.Obstacle, position, enemyRenderer)
        {
            this.movementSpeedWhenWalkedOn = movementSpeedWhenWalkedOn;
        }


        double ISlowPlayer.MovementSpeedWhenWalkedOn
        {
            get { return movementSpeedWhenWalkedOn; }
        }
    }
}
