using System;
using System.Text;
namespace Problem_1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Childs Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Childs Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Persons Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Persons Age:");
            int age1 = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine();
                Console.WriteLine($"Childs - {child.ToString()}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            try
            {
                Person person = new Person(name1, age1);
                Console.WriteLine();
                Console.WriteLine($"Person - {person.ToString()}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
