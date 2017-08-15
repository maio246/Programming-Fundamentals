using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace default_values
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var key = tokens[0];
                var value = tokens[1];

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, String.Empty);
                }

                dict[key] = value;

                line = Console.ReadLine();
            }

            var replacer = Console.ReadLine();

            foreach (var kvp in dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            foreach (var kvp in dict.Where(x => x.Value == "null"))
            {
                 Console.WriteLine($"{kvp.Key} <-> {replacer}");
            }
        }
    }
}
