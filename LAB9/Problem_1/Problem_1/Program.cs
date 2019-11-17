using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Amount of strings: ");

            int n = int.Parse(Console.ReadLine());

            string[] t = new string[n];
            Console.WriteLine("Input the strings: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Box<string> boxy = new Box<string>(t[i]);
                Console.WriteLine(boxy);
            }

        }
    }
}
