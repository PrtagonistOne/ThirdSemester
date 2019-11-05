using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input driver's name: ");
            string name = Console.ReadLine();

            IFerrari car = new Ferrari(name);

            car.Display();
        }
    }
}
