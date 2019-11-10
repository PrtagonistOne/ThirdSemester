using System;

namespace Problem_5
{
    class Citizens : ICheckID, IBirthable
    {
        public string ID { get; set; }
        public string Name { get; set; }      
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public Citizens(string name, int age, string id, string birthdate)
        {
            ID = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public void YearIs(string year)
        {
            string[] q = Birthdate.Split("/");

            if (q[2] == year)
            {
                Console.WriteLine(Birthdate);
            }
        }
    }
}
