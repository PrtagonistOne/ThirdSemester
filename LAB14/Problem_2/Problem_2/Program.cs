using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();

            if(n.Length < 20)
            {
                Console.WriteLine(n.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(n.Substring(0, 20));
            }
        }
    }
}
