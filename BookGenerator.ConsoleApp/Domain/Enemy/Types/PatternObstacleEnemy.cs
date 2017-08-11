using BookGenerator.ConsoleApp.Domain.Enemy.Behaviours;
using BookGenerator.ConsoleApp.Domain.Level;
using BookGenerator.ConsoleApp.Render;

namespace BookGenerator.ConsoleApp.Domain.Enemy.Instances
{
    public class PatternObstacleEnemy : Enemy, ISlowPlayer
    {
        private readonly float _movementSpeedWhenWalkedOn;
        static readonly IRenderer renderer = new TextBasedRenderer("P");

        public PatternObstacleEnemy(Vector2 position, float movementSpeedWhenWalkedOn) : base(renderer,"Pattern Obstacle Enemy", position)
        {
            _movementSpeedWhenWalkedOn = movementSpeedWhenWalkedOn;
        }


        double ISlowPlayer.MovementSpeedWhenWalkedOn
        {
            get { return _movementSpeedWhenWalkedOn; }
        }
    }
}
