using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            var result = Convert.ToString(inputNumber, 16).ToUpper();
            var result1 = Convert.ToString(inputNumber, 2).ToUpper();
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
