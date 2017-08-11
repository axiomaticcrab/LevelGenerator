using LevelGenerator.ConsoleApp.Domain.Enemy;

namespace LevelGenerator.ConsoleApp.Domain.Level
{
    public class Tile
    {
        public Vector2 Position { get; set; }
        public IEnemy Enemy { get; set; }
    }
}
