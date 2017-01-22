using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_occurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> result = new Dictionary<string, int>();
            var res = "";
            foreach (string word in inputString)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            foreach (var word in result)
            {
                 res = result.Count(n => n % 2 == 1);
            }
        }
    }
}
