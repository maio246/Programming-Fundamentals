using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 7; i <= inputNumber; i++)
            {
                if (IsPalindrome(i) == true && SumOfDigits(i) == true && HoldsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HoldsEvenDigit(int i)
        {
            bool isHoldingEven = false;
            string number = i.ToString();
            int counter = 0;
            for (int j = 0; j <= number.Length - 1; j++)
            {
                int currentDigit = int.Parse(number[j].ToString());
                if (currentDigit % 2 == 0)
                {
                    counter++;
                }
                isHoldingEven = ((counter > 0) ? true : false);
            }
            return isHoldingEven;
        }

        private static bool SumOfDigits(int i)
        {
            string number = i.ToString();
            int sum = 0;

            for (int j = 0; j <= number.Length - 1; j++)
            {
                sum += int.Parse(number[j].ToString());
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalindrome(int i)
        {
            bool isPalindrome = false;
            string number = i.ToString();
            int counter = 0;

            for (int j = 0; j < number.Length / 2; j++)
            {
                if (number[j] == number[number.Length - 1 - j])
                {
                    counter++;
                }
                if (counter == number.Length / 2)
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
