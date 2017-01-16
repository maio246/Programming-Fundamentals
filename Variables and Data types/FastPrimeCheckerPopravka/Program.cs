using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerPopravka
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int currentNum = 2; currentNum <= Math.Sqrt(i); currentNum++)
                {
                    
                    if (i % currentNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
