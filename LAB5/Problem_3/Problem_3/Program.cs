using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            

            Console.WriteLine("Name of the Chicken: ");
            string nam = Console.ReadLine();

            Console.WriteLine("Age of the Chicken: ");
            int ag = int.Parse(Console.ReadLine());

            Chickens chicken = new Chickens(nam, ag);

            chicken.GetChiks();

        }
    }
}
