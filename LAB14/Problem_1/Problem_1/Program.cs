using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();

            char[] n1 = n.ToCharArray();

            Array.Reverse(n1);

            n = new string(n1);
     

            Console.WriteLine(n);
        }
    }
}
