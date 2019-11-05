using System;
using System.Collections.Generic;
using System.Text;

namespace Family
{
    class Family
    {
        Person[] member;

        public Family()
        {      }
        public Family(int list)
        {
            member = new Person[list];
        }

        public void AddMember(int i, string[] name, int[] age)
        {
            member[i] = new Person(name[i], age[i]);
        }
        public void GetInfo()
        {
            for (int i = 0; i <= member.Length; i++)
            {
                Console.WriteLine($"{member[i].Name}   {member[i].Age}");
            }

        }
        public Person GetOldestMemeber(int n)
        {
            int oldest = member[0].Age, t = 0;
            for (int i = 0; i <= n; i++)
            {
                if (member[i].Age > 0)
                {
                    oldest = member[i].Age;
                    t = i;
                }
            }
            Console.WriteLine($"The oldest member of the family is: {member[t].Name} - {member[t].Age}");
            return member[t];
        }
    }
}
