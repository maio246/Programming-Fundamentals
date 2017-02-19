using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace email_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var regex = new Regex(@"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z]+)+");

            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                var matchToString = match.ToString();

                if (
                    !(matchToString.StartsWith("-") || matchToString.StartsWith(".") || matchToString.StartsWith("_")
                    || matchToString.EndsWith("-") || matchToString.EndsWith(".") || matchToString.EndsWith("_")))
                {
                    Console.WriteLine(matchToString);
                }
            }
        }
    }
}
