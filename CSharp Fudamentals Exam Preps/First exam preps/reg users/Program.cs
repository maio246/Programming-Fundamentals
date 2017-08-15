using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_users
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new Dictionary<string, DateTime>();

            var user = Console.ReadLine();

            while (user != "end")
            {
                var tokens = user.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                var username = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, date);
                }

                user = Console.ReadLine();
            }

            var result = users.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var userLog in result)
            {
                Console.WriteLine($"{userLog.Key}");
            }
        }
    }
}
