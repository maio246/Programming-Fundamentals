using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string formulaSearch = Console.ReadLine().ToLower();
            double result = 0;
            if (formulaSearch == "face")
            {
                result = GetFaceDiagonals(n);
            }
            else if (formulaSearch == "space")
            {
                result = GetSpaceDiagonals(n);
            }
            else if (formulaSearch == "area")
            {
                result = GetArea(n);
            }
            else if (formulaSearch == "volume")
            {
                result = GetVolume(n);
            }

            Console.WriteLine("{0:f2}", result);
        }

        private static double GetVolume(double n)
        {
            return Math.Pow(n, 3);
        }

        private static double GetArea(double n)
        {
            return Math.Pow(n, 2) * 6;
        }

        private static double GetSpaceDiagonals(double n)
        {
            return Math.Sqrt(Math.Pow(n, 2) * 3);
        }

        private static double GetFaceDiagonals(double n)
        {
            return Math.Sqrt(Math.Pow(n, 2) * 2);
        }

    }
}
