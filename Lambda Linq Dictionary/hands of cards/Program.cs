using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hands_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(':').ToArray();

            var powers = GetCardPowers();
            var multipliers = GetCardMultipliers();

            var results = new Dictionary<string, HashSet<int>>();

            while (input[0] != "JOKER")
            {
                var name = input[0];
                var cards = input[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in cards)
                {
                    var cardPower = item.Substring(0, item.Length - 1);
                    var cardMultiplier = item.Substring(item.Length - 1);
                    var cardSum = powers[cardPower] * multipliers[cardMultiplier];

                    if (!results.ContainsKey(name))
                    {
                        results[name] = new HashSet<int>();
                    }

                    results[name].Add(cardSum);
                }
                input = Console.ReadLine().Split(':').ToArray();
            }

            foreach (var cards in results)
            {
                var name = cards.Key;
                var playerCardSum = cards.Value.Sum();

                Console.WriteLine($"{name}: {playerCardSum}");
            }
        }

        private static Dictionary<string, int> GetCardMultipliers()
        {
            var multipliers = new Dictionary<string, int>();
            multipliers["S"] = 4;
            multipliers["H"] = 3;
            multipliers["D"] = 2;
            multipliers["C"] = 1;

            return multipliers;
        }

        private static Dictionary<string, int> GetCardPowers()
        {
            var cardPowers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            return cardPowers;
        }
    }
}
