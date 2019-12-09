using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Students(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
        public void Display() => Console.WriteLine($"{FirstName} {LastName} ");
    }
}
