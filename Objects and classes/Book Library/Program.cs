using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfBooks = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, double>();

            for (int i = 0; i < numbersOfBooks; i++)
            {
                var currentBookInput = Console.ReadLine().Split().ToArray();
                var author = currentBookInput[1];
                var price = double.Parse(currentBookInput[currentBookInput.Length - 1]);

                if (result.ContainsKey(author))
                {
                    result[author] += price;
                }
                else
                {
                    result.Add(author, price);
                }
            }

            var resultToPrint = result.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var author in resultToPrint)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
