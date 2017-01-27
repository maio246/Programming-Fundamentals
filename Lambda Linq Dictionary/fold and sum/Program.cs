using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] firstRowLeft = numbers.Take(k).Reverse().ToArray();
            int[] firstRowRight = numbers.Reverse().Take(k).ToArray();
            int[] secondRow = numbers.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < k; i++)
            {
                secondRow[i] += firstRowLeft[i];
            }
            for (int i = 0; i < k; i++)
            {
                secondRow[i + k] += firstRowRight[i];
            }

            Console.WriteLine(string.Join(" ", secondRow));
        }
    }
}
