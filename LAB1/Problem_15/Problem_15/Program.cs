using System;

class Problem_15
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Input a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Input b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Input c: ");
        c = double.Parse(Console.ReadLine());

        double f = a * b * c;
        string product;

        if (f > 0)
        {
            product = "Positive";
            Console.WriteLine($"The Sign is {product}");
        }
        else if (f < 0)
        {
            product = "Negative";
            Console.WriteLine($"The Sign is {product}");
        }
        else Console.WriteLine($"The Sign is 0");

    }
}

