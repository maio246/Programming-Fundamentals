using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            GetAlphabetCharArray(alphabet);

            string inputCharArray = Console.ReadLine().ToLower();

            GetCharIndexAndPrint(alphabet, inputCharArray);
        }

        private static void GetCharIndexAndPrint(char[] alphabet, string inputCharArray)
        {
            foreach (char letter in inputCharArray)
            {

                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == (alphabet[i]))
                    {
                        Console.WriteLine($"{letter} -> {i}");
                    }
                }
            }
        }

        private static void GetAlphabetCharArray(char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
        }
    }
}
