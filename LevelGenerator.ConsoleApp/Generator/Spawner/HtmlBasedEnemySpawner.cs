using System.Collections.Generic;
using LevelGenerator.ConsoleApp.Enemy;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Generator.Spawner
{
    public class HtmlBasedEnemySpawner : EnemySpawner, IEnemySpawner
    {
        public List<KeyValuePair<EnemyType, IEnemyRenderer>> EnemyVariants
        {
            get
            {
                return new List<KeyValuePair<EnemyType, IEnemyRenderer>>
                {
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/unob1menvnle0pl/pattern.png?raw=1", "Pattern")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Obstacle, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/w6r3d0rp8nqxzol/text.png?raw=1", "Text")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/zh08688lmf5mjjq/function.png?raw=1", "Function")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Ranger, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/0a79w1b6hlz9bkf/integral.png?raw=1", "Integral")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Dps, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/r066c3imirwo3g7/odd%20guy.png?raw=1", "OddGuy")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Aoe, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/k2bo3wppn8ym4cn/bored%20face%20idle.png?raw=1", "BoredGuy")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Tod, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/hxp2lc7bnoarczn/scribble.png?raw=1", "Scribble")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Cf, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/3e6u2kolla455ar/woodpecker.jpg?raw=1", "Woodpecker")),
                    new KeyValuePair<EnemyType, IEnemyRenderer>(EnemyType.Hr, new HtmlBasedEnemyRenderer("https://www.dropbox.com/s/c9dk0cikvvj7k2v/flag%20idle.png?raw=1", "Flag"))
                };
            }
        }
    }
}