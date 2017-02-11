using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbs = new List<int>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (Math.Sqrt(inputNumbers[i]) == (int)Math.Sqrt(inputNumbers[i]))
                {
                    squareNumbs.Add(inputNumbers[i]);
                }
            }
            squareNumbs.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbs));
        }
    }
}
