using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            List<Studs> studs = new List<Studs>();

            string[] start = { "" };

            while (start[0] != "END")
            {
                start = Console.ReadLine().Split(" ");

                if (start.Length == 2)
                {
                    studs.Add(new Studs(start[0], start[1]));

                }
            }
            var selectStuds = from i in studs
                              where i.FirstName.First() < i.LastName.First()
                              select i;

            foreach (Studs i in selectStuds)
            {
                i.Display();
                
            }
        }
    }
}
