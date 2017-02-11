   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
