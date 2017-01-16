using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSquare(n);
        }

        private static void PrintSquare(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', 2 * n));

        }
    }
}
