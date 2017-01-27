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
            int k = arrayNumbers.Length / 4;
            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];
            int counter = 0;
            int secondCounter = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                firstRow[counter] = arrayNumbers[i];
                counter++;
            }
            for (int i = arrayNumbers.Length - 1; i >= (k - 1) * 3 / 4; i--)
            {
                firstRow[counter] = arrayNumbers[counter];
                counter++;
            }
            for (int i = k - 1; i <= (arrayNumbers.Length - 1) * 3 / 4; i++)
            {
                secondRow[secondCounter] = arrayNumbers[k];
                secondCounter++;
            }
            foreach (int number in firstRow)
            {
                Console.Write(number);
            }
        }
    }
}
