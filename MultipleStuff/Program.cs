using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList superList = new SuperList();
            superList.AddRange(new double[] { 10.5, 5.6, 7.3, 62.5, 8.3 });

            double minValue1, maxValue1;
            (double minValue2, double maxValue2) = superList.GetMinMax1(out minValue1, out maxValue1);
            (double minValue3, double maxValue3) = superList.GetMinMax3();
            (double minimum4, double maximum4) = superList.GetMinMax4();

            Console.WriteLine("V1:");
            Console.WriteLine($"Min: {minValue1}");
            Console.WriteLine($"Max: {maxValue1}");
            Console.WriteLine();

            Console.WriteLine("V2:");
            Console.WriteLine($"Min: {minValue2}");
            Console.WriteLine($"Max: {maxValue2}");
            Console.WriteLine();

            Console.WriteLine("V3:");
            Console.WriteLine($"Min: {minValue3}");
            Console.WriteLine($"Max: {maxValue3}");
            Console.WriteLine();

            Console.WriteLine("V4:");
            Console.WriteLine($"Min: {minimum4}");
            Console.WriteLine($"Max: {maximum4}");
        }
    }
}
