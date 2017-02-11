using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split('|', ' ').ToList();
            nums.Reverse();
            var result = new List<string>();

            foreach (string word in nums)
            {
                List<string> tempList = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(tempList);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
