using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] notPrime = new bool[total];
            notPrime[0] = true;
            notPrime[1] = true;
            for (int i = 2; i <= Math.Sqrt(notPrime.Length); i++)
            {
                if (!notPrime[i])
                {
                    for (int j = i * 2; j < notPrime.Length; j += i)
                    {
                        notPrime[j] = true;
                    }
                }
            }
        }

    }
}
