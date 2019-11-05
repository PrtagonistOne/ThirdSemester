using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input height and width of the rectangle: ");
            string[] pararms = Console.ReadLine().Split(" ");

            Rectangle rectangle = new Rectangle(double.Parse(pararms[0]), double.Parse(pararms[1]));


            Console.WriteLine(rectangle.Draw());
            Console.WriteLine($"Area - {rectangle.Area()}");
            Console.WriteLine($"Perimeter - {rectangle.Perimeter()}");
        }
    }
}
