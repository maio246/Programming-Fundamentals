using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anials
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Parameter { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
}
