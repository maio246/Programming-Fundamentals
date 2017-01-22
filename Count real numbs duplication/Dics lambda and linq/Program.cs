using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dics_lambda_and_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var numbers = new SortedDictionary<double, int>();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (numbers.ContainsKey(inputNumbers[i]))
                {
                    numbers[inputNumbers[i]]++ ;
                }
                else
                {
                    numbers[inputNumbers[i]] = 1;
                }   
            }
            foreach (var num in numbers.Keys)
            {
                Console.WriteLine($"{num} -> {numbers[num]}");
            }
        }
    }
}
