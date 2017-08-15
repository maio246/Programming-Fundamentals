using System;
using System.Collections.Generic;
using System.Linq;

class WebSite
{
    public string Host { get; set; }

    public string Domain { get; set; }

    public List<string> Queries { get; set; }
}

namespace WebSites
{
    public class WebSites
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            var sites = new List<WebSite>();

            while (input != "end")
            {
                var tokens = input.Split(new[] {'|', ' '}, StringSplitOptions.RemoveEmptyEntries);

                var host = tokens[0];
                var domain = tokens[1];
                var queries = new List<string>();

                if (tokens.Length > 2)
                {
                    var squeries = tokens[2].Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    foreach (var query in squeries)
                    {
                        queries.Add("[" + query + "]");
                    }
                }

                var currSite = new WebSite()
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                sites.Add(currSite);

                input = Console.ReadLine();
            }

            foreach (var webSite in sites)
            {
                Console.Write($"https://www.{webSite.Host}.{webSite.Domain}");

                if (webSite.Queries.Count > 0)
                {
                    Console.Write($"/query?={string.Join("&", webSite.Queries)}");
                }
                Console.WriteLine();
            }
        }
    }
}
