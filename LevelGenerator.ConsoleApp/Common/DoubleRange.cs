using System;

namespace LevelGenerator.ConsoleApp.Common
{
    public class DoubleRange
    {
        public Double Min { get; protected set; }
        public Double Max { get; protected set; }

        public DoubleRange(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public bool HasValue(double value)
        {
            if (Min < value && value <= Max)
            {
                return true;
            }
            return false;
        }
    }
}