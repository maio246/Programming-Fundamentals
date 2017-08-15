using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dayCounter = 0;

            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i] != i)
                {
                    plants[i] -= 1;
                }

                dayCounter++;

                if (dayCounter == plants.Length)
                {
                    i = 0;
                }
            }
            Console.WriteLine(dayCounter);
        }
    }
}
