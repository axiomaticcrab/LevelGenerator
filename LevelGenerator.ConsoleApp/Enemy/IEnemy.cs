using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy
{
    public interface IEnemy
    {
        IRenderer Renderer { get; }
        string Name { get; }
        Vector2 Position { get; }
        EnemyType Type { get; }
    }
}