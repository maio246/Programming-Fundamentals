using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }
            int timesZero = 0;
            for (int power5 = 5; power5 <= input; power5 *= 5) // trailing zeros
            {
                timesZero += input / power5;
            }
            Console.WriteLine(factorial);

        }
    }
}
