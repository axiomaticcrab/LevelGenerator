using System.Collections.Generic;
using LevelGenerator.ConsoleApp.Enemy;

namespace LevelGenerator.ConsoleApp.Common
{
    public class EnemySpawnRateContainer
    {

        public List<KeyValuePair<EnemyType, DoubleRange>> EnemySpawnRates = new List<KeyValuePair<EnemyType, DoubleRange>>();

        private readonly List<KeyValuePair<EnemyType, string>> enemySpawnRateKeys = new List<KeyValuePair<EnemyType, string>>
        {
            new KeyValuePair<EnemyType, string>(EnemyType.None, "emptyTileSpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Obstacle, "obstacleEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Ranger, "rangerEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Dps, "dpsEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Aoe, "aoeEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Tod, "todEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Cf, "cfEnemySpawnRate"),
            new KeyValuePair<EnemyType, string>(EnemyType.Hr, "hrEnemySpawnRate")
        };

        public DoubleRange NoSpawnRange { get; set; }
        public DoubleRange ObstacleSpanwRange { get; set; }
        public DoubleRange RangerSpanwRange { get; set; }

        public EnemySpawnRateContainer Init()
        {

            foreach (var enemySpawnRateKey in enemySpawnRateKeys)
            {
                var min = CommonEntensions.GetKeyValueFromAppSettings<double>(enemySpawnRateKey.Value + "Min");
                var max = CommonEntensions.GetKeyValueFromAppSettings<double>(enemySpawnRateKey.Value + "Max");

                EnemySpawnRates.Add(new KeyValuePair<EnemyType, DoubleRange>(enemySpawnRateKey.Key, new DoubleRange(min, max)));
            }
            return this;
        }

        
    }
}