using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Amount of integers: ");

            int n = int.Parse(Console.ReadLine());

            int[] t = new int[n];
            Console.WriteLine("Input the integers: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Box<int> boxy = new Box<int>(t[i]);
                Console.WriteLine(boxy);
            }
            
        }
    }
}
