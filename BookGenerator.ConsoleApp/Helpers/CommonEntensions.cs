using System;
using System.Collections.Generic;
using System.Threading;

namespace BookGenerator.ConsoleApp.Helpers
{
    public static class CommonEntensions
    {
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
            Thread.Sleep(50);
            return list[new Random().Next(0, list.Count)];
        }

        public static object CreateRandomInstance(this List<Type> typeList, params object[] args)
        {
            return Activator.CreateInstance(typeList.GetRandom(), args);
        }
    }
}
