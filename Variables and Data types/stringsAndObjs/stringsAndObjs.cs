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
            object result = sum();
            Console.WriteLine(result);
        }

        private static object sum()
        {
            object hello = "Hello";
            object world = "World";

            object sum = $"{hello} {world}";
            return sum;
        }
    }
}
