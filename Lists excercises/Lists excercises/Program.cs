using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbs = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            GetPositiveNumbsAndReverse(inputNumbs, result);

            PrintResult(result);
        }

        private static void PrintResult(List<int> result)
        {
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (int number in result)
                {
                    Console.Write(number + " ");
                }
            }
        }

        private static void GetPositiveNumbsAndReverse(List<int> inputNumbs, List<int> result)
        {
            for (int i = inputNumbs.Count - 1; i >= 0; i--)
            {
                if (inputNumbs[i] > 0)
                {
                    result.Add(inputNumbs[i]);
                }
            }
        }
    }
}
