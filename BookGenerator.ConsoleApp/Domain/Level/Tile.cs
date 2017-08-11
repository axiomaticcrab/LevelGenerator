using BookGenerator.ConsoleApp.Domain.Enemy;

namespace BookGenerator.ConsoleApp.Domain.Level
{
    public class Tile
    {
        public Vector2 Position { get; set; }
        public IEnemy Enemy { get; set; }
    }
}
