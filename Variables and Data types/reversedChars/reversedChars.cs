using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedChars
{
    public class reversedChars
    {
        public static void Main(string[] args)
        {
            char firstchar = char.Parse(Console.ReadLine());
            char secondchar = char.Parse(Console.ReadLine());
            char thirdchar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdchar}{secondchar}{firstchar}");
        }
    }
}
