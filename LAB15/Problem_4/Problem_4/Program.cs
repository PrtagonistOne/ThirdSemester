using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            List<Students> studs = new List<Students>();

            string[] start = { "" };

            while (start[0] != "END")
            {
                start = Console.ReadLine().Split(" ");

                if (start.Length == 2)
                {
                    studs.Add(new Students(start[0], start[1]));

                }
            }

            var selectStuds = studs.OrderBy(i => i.LastName).ThenByDescending(i => i.FirstName);
            foreach (Students i in selectStuds)
            {
                i.Display();

            }
        }
    }
}
