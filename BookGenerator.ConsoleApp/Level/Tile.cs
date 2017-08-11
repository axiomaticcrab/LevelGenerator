using LevelGenerator.ConsoleApp.Enemy;

namespace LevelGenerator.ConsoleApp.Level
{
    public class Tile
    {
        public Vector2 Position { get; set; }
        public IEnemy Enemy { get; set; }
    }
}
