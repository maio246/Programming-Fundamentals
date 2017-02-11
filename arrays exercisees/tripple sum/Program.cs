using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripple_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            ParseFromStringToIntArray(input, numbers);

            bool hasFound = false;

            hasFound = TriplleSumAndPrint(input, numbers, hasFound);

            if (!hasFound)
            {
                Console.WriteLine("No");
            }
        }

        private static bool TriplleSumAndPrint(string[] input, int[] numbers, bool hasFound)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            hasFound = true;
                            break;
                        }
                    }
                }
            }

            return hasFound;
        }

        private static void ParseFromStringToIntArray(string[] input, int[] numbers)
        {
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
        }
    }
}
