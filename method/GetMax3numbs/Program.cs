using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax3numbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            var biggest = GetMax(num1, num2, num3);
            Console.WriteLine(biggest);
        }

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            else
            {
                return num1;
            }
        }
    }
}
