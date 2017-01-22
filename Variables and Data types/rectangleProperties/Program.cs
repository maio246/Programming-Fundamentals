    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace rectangleProperties
    {
        class Program
        {
            static void Main(string[] args)
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = width * height;
                double perimeter = width * 2 + height * 2;
                double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

                Console.WriteLine(perimeter);
                Console.WriteLine(area);
                Console.WriteLine(diagonal);
            }
        }
    }
