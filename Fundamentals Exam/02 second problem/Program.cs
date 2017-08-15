using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _02_second_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageRgx = new Regex(@"^(\d+) \<\-\> ([a-zA-Z0-9]+)$");
            var broadcastRgx = new Regex(@"^(\D+) \<\-\> ([a-zA-Z0-9]+)$");

            var messages = new List<string>();
            var broadCast = new List<string>();

            var inputMessage = Console.ReadLine();

            while (inputMessage != "Hornet is Green")
            {
                if (messageRgx.IsMatch(inputMessage))
                {
                    var match = messageRgx.Match(inputMessage);

                    var recipient = string.Join("", match.Groups[1].Value.Reverse());
                    var message = match.Groups[2].Value;

                    var result = string.Join(" -> ", recipient, message);

                    messages.Add(result);
                }
                if (broadcastRgx.IsMatch(inputMessage))
                {
                    var match = broadcastRgx.Match(inputMessage);

                    var frequency = ReverseFreq(match.Groups[2].Value);
                    var message = match.Groups[1].Value;
                    broadCast.Add(string.Join(" -> ", frequency, message));
                }
                inputMessage = Console.ReadLine();
            }


            Console.WriteLine("Broadcasts:");
            if (broadCast.Count == 0)
            {
                Console.WriteLine("None");

            }
            else
            {
                foreach (var message in broadCast)
                {
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
        }

        private static string ReverseFreq(string frequency)
        {
            var reversedFreq = "";

            foreach (char letter in frequency)
            {
                if (letter >= 65 && letter <= 90)
                {
                    reversedFreq += (char) (letter + 32);
                }
                else if (letter >= 97 && letter <= 122)
                {
                    reversedFreq += (char) (letter - 32);
                }
                else
                {
                    reversedFreq += letter;
                }
            }
            return reversedFreq;
        }
    }
}


