using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input student: ");
                string[] s = Console.ReadLine().Split(" ");

                Student someStudent = new Student(s[0], s[1], s[2]);

                Console.Write("Input worker:");
                s = Console.ReadLine().Split(" ");

                Worker someWorker = new Worker(s[0], s[1], float.Parse(s[2]), int.Parse(s[3]));

                someStudent.Display();

                someWorker.Display();
            }
            catch (ArgumentException ae)
            { Console.WriteLine(ae.Message); }
        }
    }
}
