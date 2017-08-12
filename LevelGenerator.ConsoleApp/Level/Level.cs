using System.Collections.Generic;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;

namespace LevelGenerator.ConsoleApp.Level
{
    public class Level
    {
        public List<Tile> Tiles;
        public EnemySpawnRateContainer EnemySpawnRateContainer;

        private readonly int width;
        private readonly int height;
        private int enemyCount;

        public Level(int width, int height, EnemySpawnRateContainer enemySpawnRateContainer)
        {
            this.width = width;
            this.height = height;
            EnemySpawnRateContainer = enemySpawnRateContainer;
            Tiles = new List<Tile>();
            
        }

        public void SetTiles(List<Tile> tiles)
        {
            Tiles = tiles;
            enemyCount = tiles.Where(x => x.Enemy != null).ToList().Count;
        }
    }
}
