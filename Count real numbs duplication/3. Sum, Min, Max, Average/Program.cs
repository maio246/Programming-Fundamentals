using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLength = int.Parse(Console.ReadLine());
            double[] inputNumbers = new double[inputLength];

            for (int i = 0; i < inputLength; i++)
            {
                inputNumbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {inputNumbers.Sum()}");
            Console.WriteLine($"Min = {inputNumbers.Min()}");
            Console.WriteLine($"Max = {inputNumbers.Max()}");
            Console.WriteLine($"Average = {inputNumbers.Average()}");

        }
    }
}
