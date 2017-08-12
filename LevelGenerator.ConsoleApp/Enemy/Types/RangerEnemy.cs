using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class RangerEnemy : Enemy
    {
        public RangerEnemy(Vector2 position, IEnemyRenderer enemyRenderer) : base(EnemyType.Ranger, position, enemyRenderer)
        {
        }
    }
}
