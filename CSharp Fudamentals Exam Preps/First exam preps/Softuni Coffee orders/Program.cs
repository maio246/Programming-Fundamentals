using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Softuni_Coffee_orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = int.Parse(Console.ReadLine());

            decimal totalCost = 0.0m;

            for (int i = 0; i < orders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());

                var month = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                var capsulesCount = long.Parse(Console.ReadLine());

                var monthDays = DateTime.DaysInMonth(month.Year, month.Month);

                var orderCost = ((monthDays * capsulesCount) * pricePerCapsule);

                totalCost += orderCost;

                Console.WriteLine($"The price for the coffee is: ${orderCost:f2}");
            }
            Console.WriteLine($"Total: ${totalCost:f2}");
        }
    }
}
