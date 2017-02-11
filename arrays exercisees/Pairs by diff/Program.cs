using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            counter = GetPairsByDifference(arrayNumbers, difference, counter);
            Console.WriteLine(counter);
        }

        private static int GetPairsByDifference(int[] arrayNumbers, int difference, int counter)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (difference == arrayNumbers[i] - arrayNumbers[j])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
