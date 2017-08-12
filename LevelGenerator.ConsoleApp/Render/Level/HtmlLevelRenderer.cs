using System;
using System.IO;
using System.Linq;
using System.Text;
using LevelGenerator.ConsoleApp.Common;

namespace LevelGenerator.ConsoleApp.Render.Level
{
    public class HtmlLevelRenderer : ILevelRenderer
    {
        private ConsoleApp.Level.Level level;
        ConsoleApp.Level.Level ILevelRenderer.Level
        {
            get { throw new NotImplementedException(); }
        }

        public ILevelRenderer Init(ConsoleApp.Level.Level level)
        {
            this.level = level;
            return this;
        }

        public object Render()
        {
            var template = File.ReadAllText(CommonEntensions.GetKeyValueFromAppSettings<string>("LevelHtmlFileTemplatePath"));
            StringBuilder builder = new StringBuilder();
            var rows = level.Tiles.GroupBy(x => x.Position.Y).ToList();

            int i = 0;
            foreach (var row in rows)
            {
                builder.Append("<tr>");
                foreach (var tile in row)
                {
                    var tileOutput = tile.Renderer.Render().ToString();

                    if (tile.Enemy != null)
                    {
                        tileOutput = tileOutput.Replace("@enemy", tile.Enemy.EnemyRenderer.Render().ToString());
                    }
                    else
                    {
                        tileOutput = tileOutput.Replace("@enemy", "");
                    }
                    builder.Append("<td>" + tileOutput + "</td>");
                }
                builder.Append("</tr>");
                i++;
                if (i < rows.Count)
                {
                    builder.Append("<tr>");
                }
            }

            return template.Replace("@tiles", builder.ToString());
        }
    }
}