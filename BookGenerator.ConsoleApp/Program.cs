using System;
using System.Linq;
using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Domain.Level;

namespace LevelGenerator.ConsoleApp
{
    static class Program
    {
        private static readonly Generator.LevelGenerator Generator = new Generator.LevelGenerator();
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter World Width Height");
                var widthAndHeight = Console.ReadLine();
                if (string.IsNullOrEmpty(widthAndHeight))
                {
                    GenerateBook(30, 10);
                }
                else
                {
                    var list = widthAndHeight.Split(' ').ToList();
                    var worldWidth = list.First().ToInt();
                    var worldHeight = list.Last().ToInt();
                    GenerateBook(worldWidth, worldHeight);
                }
            }
        }

        static void GenerateBook(int width, int height)
        {
            Console.WriteLine(String.Format("********* Generating a World Width:{0} Height:{1}", width, height));
            var startDate = DateTime.Now;
            var worldGenerationResult = Generator.Init(width, height)
                .Build();
            Log(worldGenerationResult);
            Console.WriteLine(String.Format("********* Generated A World in {0}", DateTime.Now.Subtract(startDate)));
        }

        static void Log(World world)
        {
            Console.Write(world.ToString());
        }
    }
}
