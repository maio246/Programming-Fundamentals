using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").Split().Select(w => w.ToLower()).ToArray();

            var text = File.ReadAllText("text.txt")
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).Select( w => w.ToLower()).ToArray();

            var result = new Dictionary<string, int>();

            var wordCounter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                wordCounter = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == words[i])
                    {
                        wordCounter++;
                    }
                }
                result.Add(words[i], wordCounter);
            }

            var sortedResult = result.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select( x => $"{x.Key} - {x.Value}").ToArray();
            File.AppendAllLines("result.txt", sortedResult);
        }
    }
}
