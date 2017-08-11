using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using BookGenerator.ConsoleApp.Domain.Enemy;
using BookGenerator.ConsoleApp.Domain.Level;
using BookGenerator.ConsoleApp.Helpers;

namespace BookGenerator.ConsoleApp.Generator
{
    public class WorldGenerator
    {
        private int Width { get; set; }
        private int Height { get; set; }

        private double _emptyTileTreshold;
        private double _obstacleEmenyTreshold;

        private readonly List<Type> _obstacleEnemies = new List<Type>
        {
            Type.GetType("BookGenerator.ConsoleApp.Domain.Enemy.Instances.PatternObstacleEnemy"),
            Type.GetType("BookGenerator.ConsoleApp.Domain.Enemy.Instances.TextObstacleEnemy"),
        };

        public WorldGenerator Init(int width, int height)
        {
            Width = width;
            Height = height;
            return this;
        }

        public World Build()
        {
            _emptyTileTreshold = ConfigurationManager.AppSettings["emptyTileTreshold"].ToDouble();
            _obstacleEmenyTreshold = ConfigurationManager.AppSettings["obstacleEnemyTreshold"].ToDouble();

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

                    if (_emptyTileTreshold < GenerateRandom())
                    {
                        //not empty
                        if (_obstacleEmenyTreshold < GenerateRandom())
                        {
                            tile.Enemy = (IEnemy) _obstacleEnemies.CreateRandomInstance(new Vector2(x, y), 0.5f);
                        }
                    }

                    tileList.Add(tile);
                    Thread.Sleep(10);
                }
            }
            return new World(Width, Height, tileList);
        }

        private double GenerateRandom()
        {
            Random random = new Random();
            return random.NextDouble();
        }

    }
}
