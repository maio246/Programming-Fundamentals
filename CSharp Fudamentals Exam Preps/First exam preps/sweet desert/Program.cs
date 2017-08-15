using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sweet_desert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portions = guests / 6;
            if (guests % 6 != 0 )
            {
                portions++;
            }
            var moneyForSet = ( 2 * bananaPrice) + (4 * eggsPrice) + (berriesPrice * (decimal)0.2);

            var totalMoneyNeeded = moneyForSet * portions;

            var cashLeft = cash - totalMoneyNeeded;

            if (cashLeft >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(cashLeft):f2}lv more.");
            }
        }
    }
}
