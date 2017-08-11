using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelGenerator.ConsoleApp.Level
{
    public class World
    {
        private readonly int _width;
        private readonly int _height;
        private readonly List<Tile> _tiles;
        private readonly int _enemyCount;

        public World(int width, int height, List<Tile> tiles)
        {
            _width = width;
            _height = height;
            _tiles = tiles;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            var rows = _tiles.GroupBy(x => x.Position.Y).ToList();

            foreach (var row in rows)
            {
                foreach (var tile in row)
                {
                    if (tile.Enemy != null)
                    {
                        builder.Append(tile.Enemy.Renderer.Render());
                    }
                    else
                    {
                        builder.Append("-");
                    }
                }
                builder.Append(Environment.NewLine);
            }

            return builder.ToString();
        }
    }
}
