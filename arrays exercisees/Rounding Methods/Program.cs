using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbs = Console.ReadLine().Split();
            double[] numbsDoubleArray = new Double[numbs.Length];
            for (int i = 0; i <= numbs.Length - 1; i++)
            {
                numbsDoubleArray[i] = Convert.ToDouble(numbs[i]);
            }
            Array.Reverse(numbsDoubleArray);
            foreach (var item in numbsDoubleArray)
            {
                Console.Write(item + " ");
            }

        }
    }

}

