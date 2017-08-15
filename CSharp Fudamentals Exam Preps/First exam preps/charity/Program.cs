using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var trackLength = double.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var maximumRunners = trackCapacity * marathonDays;
            if (runners >= maximumRunners)
            {
                runners = maximumRunners;
            }

            var totalMeters = trackLength * averageLaps * runners;

            var totalKilometers = totalMeters / 1000;

            var moneyRaised = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");        
        }
    }
}
