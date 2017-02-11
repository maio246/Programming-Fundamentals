using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_positions
{
    class rectangle
    {
        public double Left { get; set; }

        public double Top { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Right
        {
            get
            {
                return Left + Width;
            }
        }

        public double Bottom => Top + Height;

        public static bool IsInside(rectangle firstRectangle,
 
            rectangle secondRectangle)
        {
            var leftIsCorrect = firstRectangle.Left >= secondRectangle.Left;
            var rightIsCorrect = firstRectangle.Right <= secondRectangle.Right;
            var topIsCorrect = firstRectangle.Top <= secondRectangle.Top;
            var bottomIsCorrect = firstRectangle.Bottom <= secondRectangle.Bottom;

            return leftIsCorrect && rightIsCorrect && topIsCorrect && bottomIsCorrect;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            rectangle firstRectangle = new rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };

            var secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            rectangle secondRectangle = new rectangle
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };

            if (rectangle.IsInside(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
