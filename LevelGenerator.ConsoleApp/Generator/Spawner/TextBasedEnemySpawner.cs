using System.Collections.Generic;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Generator.Spawner
{
    public class TextBasedEnemySpawner : EnemySpawner, IEnemySpawner
    {


        public List<KeyValuePair<EnemyType, IEnemyRenderer>> EnemyVariants
        {
            get
            {
                return new List<KeyValuePair<EnemyType, IEnemyRenderer>>
                {
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("P", "Pattern")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new TextBasedEnemyRenderer("T", "Text")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new TextBasedEnemyRenderer("F", "Function")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new TextBasedEnemyRenderer("I", "Integral")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Dps, new TextBasedEnemyRenderer("O", "OddGuy")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Aoe, new TextBasedEnemyRenderer("B", "BoredGuy")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Tod, new TextBasedEnemyRenderer("S", "Scribble")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Cf, new TextBasedEnemyRenderer("W", "Woodpecker")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Hr, new TextBasedEnemyRenderer("D", "Dust")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Hr, new TextBasedEnemyRenderer("B", "Bird"))
                };
            }
        }
    }
}