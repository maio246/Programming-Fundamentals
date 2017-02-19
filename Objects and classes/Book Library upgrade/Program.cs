using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Book_Library_upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, DateTime>();
            var allBooks = new Dictionary<string, DateTime>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                var title = input[0];
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (allBooks.ContainsKey(title))
                {
                    allBooks[title] = date;
                }
                else
                {
                    allBooks.Add(title, date);
                }
            }
            DateTime afterThatDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in allBooks)
            {
                if (book.Value > afterThatDate)
                {
                        result.Add(book.Key, book.Value);
                }
            }

            foreach (var book in result.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
            }
        }
    }
}

