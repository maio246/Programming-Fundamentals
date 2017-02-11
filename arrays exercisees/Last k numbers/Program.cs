    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Last_k_numbers
    {
        class Program
        {
            static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int numbersToSum = int.Parse(Console.ReadLine());

            long[] result = new long[sequenceLength];
            result[0] = 1;

            SumLastNumbersToSum(sequenceLength, numbersToSum, result);
            Console.WriteLine(string.Join(" ", result));
        }

        private static void SumLastNumbersToSum(int sequenceLength, int numbersToSum, long[] result)
        {
            for (int i = 1; i < sequenceLength; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - numbersToSum; j--)
                {
                    sum += result[j];
                }
                result[i] = sum;
            }
        }
    }
    }
