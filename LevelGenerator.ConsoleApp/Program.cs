using System;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp
{
    static class Program
    {
        private static readonly Generator.LevelGenerator Generator = new Generator.LevelGenerator();
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
            var worldGenerationResult = Generator.Init(width, height)
                .Build();
            Render(worldGenerationResult);
            Console.WriteLine("********* Generated a Level in {0}", DateTime.Now.Subtract(startDate));
        }

        static void Render(Level.Level level)
        {
            ILevelRenderer consoleRenderer = new ConsoleLevelRenderer(level);
            consoleRenderer.Render();
        }
    }
}
