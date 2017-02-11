using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthene
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRange = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[inputRange + 1];

            MarkAllNumbsAsPrime(inputRange, isPrime);
            isPrime[0] = false;
            isPrime[1] = false;

            SieveOfEratostheneAndPrint(inputRange, isPrime);
            Console.WriteLine();
        }

        private static void SieveOfEratostheneAndPrint(int inputRange, bool[] isPrime)
        {
            for (int i = 0; i <= inputRange; i++)
            {
                if (isPrime[i])
                {
                    Console.Write($"{i} ");
                    for (int j = i * 2; j <= inputRange; j += i)
                    {
                        isPrime[j] = false;
                    }
                    for (int j = i * 3; j <= inputRange; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }

        private static void MarkAllNumbsAsPrime(int inputRange, bool[] isPrime)
        {
            for (int i = 0; i <= inputRange; i++) isPrime[i] = true;
        }
    }
}
