using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Distance_between_points
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstPointInput = Console.ReadLine().Split();
            var secondPointInput = Console.ReadLine().Split();

            Point firstPoint = new Point()
            {
                X = int.Parse(firstPointInput[0]),
                Y = int.Parse(firstPointInput[1])
            };

            Point secondPoint = new Point()
            {
                X = int.Parse(secondPointInput[0]),
                Y = int.Parse(secondPointInput[1])
            };

            var sum = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{sum:f3}");
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;

            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return sideC;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
