using System;

class Problem_17
{
    static void Main()
    {
        int n, factorial;
        factorial = 1;
        Console.WriteLine("Input digit: ");
        n = int.Parse(Console.ReadLine());
        int i = 2;
        for (i = 2; i <= n; i++)
        {
            factorial*= i;
        }
        Console.WriteLine(factorial);
     
    }
}

