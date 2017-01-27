using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int third
            var result = GetMax(firstInput, secondInput);
            Console.WriteLine(result);
        }

        private static object GetMax(int firstInput, int secondInput)
        {
            if (firstInput.CompareTo(secondInput) >= 0)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
