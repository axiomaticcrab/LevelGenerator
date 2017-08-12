using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render;

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
