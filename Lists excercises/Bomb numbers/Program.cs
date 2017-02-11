using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumbs = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = 0;
            int bomb = bombNumbs[0];
            int power = bombNumbs[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, numbers.Count - 1);

                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            result = numbers.Sum();
            Console.WriteLine(string.Join("", result));
        }
    }
}
