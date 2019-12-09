using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public Students(string firstName, string lastName, string mail)
        {
            FirstName = firstName;
            LastName = lastName;
            Mail = mail;
        }
        public void Display() => Console.WriteLine($"{FirstName} {LastName} ");
    }
}
