using System;
using System.Diagnostics;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Generator.Spawner;
using LevelGenerator.ConsoleApp.Render.Enemy;
using LevelGenerator.ConsoleApp.Render.Level;
using LevelGenerator.ConsoleApp.Render.Tile;

namespace LevelGenerator.ConsoleApp
{
    static class Program
    {
        private static readonly Generator.LevelGenerator LevelGenerator = new Generator.LevelGenerator();
        public static RenderingOption RenderingOption = RenderingOption.HtmlFile;

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter Level Width And Height");
                var widthAndHeight = Console.ReadLine();
                if (string.IsNullOrEmpty(widthAndHeight))
                {
                    GenerateLevel(30, 10);
                }
                else
                {
                    var list = widthAndHeight.Split(' ').ToList();
                    var worldWidth = list.First().ToInt();
                    var worldHeight = list.Last().ToInt();
                    GenerateLevel(worldWidth, worldHeight);
                }
            }
        }

        static void GenerateLevel(int width, int height)
        {
            Console.WriteLine("********* Generating a Level Width:{0} Height:{1}", width, height);
            var startDate = DateTime.Now;

            switch (RenderingOption)
            {
                case RenderingOption.Console:
                    Render(LevelGenerator.Init(width, height, new TextBasedEnemyRenderer("-","Tile"), new TextBasedEnemySpawner()).Build());
                    break;
                case RenderingOption.HtmlFile:
                    Render(LevelGenerator.Init(width, height, new HtmlBasedTileRenderer("https://www.dropbox.com/s/l6nu7zxehqc6qtq/tile.png?raw=1"), new HtmlBasedEnemySpawner()).Build());
                    break;
            }
            Console.WriteLine("********* Generated a Level in {0}", DateTime.Now.Subtract(startDate));
        }

        static void Render(Level.Level level)
        {
            switch (RenderingOption)
            {
                case RenderingOption.Console:
                    ILevelRenderer consoleRenderer = new ConsoleLevelRenderer().Init(level);
                    consoleRenderer.Render();
                    break;
                case RenderingOption.HtmlFile:
                    ILevelRenderer htmlRenderer = new HtmlLevelRenderer().Init(level);
                    var saveGeneratedHtmlFile = CommonEntensions.SaveGeneratedHtmlFile("generatedLevelFile"+".html", htmlRenderer.Render().ToString());
                    Process.Start(saveGeneratedHtmlFile);
                    break;
            }
        }
    }

    enum RenderingOption
    {
        Console = 1,
        HtmlFile = 2
    }
}
