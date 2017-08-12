using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Generator
{
    public class EnemyVariantHolder
    {
        public IEnemyRenderer EnemyRenderer { get; set; }
        public string Name { get; set; }
    }
}