using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_group
{
    class Program
    {
        static void Main(string[] args)
        {
            var allAtendants = new SortedDictionary<string, Student>();

            var members = Console.ReadLine();
            members = GetAllDates(allAtendants, members);

            GetAllComments(allAtendants);

            foreach (var student in allAtendants)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comment)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Attendances.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd\\/MM\\/yyyy")}");
                }
            }
        }

        private static void GetAllComments(SortedDictionary<string, Student> allAtendants)
        {
            while (true)
            {
                var comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }

                var commentSplit = comment.Split('-').ToArray();
                var currentName = commentSplit[0];


                if (allAtendants.ContainsKey(currentName))
                {
                    allAtendants[currentName].Comment.Add(commentSplit[1]);
                }
            }
        }

        private static string GetAllDates(SortedDictionary<string, Student> allAtendants, string members)
        {
            while (members != "end of dates")
            {

                string[] membersSplit = members.Split().ToArray();

                List<DateTime> dates = new List<DateTime>();

                if (membersSplit.Length > 1)
                {
                    dates = membersSplit[1]
                        .Split(',')
                        .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToList();
                }
                var currentStudentName = membersSplit[0];
                if (allAtendants.ContainsKey(currentStudentName))
                {
                    allAtendants[currentStudentName].Attendances.AddRange(dates);
                }
                else
                {
                    Student currentStudent = new Student
                    {
                        Name = currentStudentName,
                        Attendances = dates,
                        Comment = new List<string>()
                    };
                    allAtendants[currentStudentName] = currentStudent;
                }
                members = Console.ReadLine();
            }

            return members;
        }
    }
}
