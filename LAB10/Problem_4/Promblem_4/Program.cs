using System;

namespace Promblem_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input rocks: ");
            string[] start = Console.ReadLine().Split(" ");

            int[] rocks = new int[start.Length];

            for (int i = 0; i < rocks.Length; i++)
            {
                rocks[i] = int.Parse(start[i]);
            }
            Lake lake = new Lake(rocks);

            foreach (int sts in lake.GetEnumerator())
            {
                Console.Write(sts + " ");
            }
        }
    }
}
