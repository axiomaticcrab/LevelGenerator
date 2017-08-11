using System;
using System.Collections.Generic;
using System.Threading;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Domain.Enemy;
using LevelGenerator.ConsoleApp.Domain.Level;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class LevelGenerator
    {
        private int Width { get; set; }
        private int Height { get; set; }

        private readonly List<Type> _obstacleEnemies = new List<Type>
        {
            Type.GetType("LevelGenerator.ConsoleApp.Domain.Enemy.Types.PatternObstacleEnemy"),
            Type.GetType("LevelGenerator.ConsoleApp.Domain.Enemy.Types.TextObstacleEnemy"),
        };

        public LevelGenerator Init(int width, int height)
        {
            Width = width;
            Height = height;
            return this;
        }

        public World Build()
        {
            var enemySpawnRates = new EnemySpawnRateContainer().Init();
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

                    var random = GenerateRandom();

                    if (enemySpawnRates.NoSpawnRange.HasValue(random)==false)
                    {
                        if (enemySpawnRates.ObstacleSpanwRange.HasValue(random))
                        {
                            tile.Enemy=SpawnRandomObstacle(new Vector2(x, y), 0.5f);
                        }
                    }

                    tileList.Add(tile);
                }
            }
            return new World(Width, Height, tileList);
        }

        private IEnemy SpawnRandomObstacle(Vector2 position,double movementSpeedWhenWalkedOn)
        {
            return (IEnemy)_obstacleEnemies.CreateRandomInstance(position,movementSpeedWhenWalkedOn);
        }

        private double GenerateRandom()
        {
            Thread.Sleep(10);
            Random random = new Random();
            return random.NextDouble();
        }

    }
}
