using System;

namespace Problem_6

{

    class Program
    {
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main()
        {
            Console.Write("Input Cellphone numbers: ");
            string[] cells = Console.ReadLine().Split(" ");
            Console.Write("Input Cellphone numbers: ");
            string[] links = Console.ReadLine().Split(" ");

            Smartphone phone = new Smartphone();
            phone.Notify += DisplayMessage;

            for (int i = 0; i < cells.Length; i++)
            { phone.Call(cells[i]); }

            for (int i = 0; i < links.Length; i++)
            { phone.Browse(links[i]); }
        }
    }
}
