using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversed_ints
{
    class rever
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] listOfArrays = new int[n];

            FillArrayList(n, listOfArrays);

            ReverseAndPrintArray(n, listOfArrays);
        }

        private static void ReverseAndPrintArray(int n, int[] listOfArrays)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(listOfArrays[i] + " ");
            }
        }

        private static void FillArrayList(int n, int[] listOfArrays)
        {
            for (int i = 0; i < n; i++)
            {
                listOfArrays[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
