using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace closest_two_points
{
    class Program
    {
        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var pointAsString = Console.ReadLine().Split().Select(double.Parse).ToArray();

                var tempPoint = (new Point
                {
                    X = pointAsString[0],
                    Y = pointAsString[1]
                });

                points.Add(tempPoint);
            }
            var minDistance = double.MaxValue;
            Point firstPoint = null;
            Point secondPoint = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = GetClosestPoint(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPoint = points[i];
                        secondPoint = points[j];
                    }
                }
            }
            Console.WriteLine($"{minDistance}");
            Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
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
