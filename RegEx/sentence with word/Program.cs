using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sentence_with_word
{
    class Program
    {
        static void Main()
        {
            var wordToMatch = Console.ReadLine();
            var text = Console.ReadLine().Split(new []{'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            //var regex = new Regex($@"[\w-,]+[\w-\s,]+{wordToMatch}\s[\w-\s,]+");
            var regex = new Regex("\\b" + wordToMatch + "\\b");
            

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
