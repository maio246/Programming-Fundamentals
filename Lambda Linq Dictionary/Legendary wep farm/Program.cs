using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_wep_farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory["motes"] = 0;
            inventory["shards"] = 0;
            inventory["fragments"] = 0;

            bool hasLegendary = false;
            string legendary = "";

            while (hasLegendary == false)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 1; i < input.Length; i += 2)
                {
                    var material = input[i];
                    var quantity = int.Parse(input[i - 1]);

                    if (!inventory.ContainsKey(material))
                    {
                        inventory.Add(material, 0);
                    }
                    inventory[material] += quantity;

                    if (inventory[material] >= 250)
                    {
                        inventory[material] -= 250;
                        legendary = material;
                        hasLegendary = true;
                        break;
                    }
                }
            }
            ObtainedLegendaryPrint(legendary);
            PrintKeyMats(inventory);
            PrintJunk(inventory);
        }

        private static void PrintJunk(Dictionary<string, int> inventory)
        {
            var junk = inventory.Skip(3).OrderBy(x => x.Key);
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void PrintKeyMats(Dictionary<string, int> inventory)
        {
            var keyMats = inventory.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            foreach (var item in keyMats)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void ObtainedLegendaryPrint(string legendary)
        {
            if (legendary == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legendary == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (legendary == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
        }

        private static void GetCounts(ref int moteCounter, ref int shardCounter, ref int fragmentCounter, string material, int quantity)
        {
            if (material == "motes")
            {
                moteCounter += quantity;
            }
            else if (material == "shards")
            {
                shardCounter += quantity;
            }
            else if (material == "fragments")
            {
                fragmentCounter += quantity;
            }
        }
    }
}

