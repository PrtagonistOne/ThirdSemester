using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input: Name, Age, Id and Birthdate ");
            string[] t = Console.ReadLine().Split(" ");

            Citizen person = new Citizen(t[0], int.Parse(t[1]), t[2], t[3]);

            person.Display();

        }
    }
}
