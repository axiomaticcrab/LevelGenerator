using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class RangerEnemy : Enemy
    {
        public RangerEnemy(IEnemyRenderer enemyRenderer, Vector2 position) : base(EnemyType.Ranger, position, enemyRenderer)
        {
        }
    }
}
