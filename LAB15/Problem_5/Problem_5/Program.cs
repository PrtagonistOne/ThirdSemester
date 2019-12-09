using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_5
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

                if (start.Length == 3)
                {
                    studs.Add(new Students(start[0], start[1], start[2]));

                }
            }

            var selectStuds = from i in studs
                              where i.Mail.Contains("@gmail.com")
                              select i;

            foreach (Students i in selectStuds)
            {
                i.Display();

            }
        }
    }
}
