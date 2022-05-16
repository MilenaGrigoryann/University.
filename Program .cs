using System;
using UniversityConsoleApp1.BL;
using UniversityConsoleApp1.Models;

namespace UniversityConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Person[] students = studentManager.Create(19, 18);
            Person[] teachers = teacherManager.Create(30, 19);
            Person student = studentManager.Create("John", "Doe", 18);
            Person teacher = teacherManager.Create("Ben", "Devis", 45);
            UniversityManager.SwapWithStudents((Teacher)teacher, (Student[])students);
            teacherManager.Print(teacher);
            UniversityManager.SwapWithTeacher((Student)student, (Teacher)teacher);
            studentManager.Print(student);
            UniversityManager.SwapWithStudent((Teacher[])teachers, (Student[])students);
            teacherManager.Print(teachers);
            UniversityManager.SwapWithTeachers((Student[])students, (Teacher[])teachers);
            studentManager.Print(students);
            Group group = GroupManager.Create("C#");
            Group[] groups = GroupManager.Create(5);
            Console.WriteLine("888888888888888888888888888888888888888888888");
            GroupManager.Print(groups);
            students=UniversityManager.SwapWithGroup((Student[])students, group);
            studentManager.Print(students);
            Console.ReadKey();
        }
    }
}
