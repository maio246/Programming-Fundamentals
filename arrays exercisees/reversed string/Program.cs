using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Away_From_Zero

{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                         .Split(' ')
                         .Select(double.Parse)
                         .ToArray();

            RoundAwayFromZeroAndPrint(array);

        }

        private static void RoundAwayFromZeroAndPrint(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}