using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        { Console.WriteLine($"Max is {a}"); }
        else if (b > c)
        { Console.WriteLine($"Max is {b}"); }
        else
        { Console.WriteLine($"Max is {c}"); }

    }
}

