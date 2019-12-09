using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            List<Students> studs = new List<Students>();

            string[] start = { "" };
            int[] marks = null;
            while (start[0] != "END")
            {
                start = Console.ReadLine().Split(" ");
                if (start[0] != "END")
                {
                    string fullName = start[0] + " " + start[1];
                    int j = 2;
                    marks = new int[start.Length - 2];
                    for (int i = 0; i < marks.Length; i++)
                    {
                        marks[i] = int.Parse(start[j]);
                        j++;
                    }
               
                if (marks.Length+2 == start.Length)
                {
                    studs.Add(new Students(fullName, start));

                }
                }
            }

            var selectStuds = from q in studs
                              where q.Marks.Contains("6")
                              select q;

            foreach (Students q in selectStuds)
            {
                q.Display();

            }
        }
    }
}
