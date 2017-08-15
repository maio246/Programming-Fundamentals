using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endurance_rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split();

            var trackLayout = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var participant in participants)
            {

                double fuel = participant[0];

                for (int i = 0; i < trackLayout.Length; i++)
                {

                    if (checkpoints.Contains(i))
                    {
                        fuel += trackLayout[i];
                    }
                    else
                    {
                        fuel -= trackLayout[i];
                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{participant} - reached {i}");
                            break;
                        }
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{participant} - fuel left {fuel:f2}");
                }
            }
        }
    }
}

