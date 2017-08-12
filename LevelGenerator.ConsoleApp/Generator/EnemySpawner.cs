using System;
using System.Collections.Generic;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class EnemySpawner
    {
        private readonly List<KeyValuePair<Type, EnemyType>> enemies = new List<KeyValuePair<Type, EnemyType>>
        {
            new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.ObstacleEnemy"),EnemyType.Obstacle),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.RangerEnemy"),EnemyType.Ranger)
        };

        private readonly List<KeyValuePair<EnemyType, IEnemyRenderer>> enemyVariants = new List<KeyValuePair<EnemyType, IEnemyRenderer>>
        {
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("P","Pattern")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("T","Text"))
        };

        public IEnemy Spawn(EnemyType enemyType, params object[] ctorArgs)
        {
            var renderer = enemyVariants.Where(x => x.Key == enemyType).ToList().GetRandom().Value;
            var objects = ctorArgs.ToList();
            objects.Add(renderer);
            return (IEnemy)enemies.Where(x => x.Value == enemyType).Select(x => x.Key).ToList().CreateRandomInstance(objects.ToArray());
        }
    }
}