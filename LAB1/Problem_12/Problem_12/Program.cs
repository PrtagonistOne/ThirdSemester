using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input number that is greater than 20 and odd: ");
        double n = Convert.ToInt32(Console.ReadLine());

        double result;

        if (n > 20 && n%2 == 1) { Console.WriteLine("True "); }
        else Console.WriteLine("False ");

    }
}

