using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person q)
        {
            if(Name == q.Name && Age == q.Age && Town == q.Town)
            {
                return 1;
            }
            else { return 0; }
        }
    }
}
