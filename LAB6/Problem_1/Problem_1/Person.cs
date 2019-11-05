using System;
using System.Text;
namespace Problem_1
{
    public class Person
    {
        public string name;
        public int age;
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should not be negative");
                }
                else age = value;
            }
        }
        public virtual string Name
        {
            get { return name; }
            set
            {            
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less the 3 symbols!");
                }
                else name = value;
            }
        }


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {Name}, Age: {Age}"));

            return stringBuilder.ToString();
        }
    }
}
