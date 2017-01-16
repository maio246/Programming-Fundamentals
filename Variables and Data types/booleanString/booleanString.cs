using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanString
{
    public class booleanString
    {
        public static void Main(string[] args)
        {

            string toBoolean = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(toBoolean);

            if (isTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
