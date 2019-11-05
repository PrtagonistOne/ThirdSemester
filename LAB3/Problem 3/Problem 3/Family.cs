using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    class Family
    {
        Person[] member; //массив объектов класса Person

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
            for (int i = 0; i < member.Length; i++)
            {
               
                Console.WriteLine($"{member[i].Name}  {member[i].Age}");
            }

        }//конструктор для вывода всех введеных членов семьи
        public Person GetOldestMemeber(int n)
        {
            int oldest = member[0].Age, t=0;
            for (int i = 0; i < n; i++)
            {
                if (member[i].Age > oldest)
                {
                    t = i;
                }             
            }
            Console.WriteLine($"The oldest member of the family is: {member[t].Name} - {member[t].Age}");
            return member[t];
        }//конструктор в котором находится маскимальное значение Age и выводит страшего члена семьи
    }
}
