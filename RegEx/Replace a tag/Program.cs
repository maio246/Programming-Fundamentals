using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "end")
            {

                var regex = new Regex(@"<a.*href.*?=(""|')(.*)\1>(.*)<\/a>");

                var result = regex
                    .Replace(text,
                        @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);

                text = Console.ReadLine();
            }
        }
    }
}