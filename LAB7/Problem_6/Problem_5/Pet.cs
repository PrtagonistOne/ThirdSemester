using System;

namespace Problem_5
{
    class Pet : IBirthable
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
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
