using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public (double Min, double Max) GetMinMax1(out double minValue, out double maxValue)
        {
            minValue = double.MaxValue;
            maxValue = double.MinValue;

            foreach (double item in this)
            {
                if (item < minValue)
                    minValue = item;

                if (item > maxValue)
                    maxValue = item;
            }

            return (minValue, maxValue);
        }

        public MinMax GetMinMax2()
        {
            MinMax result = new MinMax
            {
                Min = double.MaxValue,
                Max = double.MinValue
            };

            foreach (double item in this)
            {
                if (item < result.Min)
                    result.Min = item;

                if (item > result.Max)
                    result.Max = item;
            }

            return result;
        }

        public (double Min, double Max) GetMinMax3()
        {
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;

            foreach (double item in this)
            {
                if (item < minValue)
                    minValue = item;

                if (item > maxValue)
                    maxValue = item;
            }

            return (minValue, maxValue);
        }

        public (double Minimum, double Maximum) GetMinMax4()
        {
            double minimum = double.MaxValue;
            double maximum = double.MinValue;

            foreach (double item in this)
            {
                if (item < minimum)
                    minimum = item;

                if (item > maximum)
                    maximum = item;
            }

            return (Minimum: minimum, Maximum: maximum);
        }

        public struct MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
    }
}