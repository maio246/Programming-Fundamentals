using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nether_realm
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ',', ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var demonsStats = new Dictionary<string, Dictionary<int, double>>();

            var matchDamage = new Regex(@"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)");

            var matchHealth = new Regex(@"[^0-9\.\+\-*\/]");

            var matchMath = new Regex(@"[\*\/]");
            var matchMultiply = new Regex(@"[\*]");
            var matchDivide = new Regex(@"[\/]");

            foreach (var demon in demons)
            {
                var currentDemon = demon;

                var currentDemonStats = new Dictionary<int, double>();

                var damageMatches = matchDamage.Matches(demon);
                var healthMatches = matchHealth.Matches(demon);
                var dmgMathMatch = matchMath.Matches(currentDemon);

                var demonDmg = 0.0;
                var demonHealth = 0;

                foreach (Match match in damageMatches)
                {
                    demonDmg += (double.Parse(match.Value));
                }

                foreach (Match match in healthMatches)
                {
                    foreach (char letter in match.ToString())
                    {
                        demonHealth += (int)letter;

                    }
                }

                foreach (Match match in dmgMathMatch)
                {
                    if (matchMultiply.IsMatch(match.Value))
                    {
                        demonDmg *= 2;
                    }
                    if (matchDivide.IsMatch(match.Value))
                    {
                        demonDmg /= 2;
                    }

                }

                currentDemonStats.Add(demonHealth, demonDmg);
                demonsStats.Add(currentDemon, currentDemonStats);
            }
            var result = demonsStats.OrderBy(x => x.Key);

            foreach (var demonsStat in result)
            {
                Console.Write($"{demonsStat.Key} - ");
                foreach (var stat in demonsStat.Value)
                {
                    Console.Write($"{stat.Key} health, {stat.Value:F2} damage");
                }
                Console.WriteLine();
            }
        }
    }
}
