using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Create your List: ");

            ListyIterator<string> Input = new ListyIterator<string>();

            string[] start = Console.ReadLine().Split(" ");

            if (start[0] == "Create" && start.Length > 1)
            {
                Input.Create(start);
                Console.WriteLine("Your List was succesfully created!");
            }
            else Console.WriteLine("Invalid Operation");

            while(start[0] != "END")
            {
                start = Console.ReadLine().Split(" ");
                if (start[0] == "Move")
                {
                    Input.Move();
                }
                else if (start[0] == "HasNext")
                {
                    Console.WriteLine(Input.HasNext());
                }
                else if (start[0] == "Print")
                {
                    Input.Print();
                }
                else if (start[0]=="PrintAll")
                {
                    foreach(string q in Input.PrintAll())
                    {
                        Console.WriteLine(q + " ");
                    }

                }
                else Console.WriteLine("Invalid Operation");
            }

        }
    }
}
