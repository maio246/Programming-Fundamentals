using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_occurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (string word in inputString)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }
            foreach (var word in words)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
