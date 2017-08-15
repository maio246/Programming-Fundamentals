using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentenceRegex = new Regex(@"(?:^[A-Z]+).+?(?:\.)"); //  ^[A-Z][^\.]*\.$
            var wordRegex = new Regex(@"[\w]+"); //[^\s,\.]+
            var input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                if (sentenceRegex.Matches(input).Count == 1)
                {
                    var matches = wordRegex.Matches(input);
                    var counter = 0;
                    var letter = 'a';
                    
                    foreach (Match match in matches)
                    {
                        var tempCount = 0;
                        var matchToArray = Regex.Matches(match, @"\w");
                        var newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
