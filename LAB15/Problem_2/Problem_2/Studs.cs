using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class Studs
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Studs(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        public void Display() => Console.WriteLine($"{FirstName} {LastName} ");
    }
}
