using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.third_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var hives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ulong.Parse)
                .ToList();

            var currentHive = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ulong.Parse)
                   .ToList();

            var hivePower = 0ul;

            var soldiersLeft = new List<ulong>();

            for (int i = 0; i < hives.Count; i++)
            {
                var currentEnemy = hives[i];

                foreach (var soldier in currentHive)
                {
                    hivePower += soldier;
                }

                if (hivePower < currentEnemy)
                {
                    var soldiersLeftUnkilled = currentEnemy - hivePower;

                    soldiersLeft.Add(soldiersLeftUnkilled);

                    if (currentHive.Count > 1)
                    {
                        currentHive.RemoveAt(0);
                    }
                    else
                    {
                        hivePower = 0;
                        break;
                    }
                }
                else if (hivePower == currentEnemy)
                {
                    currentHive.RemoveAt(0);
                }
                hivePower = 0;
            }

            if (soldiersLeft.Count != 0)
            {
                Console.WriteLine(string.Join(" ", soldiersLeft));

            }
            else
            {
                Console.WriteLine(string.Join(" ", currentHive));
            }
        }
    }
}
