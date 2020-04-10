using System;
using System.Collections.Generic;
namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            
                SomeClass obj1 = new SomeClass("Ass");
                SomeClass obj2 = new SomeClass("Tits");
                obj2 = obj1;
                obj1.SomeProb = obj2.SomeProb;
                Console.WriteLine(obj1.SomeProb);
            }
        }
   }

