using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            List<Student> result = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentInput = Console.ReadLine().Split().ToArray();
                var currentGrades = studentInput.Skip(1).Select(double.Parse).ToArray();
                students.Add(new Student(studentInput[0], currentGrades));

            }
            foreach (var student in students)
            {
                if (student.AverageGrade >= 5)
                {
                        result.Add(student);
                }
            }
            result = result.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}