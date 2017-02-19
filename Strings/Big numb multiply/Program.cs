using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_numb_multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine().Trim(new[] { '0' });
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier != 0)
            {

                var result = new List<int>();

                var numbToAdd = 0;

                for (int i = 0; i < numberString.Length; i++)
                {
                    var currentDigit = int.Parse(numberString[numberString.Length - i - 1].ToString());

                    var sum = currentDigit * multiplier + numbToAdd;

                    if (sum > 9) numbToAdd = sum / 10;
                    else numbToAdd = 0;
                    var remainder = sum % 10;

                    result.Add(remainder);

                }
                if (numbToAdd != 0)
                {
                    result.Add(numbToAdd);
                }

                result.Reverse();

                Console.WriteLine(string.Join("", result));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}