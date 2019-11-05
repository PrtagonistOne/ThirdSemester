using System;

namespace Problem_2
{
    class Citizen : IBirthable, IIdentefiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        public void Display() => Console.WriteLine($"\n Name is {Name} \n Age is {Age} \n Id is {Id} \n Birthdate is {Birthdate}");
    }
}
