using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();

            var stringToSub = Console.ReadLine().ToLower();
            
            var index = 0;
            var count = 0;
            while (true)
            {
                var found = text.IndexOf(stringToSub, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;

                }
            }
            Console.WriteLine(count);
        }
    }
}
