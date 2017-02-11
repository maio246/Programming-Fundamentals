using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            GetAndSumAdjusentNumbs(inputNumbers);

            Console.WriteLine(string.Join(" ", inputNumbers));
        }

        private static void GetAndSumAdjusentNumbs(List<double> inputNumbers)
        {
            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == (inputNumbers[i - 1]))
                {
                    inputNumbers[i - 1] += inputNumbers[i];
                    inputNumbers.Remove(inputNumbers[i]);
                    i = 0;
                }
            }
        }
    }
}
