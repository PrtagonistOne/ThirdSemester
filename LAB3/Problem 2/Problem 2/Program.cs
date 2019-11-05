using System;

namespace Problem_2
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
        public Person() : this ("No name", 1)
        {
        }
        public Person(int age) : this ("No name", age)
        {
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} \n Age: {age} \n");
        }
    }
    class Program
    {
        static void Main()
        {

            Person person = new Person();

            person.GetInfo();


            Person person1 = new Person();
            Console.Write("Input age: ");
            person1.Age = int.Parse(Console.ReadLine());

            person1.GetInfo();

            Person person2 = new Person();
            Console.Write("Input name: ");
            person2.Name = Console.ReadLine();

            Console.Write("Input age: ");
            person2.Age = int.Parse(Console.ReadLine());

            person2.GetInfo();

        }
    }
  }

