using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Roli_the_coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var @event = Console.ReadLine();

            var events = new Dictionary<string, List<string>>();

            var regEvents = new Dictionary<int, string>();

            while (@event != "Time for Code")
            {

                var line = new Regex(@"(?<id>\d+)\s\#(?<eventName>[\w]+)(?<partisipants>\s+(?:@\w+\s*)+)?");
                var eventMatch = line.Match(@event);

                if (eventMatch.Success)
                {

                    var eventId = int.Parse(eventMatch.Groups["id"].Value);
                    var eventName = eventMatch.Groups["eventName"].Value;
                    var particips = eventMatch.Groups["partisipants"]
                           .Value
                           .Split(new[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries)
                           .ToList();

                    if (!regEvents.ContainsKey(eventId) && !regEvents.ContainsValue(eventName))
                    {
                        regEvents.Add(eventId, eventName);
                    }
                    if (regEvents.ContainsValue(eventName) && !events.ContainsKey(eventName))
                    {
                        events.Add(eventName, new List<string>());
                    }
                    if (events.ContainsKey(eventName))
                    {
                        events[eventName].AddRange(particips);
                    }
                }

                @event = Console.ReadLine();
            }
            var result = events.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key);

            foreach (var currentEvent in result)
            {
                Console.WriteLine($"{currentEvent.Key} - {currentEvent.Value.Distinct().Count()}");

                foreach (var participant in currentEvent.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine("@" + participant);
                }

            }
        }
    }
}
