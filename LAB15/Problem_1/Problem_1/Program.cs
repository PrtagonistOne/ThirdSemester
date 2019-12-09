using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_1
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
                    studs.Add(new Students(start[0], start[1], int.Parse(start[2])));

                }
            }
                var selectStuds = from i in studs
                                  where i.GroupNum == 2
                                  orderby i.FirstName
                                  select i;

                foreach (Students i in selectStuds)
                {
                    i.Display();
                }
          

        }
    }
}
