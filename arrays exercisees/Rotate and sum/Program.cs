using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());
            int[] tempRotation = new int[numbs.Length];
            int[] previousRotation = new int[numbs.Length];
            int[] result = new int[numbs.Length];


            for (int i = 1; i <= rotationTimes; i++)
            {
                for (int j = 0; j <= numbs.Length - 1; j++)
                {
                    tempRotation[j] = numbs[numbs.Length - i];
                    result[j] += tempRotation[j]; 
                }
               
            }
            //for (int i = 0; i < rotationTimes; i++)
             //{
            //    for (int j = 1; j <= numbs.Length; j++)
            //    {
            //        result[i] = numbs[]
            //    }
            //}
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
