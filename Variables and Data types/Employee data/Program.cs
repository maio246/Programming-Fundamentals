using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f' ;
            long personalID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}",employeeNumber);


        }

    }
}
