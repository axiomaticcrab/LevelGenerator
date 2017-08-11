using BookGenerator.ConsoleApp.Domain.Level;
using BookGenerator.ConsoleApp.Render;

namespace BookGenerator.ConsoleApp.Domain.Enemy
{
    public interface IEnemy
    {
        IRenderer Renderer { get; }
        string Name { get;  }
        Vector2 Position { get; }
    }
}