using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            Dictionary<string, string> result = new Dictionary<string, string>();

            while (name != "stop")
            {
                name = Console.ReadLine();
                if (name != "stop")
                {
                    string email = Console.ReadLine();

                    if (email[email.Length - 2] != 'u' && email[email.Length - 1] != 's'
                    || email[email.Length - 2] != 'u' && email[email.Length - 1] != 'k')
                    {
                        if (result.ContainsKey(name))
                        {
                            result[name] = email.ToString();
                        }
                        result.Add(name, email.ToString());
                    }
                }

            }

            foreach (KeyValuePair<string, string> contact in result)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
