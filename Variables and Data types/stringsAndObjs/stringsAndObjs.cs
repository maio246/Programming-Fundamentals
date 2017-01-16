using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndObjs
{
    public class stringsAndObjs
    {
        public static void Main(string[] args)
        {
            sum();
            string result = sum();
            Console.WriteLine(result);
        }

        private static string sum()
        {
            string hello = "Hello";
            string world = "World";

            string sum = $"{hello} {world}";
            return sum;
        }
    }
}
