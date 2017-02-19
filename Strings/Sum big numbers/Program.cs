using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumberString = Console.ReadLine().TrimStart(new char[] { '0' }).ToArray();
            var secondNumberString = Console.ReadLine().TrimStart(new char[] { '0' }).ToArray();

            var shortestStringNumber = Math.Min(firstNumberString.Length, secondNumberString.Length);
            var longestStringNumber = Math.Max(firstNumberString.Length, secondNumberString.Length);

            var numbToAdd = 0;
            var counter = 0;

            var result = new List<int>();

            SumShortestString(firstNumberString, secondNumberString, shortestStringNumber, ref numbToAdd, ref counter, result);

            numbToAdd = GetTailDigits(firstNumberString, secondNumberString, longestStringNumber, numbToAdd, counter, result);

            if (numbToAdd == 1)
            {
                result.Add(1);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }

        private static int GetTailDigits(char[] firstNumberString, char[] secondNumberString, int longestStringNumber, int numbToAdd, int counter, List<int> result)
        {
            for (int i = counter; i < longestStringNumber; i++)
            {
                if (firstNumberString.Length > secondNumberString.Length)
                {
                    var currentDigit = int.Parse(firstNumberString[firstNumberString.Length - 1- i].ToString());
                    var currentSum = currentDigit + numbToAdd;

                    if (currentSum >= 10)
                    {
                        result.Add(currentSum - 10);
                        numbToAdd = 1;
                    }
                    else
                    {
                        result.Add(currentSum);
                        numbToAdd = 0;
                    }
                }
                else if (secondNumberString.Length > firstNumberString.Length)
                {
                    var currentDigit = int.Parse(secondNumberString[secondNumberString.Length - 1 - i].ToString());
                    var currentSum = currentDigit + numbToAdd;

                    if (currentSum >= 10)
                    {
                        result.Add(currentSum - 10);
                        numbToAdd = 1;
                    }
                    else
                    {
                        result.Add(currentSum);
                        numbToAdd = 0;
                    }
                }
            }

            return numbToAdd;
        }

        private static void SumShortestString(char[] firstNumberString, char[] secondNumberString, int shortestStringNumber, ref int numbToAdd, ref int counter, List<int> result)
        {
            for (int i = 0; i < shortestStringNumber; i++)
            {
                var firstNumbDigit = int.Parse(firstNumberString[firstNumberString.Length - 1 - i].ToString());
                var secondNumDigit = int.Parse(secondNumberString[secondNumberString.Length - 1 - i].ToString());

                var currentSum = firstNumbDigit + secondNumDigit + numbToAdd;

                if (currentSum >= 10)
                {
                    result.Add(currentSum - 10);
                    numbToAdd = 1;
                }
                else
                {
                    result.Add(currentSum);
                    numbToAdd = 0;
                }
                counter++;
            }
        }
    }
}
