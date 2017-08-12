using System;
using System.Linq;
using System.Text;

namespace LevelGenerator.ConsoleApp.Render.Level
{
    public class ConsoleLevelRenderer : ILevelRenderer
    {
        private ConsoleApp.Level.Level level;

        ConsoleApp.Level.Level ILevelRenderer.Level
        {
            get { return level; }
        }

        public ILevelRenderer Init(ConsoleApp.Level.Level level)
        {
            this.level = level;
            return this;
        }

        public object Render()
        {
            StringBuilder builder = new StringBuilder();
            var rows = level.Tiles.GroupBy(x => x.Position.Y).ToList();

            foreach (var row in rows)
            {
                foreach (var tile in row)
                {
                    if (tile.Enemy != null)
                    {
                        builder.Append(tile.Enemy.EnemyRenderer.Render());
                    }
                    else
                    {
                        builder.Append("-");
                    }
                }
                builder.Append(Environment.NewLine);
            }

            Console.Write(builder.ToString());
            return null;
        }
    }
}