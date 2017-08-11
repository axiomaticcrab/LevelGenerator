using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy.Types
{
    public class RangerEnemy : Enemy
    {
        public RangerEnemy(IRenderer renderer, string name, Vector2 position) : base(EnemyType.Ranger, position, renderer)
        {
        }
    }
}
