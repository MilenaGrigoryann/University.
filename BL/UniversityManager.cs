using System;
using UniversityConsoleApp1.Models;
namespace UniversityConsoleApp1.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            student.Teacher = teacher;
            return student;
        }
        public static Student[] SwapWithTeachers(Student[] students, Teacher[] teachers)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Teacher = teachers[i % teachers.Length];

            }
            return students;
        }
        public static Teacher[] SwapWithStudent(Teacher[] teachers, Student[] students)
        {
            int scount = students.Length;
            int tcount = teachers.Length;

            for (int i = 0; i < teachers.Length; i++)
            {
                int perTeacher = scount / tcount;

                teachers[i].Students = new Student[perTeacher];
                for (int j = 0; j < perTeacher; j++)
                {
                    teachers[i].Students[j] = students[j];
                }

                scount = scount - perTeacher;
                tcount--;

            }

            return teachers;
        }
        public static Teacher SwapWithStudents(Teacher teacher, Student[] students)
        {
            teacher.Students = students;
            return teacher;
        }
        public static Student[] SwapWithGroup(Student[] students, Group group)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Group = group;
            }
            return students;
        }

        }
    }

