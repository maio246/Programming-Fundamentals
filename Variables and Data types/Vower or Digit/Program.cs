using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vower_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool vowelResult = IsVowel(input);
            bool digitResult = IsDigit(input);
            if (vowelResult)
            {
                Console.WriteLine("vowel");
            }
            else if (digitResult)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }

        private static bool IsDigit(char input)
        {
            return new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }.Contains(input);
        }

        private static bool IsVowel(char input)
        {
            return new[]  { 'a', 'e', 'i', 'o', 'u'}.Contains(input);
             
        }
    }
}
