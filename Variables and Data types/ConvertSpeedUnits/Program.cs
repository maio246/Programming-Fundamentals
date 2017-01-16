using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceMeters = double.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTime = hours * 3600 + minutes * 60 + seconds;
            float metersPerSecond = (float)(distanceMeters / totalTime);
            float kilometersPerHour = ((float)distanceMeters / 1000) / ((float)totalTime / 3600);
            float milesPerHour = ((float)(distanceMeters / 1609) / ((float)totalTime / 3600));

            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kilometersPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
