using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace valid_username
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(new []{'/', '\\', '(', ')', ' '},StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\b[a-zA-Z][\w_]{2,25}\b");

            var matches = new List<string>();

            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    matches.Add(username);
                }
            }
            var couples = new List<string>();

            var biggestSum = 0;

            for (int i = 1; i < matches.Count; i++)
            {
                var firstMatch = matches[i - 1];
                var secondMatch = matches[i];

                var currentSum = firstMatch.Length + secondMatch.Length;

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    couples.Clear();
                    couples.Add(firstMatch);
                    couples.Add(secondMatch);
                }
            }

            foreach (var username in couples)
            {
                Console.WriteLine(username);
            }
        }
    }
}
