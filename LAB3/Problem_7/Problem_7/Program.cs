using System;
using System.Collections.Generic;
namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the number of cars:");
            int n = int.Parse(Console.ReadLine());

            List<Car> groupOfCars = new List<Car>();

            bool exist = false;
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");

                for (int j = 0; j < groupOfCars.Count; j++)
                {
                    if (s2[0] == groupOfCars[j].Model)
                    {
                        exist = true;
                    }  
                }
                if (exist) { n++; }//Автомобиль с данной моделью уже существует
                else
                {
                    Car t = new Car(s2[0], float.Parse(s2[1]), float.Parse(s2[2]));
                    groupOfCars.Add(t);
                }
                exist = false;
            }

            string command1 = "";
            Car temp = new Car();
            bool success2 = false;
            while (true)
            {
                command1 = Console.ReadLine();
                if (command1 != "")
                {
                    if (command1 == "End" || command1 == "end") { System.Environment.Exit(0); }
                    string[] command2 = command1.Split(" ");

                    bool success1 = false;
                    if (command2.Length >= 2)
                    { 
                        success1 = int.TryParse(command2[2], out int distance);
                    }

                    if (command2[0] == "Drive" || command2[0] == "drive")
                    {
                        for (int i = 0; i < groupOfCars.Count; i++)
                        {
                            if (command2[1] == groupOfCars[i].Model && command2[1].Length == groupOfCars[i].Model.Length)
                            { 
                                temp = groupOfCars[i]; success2 = true;
                            }

                        }
                        if (success1 && success2)
                        {
                            temp.CheckFuel(int.Parse(command2[2]));
                        }
                        else { Console.WriteLine("Invalid input!"); }
                    }
                }
                else
                {
                    Console.Clear();
                }

            }
        }
    }
}
