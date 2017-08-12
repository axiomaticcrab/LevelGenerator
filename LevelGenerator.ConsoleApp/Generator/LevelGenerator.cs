using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Generator.Spawner;
using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class LevelGenerator
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private IRenderer TileRenderer { get; set; }

        private IEnemySpawner enemySpawner;

        public LevelGenerator Init(int width, int height, IRenderer tileRenderer, IEnemySpawner enemySpawner)
        {
            this.enemySpawner = enemySpawner;
            Width = width;
            Height = height;
            TileRenderer = tileRenderer;
            return this;
        }

        public Level.Level Build()
        {
            Level.Level result = new Level.Level(Width, Height, new EnemySpawnRateContainer().Init());
            var width = Width / 2;
            var height = Height / 2;

            for (int x = (width * -1); x < width; x++)
            {
                for (int y = (height * -1); y < height; y++)
                {
                    var enemyTypeToSpawn = FindEnemyTypeToSpawn(result);

                    switch (enemyTypeToSpawn)
                    {
                        case EnemyType.None:
                            result.Tiles.Add(new Tile(new Vector2(x, y), null, TileRenderer));
                            break;
                        case EnemyType.Obstacle:
                            result.Tiles.Add(new Tile(new Vector2(x, y), enemySpawner.Spawn(enemyTypeToSpawn, new Vector2(x, y), 0.5f), TileRenderer));
                            break;
                        default:
                            result.Tiles.Add(new Tile(new Vector2(x, y), enemySpawner.Spawn(enemyTypeToSpawn, new Vector2(x, y)), TileRenderer));
                            break;
                    }
                }
            }
            return result;
        }

        private EnemyType FindEnemyTypeToSpawn(Level.Level level)
        {
            var random = CommonEntensions.GenerateRandom();
            foreach (var spawnRate in level.EnemySpawnRateContainer.EnemySpawnRates)
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
