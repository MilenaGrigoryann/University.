using System;
using UniversityConsoleApp1.Models;

namespace UniversityConsoleApp1.BL
{
    public static class GroupManager
    {
        public static Group Create(string name)
          => new Group()
          {
              Name = name,
          };
        public static Group[] Create(int count)
        {
            Group[] groups = new Group[count];
            for (int i = 0; i < count; i++)
            {
                groups[i] = new Group()
                {
                    Name = $"GroupName{i}",
                };
            }
            return groups;
        }
        public static void Print(Group group)
        {
            Console.WriteLine("************Group************");
            Console.WriteLine($"GroupId:{group.ID} GroupName:{group.Name}");
        }
        public static void Print(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"**************Group**************");
                Console.WriteLine($"GroupId:{groups[i].ID} Groupname:{groups[i].Name}");
            }
        }
    }
}
