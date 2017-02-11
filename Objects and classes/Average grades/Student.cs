using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_grades
{
    class Student
    {
        public string Name { get; set; }

        public static double[] Grades
        { get; set; }

        public double AverageGrade;

        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades;
            AverageGrade = Grades.Average();
        }
    }
}
