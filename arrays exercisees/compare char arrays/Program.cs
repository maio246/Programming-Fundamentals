using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArray = Math.Min(firstArray.Length, secondArray.Length);
            for (int i = 0; i < smallerArray; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.Write(string.Join("", firstArray));
                    Console.Write(string.Join("", secondArray));

                }
                else
                {
                    Console.Write(string.Join("", secondArray));
                    Console.Write(string.Join("", firstArray));
                }
            }

        }
    }
}
}
