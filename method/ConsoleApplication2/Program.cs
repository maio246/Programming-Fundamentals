using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCashReceipt();
        }

        private static void PrintCashReceipt()
        {
            Header();
            Body();
            Footer();
        }

        private static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        private static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
