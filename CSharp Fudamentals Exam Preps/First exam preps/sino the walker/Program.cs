using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sino_the_walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine()) % 86400;
            var stepPerSecond = int.Parse(Console.ReadLine()) % 86400;

            var totalTimeToWalk = steps * stepPerSecond;
            var totalTime = TimeSpan.FromSeconds(totalTimeToWalk);

            var result = leaveTime.Add(totalTime);
            Console.WriteLine("Time Arrival: " + result.ToString(@"HH:mm:sss"));
        }
    }
}
