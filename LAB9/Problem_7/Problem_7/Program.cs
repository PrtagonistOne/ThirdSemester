using System;

namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            string[] start = Console.ReadLine().Split(" ");

            Box<string> boxxy = new Box<string>();

            while (start[0] != "END")
            {
                if (start[0] == "Add" && start.Length == 2)
                {
                    boxxy.Add(start[1]);
                }

                else if (start[0] == "Remove" && start.Length == 2)
                {
                    boxxy.Remove(int.Parse(start[1]));
                }

                else if (start[0] == "Contains" && start.Length == 2)
                {
                    Console.WriteLine(boxxy.Contains(start[1]));
                }

                else if (start[0] == "Swap" && start.Length == 3)
                {
                    boxxy.Swap(int.Parse(start[1]), int.Parse(start[2]));
                }

                else if (start[0] == "Greater" && start.Length == 2)
                {
                    boxxy.Greater(start[1]);
                }

                else if (start[0] == "Max" && start.Length == 1)
                {
                    boxxy.Max();
                }

                else if (start[0] == "Min" && start.Length == 1)
                {
                    boxxy.Min();
                }

                else if (start[0] == "Print" && start.Length == 1)
                {
                    boxxy.Display();
                }

                else
                {
                    Console.WriteLine("Invalid command!");
                }

                start = Console.ReadLine().Split(" ");
            }
        }
    }
}
