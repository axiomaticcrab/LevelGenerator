using System;
using System.Collections.Generic;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;

namespace LevelGenerator.ConsoleApp.Generator.Spawner
{
    public class EnemySpawner
    {
        public List<KeyValuePair<Type, EnemyType>> Enemies
        {
            get
            {
                return new List<KeyValuePair<Type, EnemyType>>
                {
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.ObstacleEnemy"), EnemyType.Obstacle),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.RangerEnemy"), EnemyType.Ranger),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.DpsEnemy"), EnemyType.Dps),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.AoeEnemy"), EnemyType.Aoe),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.TodEnemy"), EnemyType.Tod),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.CfEnemy"), EnemyType.Cf),
                    new KeyValuePair<Type, EnemyType>(Type.GetType("LevelGenerator.ConsoleApp.Enemy.Types.HrEnemy"), EnemyType.Hr)
                };
            }
        }

        public IEnemy Spawn(EnemyType enemyType, params object[] ctorArgs)
        {
            var renderer = ((IEnemySpawner)this).EnemyVariants.Where(x => x.Key == enemyType).ToList().GetRandom().Value;
            var objects = ctorArgs.ToList();
            objects.Add(renderer);
            return (IEnemy)Enemies.Where(x => x.Value == enemyType).Select(x => x.Key).ToList().CreateRandomInstance(objects.ToArray());
        }
    }
}