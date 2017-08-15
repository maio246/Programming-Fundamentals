using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var counter = 0;
            for (int position = 0; position < field.Length; position++)
            {

                if (field[position] != 0)
                {
                    var index = 0;

                    index = field[position];
                    field[position] = 0;
                    position = index;

                }

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
