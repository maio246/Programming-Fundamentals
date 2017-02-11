using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstCenter = new Point(firstCircleInput[0], firstCircleInput[1]);
            Point secondCenter = new Point(secondCircleInput[0], secondCircleInput[1]);

            Circle firstCircle = new Circle(firstCenter, firstCircleInput[2]);
            Circle secondCircle = new Circle(secondCenter, secondCircleInput[2]);

            if (Circle.IsIntercepting(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
