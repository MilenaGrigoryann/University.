using System;
using UniversityConsoleApp1.Models;

namespace UniversityConsoleApp1.BL
{
    public class TeacherManager : BaseManager
    {
        int maxAge = 89;
        public override Person Create(string firstName, string lastName, int age) => new Teacher(firstName, lastName, age);
        public override Person[] Create(int count, int minAge)
        {
            Teacher[] students = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new Teacher($"name{i}", $" lastName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }
        public override void Print(Person person)
        {
            Console.WriteLine("**********Teacher**********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            if (person is Teacher)
            {
                if (((Teacher)person).Students == null)
                    Console.WriteLine("___________________________________________");
                else
                {
                    for (int i = 0; i < ((Teacher)person).Students.Length; i++)
                        Console.WriteLine($"Student_id:{((Teacher)person).Students[i].ID} name:{((Teacher)person).Students[i].FirstName} lastName:{((Teacher)person).Students[i].LastName} age:{((Teacher)person).Students[i].Age}");
                }           

            }
        }
        public override void Print(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Print(people[i]);

            }
        }
    }
}