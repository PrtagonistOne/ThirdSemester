using System;

namespace Problem_1
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
    }
    class Program
    {
        static void Main()
        {       
            
                Person person = new Person();

            person.Name = "Pesho";
                person.Age = 20;
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");
            Console.Write(" \n");
            Person person1 = new Person();

            Console.Write("Input name: ");
            person1.Name = Console.ReadLine();           
            Console.Write("Input age: ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.Write(" \n");

            Console.WriteLine($"Name: {person1.Name}");
            Console.WriteLine($"Age: {person1.Age}");

            Person person2 = new Person();
            Console.Write(" \n");
            person2.Name = "Stamat";
            person2.Age = 43;
            Console.WriteLine($"Name: {person2.Name}");
            Console.WriteLine($"Age: {person.Age}");

        }
    }
}
