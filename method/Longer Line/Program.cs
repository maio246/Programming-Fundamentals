using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace center_point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string result = CloserPointToCenter(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine(result);
        }

        static string CloserPointToCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            var center = 0.0;
            double firstPointDistance = Distance(x1, y1, center);
            var secondPointDistance = Distance(x2, y2, center);
            var thirdPointDistance = Distance(x3, y3, center);
            var fourthPointDistance = Distance(x4, y4, center);

            if (firstPointDistance + secondPointDistance > thirdPointDistance + fourthPointDistance)
            {
                return FirstPointCloser(x1, y1, x2, y2, firstPointDistance, secondPointDistance);
            }
            else if (firstPointDistance + secondPointDistance < thirdPointDistance + fourthPointDistance)
            {
                if (thirdPointDistance <= fourthPointDistance)
                {
                    return $"({x3}, {y3})({x4}, {y4})";
                }
                else
                {
                    return $"({x4}, {y4})({x3}, {y3})";
                }
            }
            else
            {
                return FirstPointCloser(x1, y1, x2, y2, firstPointDistance, secondPointDistance);
            }
        }

        private static string FirstPointCloser(double x1, double y1, double x2, double y2, double firstPointDistance, double secondPointDistance)
        {
            if (firstPointDistance <= secondPointDistance)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
        }

        private static double Distance(double x, double y, double center)
        {
            return Math.Sqrt(Math.Pow(x + center, 2) + Math.Pow(y + center, 2));
        }
    }

}


