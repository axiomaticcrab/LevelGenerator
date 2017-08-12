using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class DpsEnemy : Enemy
    {
        public DpsEnemy(Vector2 position, IEnemyRenderer enemyRenderer) : base(EnemyType.Dps, position, enemyRenderer)
        {
        }
    }
}
