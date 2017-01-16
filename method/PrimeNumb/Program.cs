using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool IsPrime = IsPrimeNumb(n);
            Console.WriteLine(IsPrime);
        }

        private static bool IsPrimeNumb(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                        
                    }
                }
            }
            return true;

        }
    }
}
