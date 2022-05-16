using System;
using UniversityConsoleApp1.Models;

namespace UniversityConsoleApp1.BL
{
    public class BaseManager
    {
        int maxAge = 89;
        public virtual Person Create(string firstName, string lastNmae, int age) => new Person(firstName, lastNmae, age);
        public virtual Person[] Create(int count, int minAge)
        {
            Person[] people = new Person[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                people[i] = new Person($"name{i}", $" lastName{i}", rnd.Next(minAge, maxAge));
            }

            return people;
        }
        public virtual void Print(Person person)
        {
            Console.WriteLine("**********Person**********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");

        }
        public virtual void Print(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Print(people[i]);
            }
        }
    }
}
