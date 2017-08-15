namespace Ordered_banking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderedBanking
    {
        public static void Main(string[] args)
        {
            var bank = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (input != "end")
            {

                var tokens = input.Split(new[] { " -> " }
                    , StringSplitOptions.RemoveEmptyEntries);

                var currentBank = tokens[0];
                var account = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                if (!bank.ContainsKey(currentBank))
                {
                    bank[currentBank] = new Dictionary<string, decimal>();
                }
                if (!bank[currentBank].ContainsKey(account))
                {
                    bank[currentBank][account] = 0;
                }

                bank[currentBank][account] += balance;

                input = Console.ReadLine();
            }

            var orderedBank = bank
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var currentBank in orderedBank)
            {
                foreach (var account in currentBank.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({currentBank.Key})");
                }
            }
        }
    }
}
