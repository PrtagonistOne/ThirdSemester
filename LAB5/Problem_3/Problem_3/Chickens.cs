using System;

namespace Problem_3
{
    class Chickens
    {

        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Name cannot be empty");
                    Console.ReadLine();
                }
                else name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if ((value < 0) || (value > 15))
                {
                    Console.WriteLine("Age should be between 0 and 15");
                    Console.ReadLine();
                }
                else age = value;
            }
        }

        public Chickens(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        private int product {get {return 1;} }
        public void GetChiks()
        {
            Console.WriteLine($"Chicken {name} (age {age}) can produce {product} eggs per day.");
        }
    }
}
