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
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.RangerEnemy"),EnemyType.Ranger),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.DpsEnemy"),EnemyType.Dps),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.AoeEnemy"),EnemyType.Aoe),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.TodEnemy"),EnemyType.Tod),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.CfEnemy"),EnemyType.Cf),
            new KeyValuePair<Type, EnemyType>(Type.GetType( "LevelGenerator.ConsoleApp.Enemy.Types.HrEnemy"),EnemyType.Hr)
        };

        private readonly List<KeyValuePair<EnemyType, IEnemyRenderer>> enemyVariants = new List<KeyValuePair<EnemyType, IEnemyRenderer>>
        {
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("P","Pattern")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("T","Text")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new TextBasedEnemyRenderer("F","Function")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new TextBasedEnemyRenderer("I","Integral")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Dps, new TextBasedEnemyRenderer("O","OddGuy")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Aoe, new TextBasedEnemyRenderer("B","BoredGuy")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Tod, new TextBasedEnemyRenderer("S","Scribble")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Cf, new TextBasedEnemyRenderer("W","Woodpecker")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Hr, new TextBasedEnemyRenderer("D","Dust")),
            new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Hr, new TextBasedEnemyRenderer("B","Bird"))
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