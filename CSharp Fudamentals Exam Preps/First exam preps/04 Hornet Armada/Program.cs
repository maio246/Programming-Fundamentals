namespace _04_Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var legions = new Dictionary<string, Dictionary<string, long>>();
            var legionsId = new Dictionary<string, long>();

            var lines = long.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new char[] { '-', '>', ':', '=', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                AddLegionsToDicts(legions, legionsId, tokens);
            }

            var formatToPrint = Console.ReadLine().Split('\\');


            if (formatToPrint.Length > 1)
            {
                PrintByActivity(legions, legionsId, formatToPrint);
            }
            else
            {
                PrintBySoldierType(legions, legionsId, formatToPrint);
            }
        }

        public static void PrintByActivity(Dictionary<string, Dictionary<string, long>> legions, Dictionary<string, long> legionsId, string[] formatToPrint)
        {

            var lastActivity = long.Parse(formatToPrint[0]);
            var soldierType = formatToPrint[1];

            foreach (var legion in legions
                .Where(x => x.Value.ContainsKey(soldierType))
                .OrderByDescending(x => x.Value[soldierType]))
            {
                var legionName = legion.Key;
                var legionActivity = legionsId[legionName];

                if (legionActivity < lastActivity)
                {
                    Console.WriteLine($"{legionName} -> {legions[legionName][soldierType]}");
                }
            }
        }

        public static void PrintBySoldierType(Dictionary<string, Dictionary<string, long>> legions, Dictionary<string, long> legionsId, string[] formatToPrint)
        {
            var soldier = formatToPrint[0];

            foreach (var legion in legionsId
                .OrderByDescending(x => x.Value))
            {
                var legionName = legion.Key;
                var legionActivity = legion.Value;
                if (legions[legionName].ContainsKey(soldier))
                {
                    Console.WriteLine($"{legionActivity} : {legionName}");
                }
            }
        }

        public static void AddLegionsToDicts(Dictionary<string, Dictionary<string, long>> legions, Dictionary<string, long> legionsId, string[] tokens)
        {
            var lastActivity = long.Parse(tokens[0]);
            var legionName = tokens[1];
            var soldierType = tokens[2];
            var soldierCount = long.Parse(tokens[3]);

            if (!legionsId.ContainsKey(legionName))
            {
                legionsId.Add(legionName, lastActivity);

                legions.Add(legionName, new Dictionary<string, long>());
            }

            if (!legions[legionName].ContainsKey(soldierType))
            {
                legions[legionName].Add(soldierType, 0);
            }

            if (legionsId[legionName] < lastActivity)
            {
                legionsId[legionName] = lastActivity;
            }

            legions[legionName][soldierType] += soldierCount;

        }
    }
}
