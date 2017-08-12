using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class CfEnemy : Enemy
    {
        public CfEnemy(Vector2 position, IEnemyRenderer enemyRenderer)
            : base(EnemyType.Cf, position, enemyRenderer)
        {
        }
    }
}
