using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedNumbs
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = GetReversedNumbs(number);
            Console.WriteLine(result);
        }

        static string GetReversedNumbs(string number)
        {
            string reversedNumbs = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumbs += number[i];
            }
            return reversedNumbs;
        }
    }
}
