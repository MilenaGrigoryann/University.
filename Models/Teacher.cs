using System;

namespace UniversityConsoleApp1.Models
{
    public class Teacher : Person
    {
        public Student[] Students { get; set; }
        public Group Group { get; set; }
        public Group[] Groups { get; set; }
        public Teacher()
        {

        }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Teacher(string firstName, string lastName, int age, Student[] students) : base(firstName, lastName, age)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Students[i] = students[i];
            }
        }
        public Teacher(string firstName, string lastName, int age, Student[] students, Group group) : base(firstName, lastName, age)
        {

            Students = students;

            Group = group;

        }

    }
}
