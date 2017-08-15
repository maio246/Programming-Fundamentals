using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Worm_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Dictionary<string, Dictionary<string, long>>();
            var teamScores = new Dictionary<string, decimal>();
            var currentWorm = Console.ReadLine();

            while (currentWorm != "quit")
            {
                var tokens = currentWorm
                    .Split(new char[] { '-', '>' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var wormName = tokens[0];
                var teamName = tokens[1];
                var wormScore = long.Parse(tokens[2]);

                if (!results.ContainsKey(teamName))
                {
                    results.Add(teamName, new Dictionary<string, long>());
                }
                if (!results.Any(x => x.Value.ContainsKey(wormName)))
                {
                    results[teamName].Add(wormName, wormScore);
                }

                currentWorm = Console.ReadLine();
            }

            results = results
               .OrderByDescending(x => x.Value.Sum(y => y.Value))
               .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count())
               .ToDictionary(x => x.Key, x => x.Value);

            var counter = 1;

            foreach (var team in results)
            {
                Console.WriteLine($"{counter}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }

                counter++;
            }
        }
    }
}
