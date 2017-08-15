using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.fourth_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, Dictionary<string, long>>();

            var legionsInfo = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                var legionInfo = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = long.Parse(legionInfo[0]);
                var legionName = legionInfo[1];
                var soldierType = legionInfo[2];
                var soldierCount = long.Parse(legionInfo[3]);

                if (!legionsInfo.ContainsKey(legionName))
                {
                    result.Add(legionName, new Dictionary<string, long>());
                    legionsInfo.Add(legionName, lastActivity);
                }
                if (legionsInfo[legionName] < lastActivity)
                {
                    legionsInfo[legionName] = lastActivity;
                }

                if (!result[legionName].ContainsKey(soldierType))
                {
                    result[legionName].Add(soldierType, 0);
                }
                    result[legionName][soldierType] += soldierCount;

            }


            var input = Console.ReadLine().Split('\\');

            if (input.Length > 1)
            {
                var soldsType = input[1];
                var activity = long.Parse(input[0]);

                foreach (var legion in result
                    .Where(legion => legion.Value.ContainsKey(soldsType))
                    .OrderByDescending(legion => legion.Value[soldsType]))
                {
                    var legionName = legion.Key;
                    var legionActivity = legionsInfo[legionName];

                    if (legionActivity < activity)
                    {
                        Console.WriteLine($"{legionName} -> {result[legionName][soldsType]}");
                    }
                }
            }
            else
            {
                var soldsType = input[0];

                foreach (var legion in legionsInfo.OrderByDescending(x => x.Value))
                {
                    var legionName = legion.Key;
                    var legionActivity = legion.Value;
                    if (result[legionName].ContainsKey(soldsType))
                    {
                        Console.WriteLine($"{legionActivity} : {legionName}");
                    }
                }

            }
        }
    }
}


