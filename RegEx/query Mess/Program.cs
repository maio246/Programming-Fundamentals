using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var bldsg = new List<string>();
            while (text != "END")
            {

                var regex = new Regex(@"([^&=?]*)=([^&=]*)");

                var matches = regex.Matches(text);

                var newRegx = @"((\+|%20)+)";

                var matchResult = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {


                    var matchValue = match.Groups[2].Value;
                    matchValue = Regex.Replace(matchValue, newRegx, word => " ").Trim();

                    var matchKey = match.Groups[1].Value;
                    matchKey = Regex.Replace(matchKey, newRegx, word => " ").Trim();

                    if (!matchResult.ContainsKey(matchKey))
                    {
                        var values = new List<string>();
                        values.Add(matchValue);
                        matchResult.Add(matchKey, values);
                    }
                    else
                    {
                        matchResult[matchKey].Add(matchValue);
                    }

                }
                foreach (var pair in matchResult)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }

                Console.WriteLine();

                text = Console.ReadLine();

            }
        }
    }
}
