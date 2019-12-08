using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input your stack: ");
            MyStack<int> myStack = new MyStack<int>();
            string[] start = Console.ReadLine().Split(" ");

            if (start[0] == "Push" && start.Length > 1)
            {
                int j = 1;
                int[] q = new int[start.Length - 1];
                for (int i = 0; i < q.Length; i++)
                {
                    q[i] = int.Parse(start[j]);
                    j++;
                }
                foreach (int i in q)
                    Console.WriteLine(i);
                myStack.Push(q);
            }
            else Console.WriteLine("No elements!");

            while (start[0] != "END")
            {
                start = Console.ReadLine().Split(" ");
                if (start[0] == "Push" && start.Length > 1)
                {
                    int j = 1;
                    int[] q = new int[start.Length - 1];
                    for (int i = 0; i < q.Length; i++)
                    {
                        q[i] = int.Parse(start[j]);
                        j++;
                    }
                    myStack.Push(q);
                }
                else if (start[0] == "Pop")
                {
                    myStack.Pop();
                }
                else Console.WriteLine("No Elements!");
            }
            foreach(int i in myStack.PrintAll())
            { Console.WriteLine(i); }

        }
    }
}
