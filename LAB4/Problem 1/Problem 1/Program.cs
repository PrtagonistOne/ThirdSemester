using System;
using System.Collections.Generic;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the amount of cars: ");
            int n = int.Parse(Console.ReadLine());

            List<Car> autos = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] s1 = Console.ReadLine().Split(" ");
                Car t = new Car(s1[0], int.Parse(s1[1]), int.Parse(s1[2]), int.Parse(s1[3]), s1[4],
                    double.Parse(s1[5]), int.Parse(s1[6]), double.Parse(s1[7]), int.Parse(s1[8]),
                    double.Parse(s1[9]), int.Parse(s1[10]), double.Parse(s1[11]), int.Parse(s1[12]));
                autos.Add(t);
            }
            Console.WriteLine("Input cargo type (fragile or flamable): ");
            string carg = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (carg == autos[i].Type)
                {
                    if (autos[i].Type == "fragile" && autos[i].TirePressure() < 1)
                    {
                        Console.WriteLine($"Fragile cars: {autos[i].Model}");
                    }

                    if (autos[i].Type == "flamable" && autos[i].EnginePower > 250)
                    {
                        Console.WriteLine($"Flamable cars: {autos[i].Model}");
                    }
                }

            }
        }
    }
}
