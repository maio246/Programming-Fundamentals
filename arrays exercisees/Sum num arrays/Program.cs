using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_num_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstNumbersLength = firstNumbers.Length;
            int[] secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int secondNumbersLength = secondNumbers.Length;

            int[] resultArray = new int[Math.Max(firstNumbers.Length, secondNumbers.Length)];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstNumbers[i % firstNumbersLength] + secondNumbers[i % secondNumbersLength];
            }
            foreach (int number in resultArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}
