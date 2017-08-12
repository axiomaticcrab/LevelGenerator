using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class HrEnemy : Enemy
    {
        public HrEnemy(Vector2 position, IEnemyRenderer enemyRenderer)
            : base(EnemyType.Hr, position, enemyRenderer)
        {
        }
    }
}
