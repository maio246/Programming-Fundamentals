﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Line_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("result.txt", $"{i + 1}. {text[i]} {Environment.NewLine}");
            }
        }
    }
}
