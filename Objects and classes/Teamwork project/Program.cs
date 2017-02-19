using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int teams = int.Parse(Console.ReadLine());

            var allTeams = new List<Team>();

            for (int i = 0; i < teams; i++)
            {
                string input = Console.ReadLine();

                var nameTeamSplit = input
                    .Split('-')
                    .ToArray();

                string personName = nameTeamSplit[0];
                string currentTeamName = nameTeamSplit[1];

                Team currentTeam = new Team();
                currentTeam.TeamName = currentTeamName;
                currentTeam.CreatorName = personName;
                currentTeam.MembersList = new List<string>();

                if (allTeams.All(c => c.TeamName != currentTeamName))
                {
                    allTeams.Add(currentTeam);
                    Console.WriteLine($"Team {currentTeam.TeamName} has been created by {personName}!");
                }
                else if (allTeams.Any(c => c.TeamName == currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                }
                else if (allTeams.Any(c => c.CreatorName == personName))
                {
                    Console.WriteLine($"{personName} cannot create another team!");
                }
            }
            string join = Console.ReadLine();

            while (join != "end of assignment")
            {
                var nameTeamSplit = join
            .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = nameTeamSplit[0];
                string currentTeamName = nameTeamSplit[1];

                if (allTeams.All(c => c.TeamName != currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} does not exist!");
                }
                else if (allTeams.Any(c => c.MembersList.Contains(personName))
                      || allTeams.Any(c => c.CreatorName == personName))
                {
                    Console.WriteLine($"Member {personName} cannot join team {currentTeamName}!");
                }
                else if (allTeams.Any(c => c.CreatorName != personName))
                {
                    allTeams.First(c => c.TeamName == currentTeamName).MembersList.Add(personName);
                }

                join = Console.ReadLine();
            }

            var teamsWithMembers = allTeams.Where(c => c.MembersList.Count > 0).ToList();
            var teamToDisband = allTeams.Where(c => c.MembersList.Count == 0).ToList();

            foreach (var team in teamsWithMembers.OrderByDescending(c=>c.MembersList.Count).ThenBy(c => c.TeamName))
            {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine($"- {team.CreatorName}");
                    foreach (var member in team.MembersList.OrderBy(c => c).ToList())
                    {
                        Console.WriteLine($"-- {member}");
                    }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamToDisband.OrderBy(n => n.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
