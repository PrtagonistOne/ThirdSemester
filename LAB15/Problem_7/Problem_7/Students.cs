using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7
{
    class Students
    {
        public string FullName { get; set; }
        public string[] Marks { get; set; }
        public Students(string fullName, string[] marks)
        {
            FullName = fullName;
            Marks = marks;
        }
        public void Display() => Console.WriteLine($"{FullName} ");
    }
}
