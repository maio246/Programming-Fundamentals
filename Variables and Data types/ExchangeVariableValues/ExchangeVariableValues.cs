using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            int firstNumb = 5;
            int secondNumb = 10;
            int tempNumb = firstNumb;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumb}");
            Console.WriteLine($"b = {secondNumb}");

            if (firstNumb < secondNumb)
            {
                firstNumb = secondNumb;
                secondNumb = tempNumb;
            }

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstNumb}");
            Console.WriteLine($"b = {secondNumb}");

        }
    }
}
