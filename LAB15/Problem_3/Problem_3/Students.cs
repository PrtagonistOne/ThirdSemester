using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Students(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public void Display() => Console.WriteLine($"{FirstName} {LastName} {Age}");
    }
}
