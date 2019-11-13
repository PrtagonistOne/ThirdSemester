using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Amount of strings: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the strings: ");
            for (int i=0;i<n;i++)
            {
                string t = Console.ReadLine();
                Box<string> boxy = new Box<string>(t);
                Console.WriteLine(boxy);
            }

        }
    }
}
