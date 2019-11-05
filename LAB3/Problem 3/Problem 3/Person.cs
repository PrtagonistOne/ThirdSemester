using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
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
        public Person() : this("No name", 1)
        {
        }
        public Person(int age) : this("No name", age)
        {
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
     

    }
}
