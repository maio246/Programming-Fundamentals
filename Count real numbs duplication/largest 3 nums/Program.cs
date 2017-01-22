using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_3_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            numbers.OrderBy(x => x)
                .Take(3);
                Console.WriteLine(string.Join(", ", numbers.OrderByDescending(x => x)
                .Take(3)));

        }
    }
}
