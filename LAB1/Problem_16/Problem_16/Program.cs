using System;

class Problem_16
{
    static void Main()
    {
        int n;
        Console.WriteLine("Input the digit: ");
        n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Monday");
                Console.Read();

                break;
            case 2:
                Console.WriteLine("Tuesday");
                Console.Read();
                break;
            case 3:
                Console.WriteLine("Wednesday");
                Console.Read();
                break;
            case 4:
                Console.WriteLine("Thursday");
                Console.Read();
                break;
            case 5:
                Console.WriteLine("Friday");
                Console.Read();
                break;
            case 6:
                Console.WriteLine("Saturday");
                Console.Read();
                break;
            case 7:
                Console.WriteLine("Sunday");
                Console.Read();
                break;
            default:
                Console.WriteLine("Not valid");
                Console.Read();
                break;
        }

    }
}

