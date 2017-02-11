using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 6;
            cout(input);
            Dictionary<string, int> words = new Dictionary<string, int>();
            {
                words.Add("BGN", 5);
                words.Add("")
            };

        var amount = double.Parse(Console.ReadLine());
        var currencyFrom = Console.ReadLine();
        var currencyTo = Console.ReadLine();
            if (currencyFrom == "BGN" && currencyTo == "USD") Console.WriteLine(Math.Round((amount / 1.79549),2));
            if (currencyFrom == "BGN" && currencyTo == "EUR") Console.WriteLine(Math.Round((amount / 1.95583),2));
            if (currencyFrom == "BGN" && currencyTo == "GBP") Console.WriteLine(Math.Round((amount / 2.53405),2));
            if (currencyFrom == "USD" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount* 1.79549),2));
            if (currencyFrom == "USD" && currencyTo == "EUR") Console.WriteLine(Math.Round(((amount* 1.79549) / 1.95583),2));
            if (currencyFrom == "USD" && currencyTo == "GBP") Console.WriteLine(Math.Round(((amount* 1.79549) / 2.53405),2));
            if (currencyFrom == "EUR" && currencyTo == "USD") Console.WriteLine(Math.Round(((amount* 1.95583) / 1.79549),2));
            if (currencyFrom == "EUR" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount* 1.95583),2));
            if (currencyFrom == "EUR" && currencyTo == "GBP") Console.WriteLine(Math.Round(((amount* 1.95583) / 2.53405),2));
            if (currencyFrom == "GBP" && currencyTo == "USD") Console.WriteLine(Math.Round(((amount* 2.53405) / 1.79549),2));
            if (currencyFrom == "GBP" && currencyTo == "EUR") Console.WriteLine(Math.Round(((amount* 2.53405) / 1.95583),2));
            if (currencyFrom == "GBP" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount* 2.53405),2));
        }
}
    }
}
