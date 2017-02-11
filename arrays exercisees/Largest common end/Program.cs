using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_common_end
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split();
            string[] secondString = Console.ReadLine().Split();

            int shorterStringLeft = Math.Min(firstString.Length, secondString.Length);

            int resultLeft = 0;
            int resultRight = 0;
            resultLeft = GetLeftCommonEnd(firstString, secondString, shorterStringLeft, resultLeft);
            Array.Reverse(firstString);
            Array.Reverse(secondString);
            resultRight = GetRightCommonEnd(firstString, secondString, shorterStringLeft, resultRight);

            Console.WriteLine(Math.Max(resultRight, resultLeft));
        }

        private static int GetRightCommonEnd(string[] firstString, string[] secondString, int shorterStringLeft, int resultRight)
        {
            for (int i = 0; i < shorterStringLeft; i++)
            {
                if (firstString[i] == secondString[i])
                {
                    resultRight++;
                }
                else
                {
                    break;
                }
            }

            return resultRight;
        }

        private static int GetLeftCommonEnd(string[] firstString, string[] secondString, int shorterStringLeft, int resultLeft)
        {
            for (int i = 0; i < shorterStringLeft; i++)
            {
                if (firstString[i] == secondString[i])
                {
                    resultLeft++;
                }
                else
                {
                    break;
                }
            }

            return resultLeft;
        }
    }
}
