using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int timesToRotate = int.Parse(Console.ReadLine());

            string[] allRotations = new string[timesToRotate];

            for (int i = 0; i < timesToRotate; i++)
            {
                int numberHolder = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = numberHolder;

                allRotations[i] = string.Join("", numbers);
            }

            int[] result = new int[numbers.Length];

            for (int i = 0; i < allRotations.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] += int.Parse(allRotations[i][j].ToString());
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
