using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] separator = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };

            List<string> inputText = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            ArrangeStringWordsToLists(inputText, lowerCase, mixedCase, upperCase);
            PrintResult(lowerCase, mixedCase, upperCase);
        }

        private static void PrintResult(List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));
        }

        private static void ArrangeStringWordsToLists(List<string> inputText, List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            foreach (string word in inputText)
            {
                if (word.All(c => char.IsUpper(c)))
                {
                    upperCase.Add(word);
                }
                else if (word.All(c => char.IsLower(c)))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
        }
    }
}
