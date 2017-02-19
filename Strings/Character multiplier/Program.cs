using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();
            Console.WriteLine(GetCharSum(strings));
        }

        private static int GetCharSum(string[] strings)
        {
            var firstString = strings[0].ToCharArray();
            var secondString = strings[1].ToCharArray();
            var result = 0;

            var shortestString = Math.Min(firstString.Length, secondString.Length);
            var longestString = Math.Max(firstString.Length, secondString.Length);

            if (strings[0].Length == strings[1].Length)
            {
                for (int i = 0; i < strings[0].Length; i++)
                {
                    result += firstString[i] * secondString[i];
                }
            }
            else
            {
                var counter = 0;

                for (int i = 0; i < shortestString; i++)
                {
                    result += firstString[i] * secondString[i];
                    counter++;
                }
                if (firstString.Length > secondString.Length)
                {
                    for (int i = counter; i < longestString; i++)
                    {
                        result += firstString[i];
                    }
                }
                else
                {
                    for (int i = counter; i < longestString; i++)
                    {
                        result += secondString[i];
                    }

                }
            }
            return result;
        }
    }
}
