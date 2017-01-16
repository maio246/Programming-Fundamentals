using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(number);
            Console.WriteLine(lastDigit);
        }

        static string GetLastDigit(long number)
        {
              long getLastDigit = Math.Abs(number % 10);
            string lastDigitString = "";
            switch (getLastDigit)
            {
                case 0:
                    lastDigitString = "zero";
                    break;

                case 1:
                    lastDigitString = "one";
                    break;
                case 2:
                    lastDigitString = "two";
                    break;
                case 3:
                    lastDigitString = "three";
                    break;
                case 4:
                    lastDigitString = "four";
                    break;
                case 5:
                    lastDigitString = "five";
                    break;
                case 6:
                    lastDigitString = "six";
                    break;
                case 7:
                    lastDigitString = "seven";
                    break;
                case 8:
                    lastDigitString = "eight";
                    break;
                case 9:
                    lastDigitString = "nine";
                    break;
                default:

                    break;
            }
            return lastDigitString;
        }
    }
}
