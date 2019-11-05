using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input number: ");
        double number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the n-th digit to print: ");
        double n = Convert.ToInt32(Console.ReadLine());


        double nDigit;

        nDigit = (number / Math.Pow(10, n - 1)) % 10;



        Console.WriteLine($"The n-th digit is {Math.Truncate(nDigit)} ");

    }
}
