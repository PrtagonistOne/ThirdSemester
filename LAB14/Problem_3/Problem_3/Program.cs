using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input Email: ");
            string[] n = Console.ReadLine().Split("@");

            string user = n[0];
            string domain = n[1];

            string email = user + "@" + domain;

            string hiddenUser = "";
            for (int i=0;i<user.Length;i++)
            {
                hiddenUser += "*";
            }

            string hidenEmail = hiddenUser + "@"+ domain;

            Console.WriteLine(hidenEmail);

            Console.WriteLine("Input messege to hide the email in: ");
            string[] h = Console.ReadLine().Split(" ");

            for(int i=0;i<h.Length;i++)
            {
                if (h[i] == email)
                {
                    h[i] = hidenEmail;

                }
                Console.Write($"{h[i]} ");
            }

           
          


        }
    }
}
