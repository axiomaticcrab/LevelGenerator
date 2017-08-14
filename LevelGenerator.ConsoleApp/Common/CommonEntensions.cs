using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading;

namespace LevelGenerator.ConsoleApp.Common
{
    public static class CommonEntensions
    {
        public static int RandomGenerationSleepMilisecon = 10;

        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }

        public static T GetRandom<T>(this List<T> list)
        {
            return list[GenerateRandom(list.Count)];
        }

        public static object CreateRandomInstance(this List<Type> typeList, object[] args)
        {
            return Activator.CreateInstance(typeList.GetRandom(), args);
        }

        public static double GenerateRandom()
        {
            Thread.Sleep(RandomGenerationSleepMilisecon);
            Random random = new Random();
            return random.NextDouble();
        }

        public static int GenerateRandom(int max)
        {
            Thread.Sleep(RandomGenerationSleepMilisecon);
            Random random = new Random();
            return random.Next(max);
        }


        public static string SaveGeneratedHtmlFile(string fileName, string content)
        {
            var pathToSave = string.Empty;
            switch (Environment.MachineName)
            {
                case "DESKTOP-9OSBTS0":
                    pathToSave = GetKeyValueFromAppSettings<string>("GeneratedFilesSavePath2");
                    break;
                default:
                    pathToSave = GetKeyValueFromAppSettings<string>("GeneratedFilesSavePath");
                    break;
            }

            var filePath = CreateFile(pathToSave, fileName);
            File.WriteAllText(filePath, content);
            return filePath;
        }

        public static string CreateFile(string path, string fileName)
        {
            var pathToSave = string.Format("{0}\\{1}", path, fileName);
            var stream = File.Create(pathToSave);
            stream.Flush();
            stream.Close();
            return pathToSave;
        }

        public static T GetKeyValueFromAppSettings<T>(string key)
        {
            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        }
    }
}
