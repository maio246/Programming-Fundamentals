using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class hexToString
    {
        public static void Main()
        {
            string variableInHex = Console.ReadLine();
            int hexToNumb = Convert.ToInt32(variableInHex, 16);

            Console.WriteLine(hexToNumb);

        }
    }
}
