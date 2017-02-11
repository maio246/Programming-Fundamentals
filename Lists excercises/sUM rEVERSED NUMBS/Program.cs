using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sUM_rEVERSED_NUMBS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                string numb = number[i];

                List<char> numberReversed = numb.Reverse().ToList();

                string reversedNumbString = string.Join("", numberReversed);

                int parsedNumb = int.Parse(reversedNumbString);

                sum += parsedNumb;
            }
            Console.WriteLine(sum);
        }
    }
}
