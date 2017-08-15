using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(',').Select(x => x.Trim());
            var songs = Console.ReadLine().Split(',').Select(c => c.Trim());

            var performanceShow = new Dictionary<string, List<string>>();

            var performance = Console.ReadLine();

            while (performance != "dawn")
            {
                var currentPerformance = performance.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                var name = currentPerformance[0].Trim();
                var song = currentPerformance[1].Trim();
                var award = currentPerformance[2].Trim();

                if (!participants.Any(s => s == name) || !songs.Any(s => s == song))
                {
                    performance = Console.ReadLine();
                
                    continue;
                }
                if (participants.Contains(name))
                {
                    if (!performanceShow.ContainsKey(name))
                    {
                        performanceShow.Add(name, new List<string>());
                    }
                }
                if (songs.Contains(song))
                {
                    if (!performanceShow[name].Contains(award))
                    {
                        performanceShow[name].Add(award);
                    }
                }
                performance = Console.ReadLine();
            }

            if (performanceShow.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            var result = performanceShow.Where(c => c.Value.Count > 0).OrderByDescending(c => c.Value.Count).ThenBy(c => c.Key);

            foreach (var participant in result)
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var award in participant.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }

        }
    }
}
