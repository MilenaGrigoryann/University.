using System;

namespace UniversityConsoleApp1.Models
{
    public class Person:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        int _age;
        public int Age
        {
            get => _age;
            set => _age = 16 < value && value < 90 ? value : throw new Exception("Invalid age");
        }
        public Person()
        {
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}

