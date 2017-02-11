using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Intersection
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool IsIntercepting(Circle firstCircle, Circle secondCircle)
        {
            int d = Point.CalculateDistance(firstCircle.Center, secondCircle.Center);

            if (d <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            else  return false;
        }
    }
}
