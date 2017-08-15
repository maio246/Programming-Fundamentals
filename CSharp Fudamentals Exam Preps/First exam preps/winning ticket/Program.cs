using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace winning_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                
                var leftHalf = new string(ticket.Take(10).ToArray());
                var rightHalf = new string(ticket.Skip(10).ToArray());

                var winningSymbols = new string[] {"@", "#", "\\$", "\\^"};
                var winningTicket = false;

                foreach (var winningSymbol in winningSymbols)
                {
                    var regex = new Regex($"{winningSymbol}{{6,}}");
                    var leftMatch = regex.Match(leftHalf);
                    if (leftMatch.Success)
                    {
                        var rightMatch = regex.Match(rightHalf);
                        if (rightMatch.Success)
                        {
                            winningTicket = true;

                            var leftSymbolsLength = leftMatch.Value.Length;
                            var rightSymbolsLength = rightMatch.Value.Length;

                            var jackpot = leftSymbolsLength == 10 && rightSymbolsLength == 10
                                ? "Jackpot!"
                                : string.Empty;

                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftSymbolsLength, rightSymbolsLength)}{winningSymbol.Trim('\\')} {jackpot}"); 
                            break;
                        }
                    }
                }
                if (!winningTicket)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}


