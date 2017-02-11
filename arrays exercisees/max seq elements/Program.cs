using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_seq_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentCount = 1;

            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentCount++;
                    if (currentCount > bestLength)
                    {
                        bestStart = i - currentCount;
                        bestLength = currentCount;
                    }
                }
                else if (input[i] != input[i - 1])
                {
                    currentCount = 1;
                }
            }
            for (int i = bestStart + 1; i < bestLength + bestStart + 1; i++)
            {
                Console.Write($"{input[i]} ");
            }
            Console.WriteLine();
        }
    }
}
