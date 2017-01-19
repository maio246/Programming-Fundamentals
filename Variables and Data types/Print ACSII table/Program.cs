using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_ACSII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());

            for (int i = firstNumb; i <= secondNumb; i++)
            {
                Console.WriteLine($"{(char)i}");
            }
        }
    }
}
