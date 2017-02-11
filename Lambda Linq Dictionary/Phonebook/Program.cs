using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            List<string> input = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();

            bool hasListAll = false;

            while (input[0] != "END")
            {

                if (input[0] == "END") break;
                else if (input[0] == "A")
                    if (!phonebook.ContainsKey(input[1])) phonebook.Add(input[1], input[2]);
                    else phonebook[input[1]] = input[2];
                else if (input[0] == "S")
                    if (phonebook.ContainsKey(input[1]))
                        result.Add($"{input[1]} -> {phonebook[input[1]]}");
                    else result.Add($"Contact {input[1]} does not exist.");
                else if (input[0] == "ListAll") hasListAll = true;

                input = Console.ReadLine().Split().ToList();
            };

            if (hasListAll == true && phonebook.Count > 0)
            {
                foreach (var contact in phonebook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }

            }
            else if (hasListAll == true && phonebook.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (var contact in result)
                {
                    Console.WriteLine(contact);
                }

            }
        }
    }
}
