using System;

namespace Problem_0
{
    class Program
    {
        static void Main()
        {
            
            Box<int> box1 = new Box<int> { store = 123123};

            Box<string> box2 = new Box<string> { store = "life in a box" };

            Console.WriteLine(box1);
            Console.WriteLine(box2);
        }
    }
}
