using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace converts_from_base_n_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var numberToConvert = BigInteger.Parse(input[1]);
            var baseN = int.Parse(input[0]);

            var bin = new BigInteger(0);

            var numToString = numberToConvert.ToString();
            for (int i = 0; i < numToString.Length; i++)
            {
                var currentDigit = int.Parse(numToString[numToString.Length - 1 - i].ToString());
                var result = currentDigit * BigInteger.Pow(baseN, i);
                bin += result;
            }
            Console.WriteLine(bin);
        }
    }
}

