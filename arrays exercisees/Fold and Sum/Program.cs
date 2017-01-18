using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] firstRow = new int[arrayNumbers.Length / 2];
            int[] secondRow = new int[arrayNumbers.Length / 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = arrayNumbers[i];
                firstRow[firstRow.Length / 2] = arrayNumbers[(arrayNumbers.Length - 1) - i];
            }
            //for (int i = 1; i < arrayLength; i++)
            //{
            //    secondRow[arrayLength - i] = arrayNumbers[arrayNumbers.Length - i];
            //    secondRow[i] = arrayNumbers[(arrayLength - 1) - i];
            //}
            foreach (int number in firstRow)
            {
                Console.Write(number);
            }
            foreach (int number in secondRow)
            {
                Console.WriteLine(number);
            }
        }
    }
}
