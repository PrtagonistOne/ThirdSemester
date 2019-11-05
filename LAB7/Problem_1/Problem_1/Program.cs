using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        { 
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        IPerson person = new Citizen(name, age);

            person.Display();
        }
    }
}
