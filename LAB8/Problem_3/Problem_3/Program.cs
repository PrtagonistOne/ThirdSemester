using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the height and the width of the rectangle: ");
            string[] re = Console.ReadLine().Split(" ");

            Rectangle rectangle = new Rectangle(double.Parse(re[0]), double.Parse(re[1]));
            Console.WriteLine($"Area - {rectangle.Area()}");
            Console.WriteLine($"Perimeter - {rectangle.Perimeter()}");
            Console.WriteLine();
            Console.WriteLine(rectangle.Draw());


            Console.WriteLine("Input the Radius of the circle: ");
            string ci = Console.ReadLine();

            Circle circle = new Circle(double.Parse(ci));
            Console.WriteLine($"Area - {circle.Area()}");
            Console.WriteLine($"Perimeter - {circle.Perimeter()}");
            Console.WriteLine();
            Console.WriteLine(circle.Draw());



        }
    }
}
