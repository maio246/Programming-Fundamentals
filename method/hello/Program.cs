using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greeting(name);
        }

        static void Greeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
