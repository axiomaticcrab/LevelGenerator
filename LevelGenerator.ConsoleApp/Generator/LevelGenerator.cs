using System.Collections.Generic;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Level;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class LevelGenerator
    {
        private int Width { get; set; }
        private int Height { get; set; }

        private EnemySpawner enemySpawner;
        private EnemySpawnRateContainer enemySpawnRateContainer;


        public LevelGenerator Init(int width, int height)
        {
            enemySpawner = new EnemySpawner();
            Width = width;
            Height = height;
            return this;
        }

        public Level.Level Build()
        {
            enemySpawnRateContainer = new EnemySpawnRateContainer().Init();
            var tileList = new List<Tile>();
            var width = Width / 2;
            var height = Height / 2;

            for (int x = (width * -1); x < width; x++)
            {
                for (int y = (height * -1); y < height; y++)
                {
                    var tile = new Tile
                    {
                        Position = new Vector2(x, y)
                    };

                    var enemyTypeToSpawn = FindEnemyTypeToSpawn(CommonEntensions.GenerateRandom());

                    if (enemyTypeToSpawn!=EnemyType.None)
                    {
                        switch (enemyTypeToSpawn)
                        {
                            case EnemyType.Obstacle:
                                tile.Enemy = enemySpawner.Spawn(enemyTypeToSpawn, new Vector2(x, y), 0.5f);
                                break;
                            default:
                                tile.Enemy = enemySpawner.Spawn(enemyTypeToSpawn, new Vector2(x, y));
                                break;
                        }    
                    }
                    
                    tileList.Add(tile);
                }
            }
            return new Level.Level(Width, Height, tileList);
        }

        private EnemyType FindEnemyTypeToSpawn(double random)
        {
            foreach (var spawnRate in enemySpawnRateContainer.EnemySpawnRates)
            {
                if (spawnRate.Value.Min < random && random <= spawnRate.Value.Max)
                {
                    return spawnRate.Key;
                }
            }
            return EnemyType.None;
        }
    }
}
