﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double sum = CalculateTriangleArea(width, height);
            Console.WriteLine(sum);
        }

        private static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
