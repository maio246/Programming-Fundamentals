using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equal_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (inputArray.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool sumDoesntExists = true;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (LeftSum(i, inputArray) == RightSum(i, inputArray))
                    {
                        Console.WriteLine(i);
                        sumDoesntExists = false;
                    }
                }
                if (sumDoesntExists)
                {
                    Console.WriteLine("no");
                }
            }
        }

        private static int RightSum(int i, int[] inputArray)
        {
            int rightSum = 0;
            for (int j = i + 1; j < inputArray.Length; j++)
            {
                rightSum += inputArray[j];
            }
            return rightSum;
        }

        private static int LeftSum(int i, int[] inputArray)
        {
            int sumLeft = 0;
            for (int j = 0; j < i; j++)
            {
                sumLeft += inputArray[j];
            }
            return sumLeft;
        }
    }
}
