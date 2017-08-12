using System;
using System.Collections.Generic;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Generator.Spawner
{
    public interface IEnemySpawner
    {
        List<KeyValuePair<Type, EnemyType>> Enemies { get; }
        List<KeyValuePair<EnemyType, IEnemyRenderer>> EnemyVariants { get; }
        IEnemy Spawn(EnemyType enemyType, params object[] ctorArgs);
    }
}