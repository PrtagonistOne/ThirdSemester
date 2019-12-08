using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input your persons: ");

            List<Person> persons = new List<Person>();

            string[] start = Console.ReadLine().Split(" ");

            while(start[0] != "END")
            {
                persons.Add(new Person(start[0], int.Parse(start[1]), start[2]));

                start = Console.ReadLine().Split(" ");
            }

            Console.WriteLine("Input num of a Person to compare to: ");

            int n = int.Parse(Console.ReadLine());

            int sum = 1;

            for (int i=0;i<persons.Count;i++)
            {
                if(i == n - 1)
                {
                    for (int j=0; j<persons.Count;j++)
                    {
                        if (persons[j] != persons[i])
                        {
                            sum += persons[j].CompareTo(persons[i]);
                        }
                    }
                }
            }
            if(sum-1 == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{sum} {persons.Count - sum} {persons.Count}");
            }
        }
    }
}
