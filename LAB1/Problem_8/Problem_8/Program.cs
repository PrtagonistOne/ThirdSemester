using System;

class Problem_8
{
    static void Main()
    {
        Console.WriteLine("Input a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double average;
        average = (a + b + c) / 3;

        Console.WriteLine($"The average number is {average}");


    }

}

