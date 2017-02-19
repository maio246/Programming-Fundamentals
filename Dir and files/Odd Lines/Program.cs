using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Input.txt");

            
            for (int i = 1; i < lines.Length; i += 2)
            {
                File.AppendAllText("result.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}
