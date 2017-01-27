using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    public class Program
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
            var firstPointDistance = Math.Sqrt(Math.Pow(x1 + y1, 2) + Math.Pow(x2 + y2, 2));
            var secondPointDistance = Math.Sqrt(Math.Pow(x3 + y3, 2) + Math.Pow(x4 + y4, 2));

            if (firstPointDistance < secondPointDistance)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else if (secondPointDistance < firstPointDistance)
            {
                return $"({x3}, {y3})({x4}, {y4})";
            }
            else
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
        }

    }
}
