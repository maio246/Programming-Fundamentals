using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            int[] count = SortAndCountNumbOccurances(inputNumbers);

            FillResultDictionary(inputNumbers, result, count);

            PrintResult(result);
        }

        private static void PrintResult(SortedDictionary<int, int> result)
        {
            foreach (KeyValuePair<int, int> numb in result)
            {
                Console.WriteLine($"{numb.Key} -> {numb.Value}");
            }
        }

        private static void FillResultDictionary(List<int> inputNumbers, SortedDictionary<int, int> result, int[] count)
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    result[inputNumbers[i]] = count[i];
                }
            }
        }

        private static int[] SortAndCountNumbOccurances(List<int> inputNumbers)
        {
            int[] count = new int[inputNumbers.Count];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 1;
            }
            for (int i = 1; i < inputNumbers.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (inputNumbers[i] == inputNumbers[j])
                    {
                        count[i]++;
                    }
                }
            }

            return count;
        }
    }
}
