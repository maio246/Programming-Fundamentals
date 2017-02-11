using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rounding_away_from_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double[] result = new double[inputNumbers.Length];

            RoundAwayFromZero(inputNumbers, result);

            PrintResult(inputNumbers, result);
        }

        private static void PrintResult(double[] inputNumbers, double[] result)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine($"{inputNumbers[i]} => {result[i]}");
            }
        }

        private static void RoundAwayFromZero(double[] inputNumbers, double[] result)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                result[i] = Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero);
            }
        }
    }
}
