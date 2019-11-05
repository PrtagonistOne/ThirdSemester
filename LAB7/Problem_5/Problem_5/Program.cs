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

            Console.WriteLine("Input Citizens and/or Robots: ");
            string[] start = Console.ReadLine().Split(" ");

            while (start[0] != "End")
            {
                if (start.Length == 3)
                { 
                    Citizens t = new Citizens(start[0], start[1], int.Parse(start[2])); citizens.Add(t); 
                }
                else if(start.Length == 2)
                {
                    Robots t = new Robots(start[0], start[1]); robots.Add(t);
                }
                
                    start = Console.ReadLine().Split(" ");
            }
            Console.WriteLine("Input Fake ID");
            string fakeID = Console.ReadLine();

            for (int i = 0; i < citizens.Count; i++)
            {
                citizens[i].Detaine(fakeID);
            }

            for (int i = 0; i < robots.Count; i++)
            {
                robots[i].Detaine(fakeID);
            }
        }
    }
}
