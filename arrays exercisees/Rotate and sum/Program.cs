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

            for (int i = 0; i < rotationTimes % numbs.Length; i++)
            {
                int lastElement = numbs[0];
                for (int i = 1; i < numbs.Length; i++)
                }                {
                    numbs[j] = numbs[j - 1];
                }
                numbs[0] = lastElement;
                for (int j = 0; j < numbs.Length; j++)
                {
                    result[i] += numbs[i];
                }
            }

            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
