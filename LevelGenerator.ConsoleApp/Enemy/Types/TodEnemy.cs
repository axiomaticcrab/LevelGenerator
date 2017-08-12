using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class TodEnemy : Enemy
    {
        public TodEnemy(Vector2 position, IEnemyRenderer enemyRenderer) : base(EnemyType.Tod, position, enemyRenderer)
        {
        }
    }
}
