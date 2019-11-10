using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            List<Citizens> citizens = new List<Citizens>();
            List<Robots> robots = new List<Robots>();
            List<Pet> pets = new List<Pet>();

            Events happening = new Events();

            Console.WriteLine("Input Citizens, Robots and/or Pets: ");
            string[] start = Console.ReadLine().Split(" ");

            while (start[0] != "End")
            {
                if (start[0] == "Citizen")
                { 
                    Citizens t = new Citizens(start[1], int.Parse(start[2]), start[3], start[4]);
                    citizens.Add(t); 
                }
                else if(start[0] == "Robot")
                {
                    Robots t = new Robots(start[1], start[2]); 
                    robots.Add(t);
                }
                else if (start[0] == "Pet")
                {
                    Pet t = new Pet(start[1], start[2]);
                    pets.Add(t);
                }
                else { Console.WriteLine("Invalid name!"); }

                start = Console.ReadLine().Split(" ");
            }
            Console.WriteLine("Year of birth");
            string dateOfYear = Console.ReadLine();

            for (int i = 0; i < citizens.Count; i++)
            {
                happening.wantedYear += citizens[i].YearIs;
                happening.Counter(dateOfYear);
                happening.wantedYear -= citizens[i].YearIs;
            }

            for (int i = 0; i < pets.Count; i++)
            {
                happening.wantedYear += pets[i].YearIs;
                happening.Counter(dateOfYear);
                happening.wantedYear -= pets[i].YearIs;
            }

        }
    }
}
