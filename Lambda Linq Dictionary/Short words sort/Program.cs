using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_words_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine().ToLower();
            string[] wordsAsString = words
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\'', '"', '\'', '\\', '/', '!', '?', ' '  }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .OrderBy(word => word)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", wordsAsString));
        }
    }
}
