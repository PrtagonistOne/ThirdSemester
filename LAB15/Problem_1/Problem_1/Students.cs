using System;
using System.Text;

namespace Problem_1
{
    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int GroupNum { get; set; }

        public Students(string firstName, string secondName, int groupNum)
        {
            FirstName = firstName;
            SecondName = secondName;
            GroupNum = groupNum;
        }
        public void Display() => Console.WriteLine($"{FirstName} {SecondName} ");
    }
}
