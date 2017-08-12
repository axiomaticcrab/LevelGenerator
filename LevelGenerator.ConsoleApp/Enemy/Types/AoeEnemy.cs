using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class AoeEnemy : Enemy
    {
        public AoeEnemy(Vector2 position, IEnemyRenderer enemyRenderer)
            : base(EnemyType.Aoe, position, enemyRenderer)
        {
        }
    }
}
