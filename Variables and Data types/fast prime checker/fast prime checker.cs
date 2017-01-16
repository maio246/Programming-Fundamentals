using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuries_to_nanosecs
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isTrue = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isTrue}");
            }

        }
    }
}
