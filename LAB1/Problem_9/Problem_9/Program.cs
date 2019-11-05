using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double area;
        area = ((a + b) / 2) * h;

        Console.WriteLine($"The area of trapezoid is {area}");
        Console.Read();
    }
}

