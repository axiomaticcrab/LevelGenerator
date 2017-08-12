using System;
using System.Linq;
using System.Text;

namespace LevelGenerator.ConsoleApp.Render
{
    public class ConsoleLevelRenderer : ILevelRenderer
    {
        private readonly Level.Level level;

        public ConsoleLevelRenderer(Level.Level level)
        {
            this.level = level;
        }

        Level.Level ILevelRenderer.Level
        {
            get { return level; }
        }

        public void Render()
        {
            StringBuilder builder = new StringBuilder();
            var rows = level.tiles.GroupBy(x => x.Position.Y).ToList();

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
        }
    }
}