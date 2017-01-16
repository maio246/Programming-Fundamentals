using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                         .Split(' ')
                         .Select(double.Parse)
                         .ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} => {1}", array[i], Math.Round(array[i], 0, MidpointRounding.AwayFromZero));
            }

        }
    }
}