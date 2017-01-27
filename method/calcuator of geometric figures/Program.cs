using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcuator_of_geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "triangle")
            {
                Console.WriteLine("{0:f2}", GetTriangleArea());
            }
            else if (figure == "square")
            {
                Console.WriteLine("{0:f2}", GetSquareArea());
            }
            else if (figure == "rectangle")
            {
                Console.WriteLine("{0:f2}", GetRectangleArea());
            }
            else if (figure == "circle")
            {
                Console.WriteLine("{0:f2}", GetCircleArea());
            }
        }

        private static double GetCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            return Math.PI * Math.Pow(radius, 2);
        }

        private static object GetRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return width * height;
        }

        private static double GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            return Math.Pow(side, 2);
        }

        private static double GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return (side * height) / 2;
         
        }

    }
}
