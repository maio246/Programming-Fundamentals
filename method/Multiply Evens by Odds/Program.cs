using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            if (inputNumbers < 0)
            {
                inputNumbers = Math.Abs(inputNumbers);
            }
            int result = SumEvenOddNumbs(inputNumbers);

            Console.WriteLine(result);
        }

        private static int SumEvenOddNumbs(int inputNumbers )
        {
            int evenNumbs = GetEvenNumbsFromInput(inputNumbers);
            int oddNumbs = GetOddNumbsFromInput(inputNumbers);

            return evenNumbs * oddNumbs;
        }

        private static int GetOddNumbsFromInput(int inputNumbers)
        {
            string numbers = inputNumbers.ToString();
            int temp = 0;
            int currentDigit = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentDigit = int.Parse(numbers[i].ToString());
                if (currentDigit % 2 != 0)
                {
                    temp += currentDigit; 
                }
            }
            return temp;

        }

        private static int GetEvenNumbsFromInput(int inputNumbers)
        {
            string numbers = inputNumbers.ToString();
            int temp = 0;
            int currentDigit = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentDigit = int.Parse(numbers[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    temp += currentDigit;
                }
            }
            return temp;
        }
    }
}
