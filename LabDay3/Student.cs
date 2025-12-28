using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Subjects { get; set; }
        public int[] Grades { get; set; }
        public int TotalGrades()
        {
            return Grades.Sum();
        }

        public override string ToString()
        {
            return $"Student Id: {Id}, Student Name: {Name}";
        }
    }
}
