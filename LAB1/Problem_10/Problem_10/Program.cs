using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int lastDigit;
        lastDigit = n % (10);
        Console.WriteLine($"Your last digit is {lastDigit} ");

    }
}

