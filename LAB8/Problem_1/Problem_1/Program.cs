using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            MathOperations mo = new MathOperations();

            Console.WriteLine($"sum of integer: {mo.Add(2,2)}");
            Console.WriteLine($"sum of double: {mo.Add(2.2, 5.5, 3.3)}");
            Console.WriteLine($"sum of decimal: {mo.Add(2.2m, 5.5m, 4.4m)}");
        }
    }
}
