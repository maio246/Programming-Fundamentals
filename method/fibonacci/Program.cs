using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static long Fib(long n)
        {
            long a = 0;
            long b = 1;

            for (int i = 0; i <= n; i++)
            {

                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long fb = Fib(n);
            Console.WriteLine(fb);
        }
    }
}
