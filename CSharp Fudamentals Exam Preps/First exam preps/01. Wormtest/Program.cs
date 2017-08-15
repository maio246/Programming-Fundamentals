using System;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = long.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lengthConverted = length * 100.0;

            var division = (lengthConverted % width);

            if (width == 0)
            {
                var product = lengthConverted * width;
                Console.WriteLine($"{product:f2}");
                return;
            }

            if (division != 0)
            {
                var product = (lengthConverted / width) * 100.0;
                Console.WriteLine($"{product:f2}%");
            }
            else
            {
                var product = lengthConverted * width;
                Console.WriteLine($"{product:f2}");
            }
        }
    }
}
