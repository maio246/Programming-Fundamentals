using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var numberToConvert = BigInteger.Parse(input[1]);
            var baseN = BigInteger.Parse(input[0]);

            var bin = "";

            if (baseN >= 2 || baseN <= 10)
            {

                while (numberToConvert > 0)
                {
                    var currentnumber = numberToConvert % baseN;
                    numberToConvert /= baseN;
                    bin = currentnumber.ToString() + bin;

                }
                Console.WriteLine(bin);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
