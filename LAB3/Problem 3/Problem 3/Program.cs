using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the amount of family members: ");
            int n = int.Parse(Console.ReadLine());//количество новых объектов 
            Family members = new Family(n); // n количество объектов 

            Console.WriteLine("Input their names and age: ");
            string[] name = new string[n]; 
            int[] age = new int[n];
            for (int i = 0; i < n; i++)
            {
                name[i] = Console.ReadLine();
                age[i] = int.Parse(Console.ReadLine());
                members.AddMember(i, name, age);
            }
            /* создает n количество объектов и одновременно записывает их поля name и age
            которые были введены ранее
             */
            members.GetInfo();
            members.GetOldestMemeber(n);

        }
    }
}
