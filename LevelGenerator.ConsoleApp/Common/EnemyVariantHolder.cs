using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Common
{
    public class EnemyVariantHolder
    {
        public IEnemyRenderer EnemyRenderer { get; set; }
        public string Name { get; set; }
    }
}