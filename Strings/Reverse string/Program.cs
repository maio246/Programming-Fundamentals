using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[input.Length - 1 - i]);
            }
            Console.WriteLine();
        }
    }
}
