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
            string result = CloserPointToCenter(x1, y1, x2, y2);
            Console.WriteLine(result);
        }

        static string CloserPointToCenter(double x1, double y1, double x2, double y2)
        {
            var firstPointDistance = Math.Abs(Math.Sqrt(Math.Pow(x1 + 0.0, 2) + Math.Pow(y1 + 0.0, 2)));
            var secondPointDistance = Math.Abs(Math.Sqrt(Math.Pow(x2 + 0.0, 2) + Math.Pow(y2 + 0.0, 2)));

            if (firstPointDistance < secondPointDistance)
            {
                return $"({x1}, {y1})";
            }
            else if (secondPointDistance < firstPointDistance)
            {
                return $"({x2}, {y2})";
            }
            else
            {
                return $"({x1}, {y1})";
            }
        }

    }
}
