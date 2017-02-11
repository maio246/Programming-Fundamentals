using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());

            int[] result = new int[numbs.Length];

            RotateAndSum(numbs, rotationTimes, result);
            Console.WriteLine(string.Join(" ", result));
        }

        private static void RotateAndSum(int[] numbs, int rotationTimes, int[] result)
        {
            for (int i = 0; i < rotationTimes; i++)
            {
                int lastDigit = numbs[numbs.Length - 1];

                for (int j = numbs.Length - 1; j > 0; j--)
                {
                    numbs[j] = numbs[j - 1];
                }

                numbs[0] = lastDigit;

                for (int j = 0; j < numbs.Length; j++)
                {
                    result[j] += numbs[j];
                }
            }
        }
    }
}
