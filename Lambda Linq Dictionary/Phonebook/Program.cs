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
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            List<string> input = new List<string>();
            List<string> result = new List<string>();

            do
            {
                input = Console.ReadLine().Split().ToList();
                if (input[0] == "A")
                {
                    phonebook.Add(input[1], input[2]);
                }
                else if (input[0] == "S")
                {

                    if (phonebook.ContainsKey(input[1]))
                    {
                        result.Add($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        result.Add($"Contact {input[1]} does not exist.");
                    }
                }
            } while (input[0] != "END");
            foreach (var contact in result)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
