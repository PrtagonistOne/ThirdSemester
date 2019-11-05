using System;

namespace Problem_1
{
    class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display() => Console.WriteLine($"Name is {Name}, age is {Age}");
    }
}
