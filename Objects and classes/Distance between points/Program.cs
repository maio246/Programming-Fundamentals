using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_points
{            public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

    }

    class Program

    {
        static void Main(string[] args)
        {
            var firstPointInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point firstPoint = new Point()
            {
                X = firstPointInput[0],
                Y = firstPointInput[1]
            };

            var secondPointInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point secondPoint = new Point()
            {
                X = secondPointInput[0],
                Y = secondPointInput[1]
            };

            var result = GetClosestPoint(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }

        private static double GetClosestPoint(Point firstPoint, Point secondPoint)
        {
            var diffx = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var diffY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var diff = Math.Sqrt(diffx + diffY);

            return diff;
        }
    }
}
