using System.Collections.Generic;
using System.Configuration;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Enemy;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class EnemySpawnRateContainer
    {

        public List<KeyValuePair<EnemyType, DoubleRange>> EnemySpawnRates = new List<KeyValuePair<EnemyType, DoubleRange>>();

        private readonly List<KeyValuePair<EnemyType, string>> _enemySpawnRateKeys = new List<KeyValuePair<EnemyType, string>>
        {
            new KeyValuePair<EnemyType, string>(EnemyType.Obstacle, "obstacleEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.None, "obstacleEnemySpawnRate")
        };

        public DoubleRange NoSpawnRange { get; set; }
        public DoubleRange ObstacleSpanwRange { get; set; }
        public DoubleRange RangerSpanwRange { get; set; }

        public EnemySpawnRateContainer Init()
        {

            foreach (var enemySpawnRateKey in _enemySpawnRateKeys)
            {
                var min = GetKeyValueFromAppSettings(enemySpawnRateKey.Value + "Min");
                var max = GetKeyValueFromAppSettings(enemySpawnRateKey.Value + "Max");

                EnemySpawnRates.Add(new KeyValuePair<EnemyType, DoubleRange>(enemySpawnRateKey.Key, new DoubleRange(min, max)));
            }
            return this;
        }

        protected double GetKeyValueFromAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key].ToDouble();
        }
    }
}