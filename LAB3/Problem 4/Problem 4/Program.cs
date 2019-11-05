using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the amount of family members: ");
            int n = int.Parse(Console.ReadLine());

            Poll members = new Poll(n);

            Console.WriteLine("Input their names: ");
            string[] name = new string[n];                 
            for (int i = 0; i < n; i++)
            {
                name[i] = Console.ReadLine();
            } 

            Console.WriteLine("Input their age: ");
            int[] age = new int[n];              //n массив полей int age
            for (int i = 0; i < n; i++)
            {
                age[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                members.AddMember(i, name, age);
            }

            members.GetInfo();
            Console.WriteLine("_____________________");
            members.Output(n, members);
        }
    }
}
