using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input n of double to compare: ");
            int n = int.Parse(Console.ReadLine());

            double s;
            double[] s1 = new double[n];

            for (int i = 0; i < n; i++)
            {
                s = double.Parse(Console.ReadLine());
                s1[i] = s;
            }

            Box<double> toCompare = new Box<double>(s1);

            Console.WriteLine("Input the double that is need to be compared with: ");
            double[] th = new double[1];
            th[0] = double.Parse(Console.ReadLine());


            Console.WriteLine(toCompare.Compare(th));
        }
    }
}
