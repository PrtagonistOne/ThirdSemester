using System;
namespace Problem_3
{
    class Program
    {
        public static void Swaping<T>(Generic<T> boxes, int i, int j)
        {
            T t = boxes.Store[i];
            boxes.Store[i] = boxes.Store[j];
            boxes.Store[j] = t;
        }
        static void Main()
        {

            Console.WriteLine("Input amount of strings: ");
            int n = int.Parse(Console.ReadLine());

            string[] t = new string[n];
            

            for (int i = 0; i < n; i++)
            {
                t[i] = Console.ReadLine();                
            }
            Generic<string> p = new Generic<string>(n, t);
          
            

            Console.WriteLine("Input indexes of strings to swap: ");
            string[] m = Console.ReadLine().Split(" ");
            int m1 = int.Parse(m[0]);
            int m2 = int.Parse(m[1]);

            Swaping<string>(p, m1, m2);
            p.Display();
        }
       
    }
}
