using System.Configuration;
using LevelGenerator.ConsoleApp.Common;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class EnemySpawnRateContainer
    {
        #region Keys

        protected readonly string NoSpawnMinKey = "emptyTileMinSpawnRate";
        protected readonly string NoSpawnMaxKey = "emptyTileMaxSpawnRate";

        protected readonly string ObstacleMinSpawnKey = "obstacleMinEnemySpawnRate";
        protected readonly string ObstacleMaxSpawnKey = "obstacleMaxEnemySpawnRate";

        #endregion

        public DoubleRange NoSpawnRange { get; set; }
        public DoubleRange ObstacleSpanwRange { get; set; }

        public EnemySpawnRateContainer Init()
        {
            NoSpawnRange = new DoubleRange(GetKeyValueFromAppSettings(NoSpawnMinKey), GetKeyValueFromAppSettings(NoSpawnMaxKey));
            ObstacleSpanwRange = new DoubleRange(GetKeyValueFromAppSettings(ObstacleMinSpawnKey), GetKeyValueFromAppSettings(ObstacleMaxSpawnKey));
            return this;
        }

        protected double GetKeyValueFromAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key].ToDouble();
        }
    }
}