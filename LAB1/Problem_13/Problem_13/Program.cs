using System;

class Problem_13
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool result;

        if (n % (9) == 0 || n % (11) == 0 || n % (13) == 0)
        { result = true; }
        else { result = false; }
        Console.WriteLine(result);


    }
}

