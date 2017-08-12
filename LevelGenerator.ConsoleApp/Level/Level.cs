using System.Collections.Generic;
using System.Linq;

namespace LevelGenerator.ConsoleApp.Level
{
    public class Level
    {
        private readonly int width;
        private readonly int height;
        public readonly List<Tile> tiles;
        private readonly int enemyCount;

        public Level(int width, int height, List<Tile> tiles)
        {
            this.width = width;
            this.height = height;
            this.tiles = tiles;
            this.enemyCount = tiles.Where(x => x.Enemy != null).ToList().Count;
        }
    }
}
