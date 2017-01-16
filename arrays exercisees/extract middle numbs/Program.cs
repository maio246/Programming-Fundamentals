using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extract_middle_numbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = GetMiddleNumbers(numbers);
            Console.Write("{ ");
            for (int i = 1; i <= result.Count; i++)
            {
                Console.Write(result[i - 1]);
                if (i < result.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");

        }

        static List<int> GetMiddleNumbers(int[] numbers)
        {
            List<int> tempArray = new List<int>();
            if (numbers.Length == 1)
            {
                tempArray.Add(numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                tempArray.Add(numbers[numbers.Length / 2 - 1]);
                tempArray.Add(numbers[numbers.Length / 2]);
            }
            else
            {
                tempArray.Add(numbers[numbers.Length / 2 - 1]);
                tempArray.Add(numbers[numbers.Length / 2]);
                tempArray.Add(numbers[numbers.Length / 2 + 1]);

            }
            return tempArray;
        }
    }
}
