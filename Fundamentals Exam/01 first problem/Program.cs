using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_first_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceInMetersFor1k = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceInMetersFor1k;
            var flapSeconds = wingFlaps / 100;
            var rest = (wingFlaps / endurance) * 5;

            var totalSeconds = flapSeconds + rest;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalSeconds} s.");

        }
    }
}
