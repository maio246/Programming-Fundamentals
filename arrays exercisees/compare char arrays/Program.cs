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
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int smallerArray = Math.Min(firstArray.Length, secondArray.Length);

            BiggerCharRow(firstArray, secondArray, smallerArray);
        }

        private static void BiggerCharRow(char[] firstArray, char[] secondArray, int smallerArray)
        {
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < smallerArray; i++)
                {

                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                }
            }
        }
    }
}

