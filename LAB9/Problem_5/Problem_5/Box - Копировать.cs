using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Differece<T> 

    {
       
        public void Riznitsya( object x, object y )
        {
            if (x.GetType() == typeof(int) && y.GetType() == typeof(int))
            {
                int c1 = (int)x + (int)y;

                Console.WriteLine(c1);
            }
             
            else if (x.GetType() == typeof(double) && y.GetType() == typeof(double))
            {
                double c1 = (double)x + (double)y;

                Console.WriteLine(c1);
            }
            else if(x.GetType() == typeof(decimal) && y.GetType() == typeof(decimal))
            {
                decimal c1 = (decimal)x + (decimal)y;

                Console.WriteLine(c1);
            }
            else if(x.GetType() == typeof(float) && y.GetType() == typeof(float))
            {
                decimal c1 = (decimal)x + (decimal)y;

                Console.WriteLine(c1);
            }
            else if(x.GetType() == typeof(string) && y.GetType() == typeof(string))
            {

                Console.WriteLine("Нельзя отнимать строки!");
            }
            else
                Console.WriteLine("Неверное приведение типов!");
        }
    }
}
