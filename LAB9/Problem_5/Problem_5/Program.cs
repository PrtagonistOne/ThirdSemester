using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the abpunt of strings to compare: ");
            int n = int.Parse(Console.ReadLine());

            string s;
            string[] s1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                s1[i] = s;
            }

            Box<string> toCompare = new Box<string>(s1);

            Console.WriteLine("Input the string that is need to be compared with: ");
            s = Console.ReadLine();
            string[] th = s.Split();

            Console.WriteLine(toCompare.Compare(th));
        }
    }
}
