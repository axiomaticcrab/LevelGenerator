using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy
{
    public interface IEnemy
    {
        IEnemyRenderer EnemyRenderer { get; }
        string Name { get; }
        Vector2 Position { get; }
        EnemyType Type { get; }
    }
}