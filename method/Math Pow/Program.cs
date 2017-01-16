using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumb = double.Parse(Console.ReadLine());
            decimal sum = (decimal)NumberPower(number, powerNumb);
            Console.WriteLine(sum);
            if (number == 0)
            {
                Console.WriteLine("Invalid");
            }
        }

        static double NumberPower(double number, double powerNumb)
        {
            return Math.Pow(number, powerNumb);
        }
    }
}
