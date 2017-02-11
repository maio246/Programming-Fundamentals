using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int phrasesNumbers = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var random = new Random();
            for (int i = 0; i < phrasesNumbers; i++)
            {
                var phrasesRandom = random.Next(0, phrases.Length);
                var eventsRandom = random.Next(0, events.Length);
                var authorRandom = random.Next(0, author.Length);
                var citiesRandom = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrasesRandom]}{events[eventsRandom]}{author[authorRandom]}{cities[citiesRandom]}");
            }
        }
    }
}
