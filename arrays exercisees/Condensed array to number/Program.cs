using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condensed_array_to_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int arrayLength = nums.Length - 1;
            for (int i = 0; i < arrayLength; i++)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;

            }
            Console.WriteLine(nums[0]);

        }
    }
}
