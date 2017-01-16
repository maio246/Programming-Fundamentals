using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_exercisees
{
    class weekdays
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day > 0 && day <= 7)
            {
                Console.WriteLine(week[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
