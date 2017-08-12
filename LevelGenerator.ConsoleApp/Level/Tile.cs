using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Level
{
    public class Tile
    {
        public IRenderer Renderer { get; protected set; }
        public Vector2 Position { get; protected set; }
        public IEnemy Enemy { get; protected set; }

        public Tile(Vector2 position)
        {
            Position = position;
        }

        public Tile(Vector2 position, IEnemy enemy)
        {
            Position = position;
            Enemy = enemy;
        }

        public Tile(Vector2 position, IEnemy enemy, IRenderer renderer)
        {
            Position = position;
            Enemy = enemy;
            Renderer = renderer;
        }

        public Tile SetEnemy(IEnemy enemy)
        {
            Enemy = enemy;
            return this;
        }

        public Tile SetRenderer(IRenderer renderer)
        {
            Renderer = renderer;
            return this;
        }
    }
}
