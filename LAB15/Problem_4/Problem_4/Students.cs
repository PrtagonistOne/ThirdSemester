using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Students(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Display() => Console.WriteLine($"{FirstName} {LastName}");
    }
}
