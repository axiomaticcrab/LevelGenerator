using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

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

        public World Build()
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

                    var random = CommonEntensions.GenerateRandom();

                    var findEnemyTypeToSpawn = FindEnemyTypeToSpawn(random);

                    switch (findEnemyTypeToSpawn)
                    {
                            case EnemyType.Obstacle:
                            tile.Enemy = enemySpawner.Spawn(findEnemyTypeToSpawn, new Vector2(x, y), 0.5f);
                            break;
                    }
                    tileList.Add(tile);
                }
            }
            return new World(Width, Height, tileList);
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

    public class EnemySpawner
    {
        private readonly List<KeyValuePair<Type, EnemyType>> _enemies = new List<KeyValuePair<Type, EnemyType>>
        {
            new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.ObstacleEnemy"),EnemyType.Obstacle),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.RangerEnemy"),EnemyType.Ranger)
        };

        private readonly List<KeyValuePair<EnemyType, IRenderer>> _enemyVariants = new List<KeyValuePair<EnemyType, IRenderer>>
        {
            new KeyValuePair<EnemyType, IRenderer>(EnemyType.Obstacle, new TextBasedRenderer("P","Pattern")),
            new KeyValuePair<EnemyType, IRenderer>(EnemyType.Obstacle, new TextBasedRenderer("T","Text"))
        };

        public IEnemy Spawn(EnemyType enemyType, params object[] ctorArgs)
        {
            var renderer = _enemyVariants.Where(x => x.Key == enemyType).ToList().GetRandom().Value;
            var objects = ctorArgs.ToList();
            objects.Add(renderer);
            return (IEnemy)_enemies.Where(x => x.Value == enemyType).Select(x => x.Key).ToList().CreateRandomInstance(objects.ToArray());
        }
    }

    public class EnemyVariantHolder
    {
        public IRenderer Renderer { get; set; }
        public string Name { get; set; }
    }
}
