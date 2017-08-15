using System.Collections.Concurrent;
using System.Globalization;

namespace Students_group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var currInput = Console.ReadLine();

            var towns = new List<Town>();
            var groups = new List<Group>();
            var students = new List<Student>();

            while (currInput != "End")
            {
                if (currInput.Contains("=>"))
                {
                    var townTokens = currInput
                        .Split(new char[] { '=', '>', ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    var newTown = new Town()
                    {
                        Name = townTokens[0],
                        SeatsCapacity = int.Parse(townTokens[1]),
                        Students = new List<Student>()
                    };
                    towns.Add(newTown);
                }
                else if (!currInput.Contains("=>") || !currInput.Contains("..."))
                {
                    var townTokens = currInput
                        .Split(new char[] { '|', ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    var currStudent = new Student()
                    {
                        Name = townTokens[0],
                        Email = townTokens[1],
                        RegisterDate = DateTime.Parse(townTokens[2], CultureInfo.InvariantCulture)
                    };

                    students.Add(currStudent);

                    towns.Last().Students.Add(currStudent);
                    DistributedStudentsGroups(towns);
                }

                currInput = Console.ReadLine();
            }
            towns.Distinct();
            Console.WriteLine(groups.Count);
            Console.WriteLine(towns.Count);
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine();
            }
        }

        static List<Group> DistributedStudentsGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            towns.Sort();
            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(x => x.RegisterDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCapacity).ToList();
                    students = students.Skip(group.Town.SeatsCapacity);
                    groups.Add(group);
                }
            }

            return groups;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCapacity { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
