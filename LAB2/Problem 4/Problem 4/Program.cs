using System;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            int n;

            Console.WriteLine("Input the finding limit of prime numbers");

            n = int.Parse(Console.ReadLine());

            int[] prime = new int[n - 1];

            int j = 2;
            for (int i = 0; i < n - 1; i++)
            {
                prime[i] = j;
                j++;
            }

            int k = prime[0], p = 0, s = prime.Length;

            for (int q = 0; q < s; q++)
            {
                for (int i = p; i < s; i++)
                {
                    if (prime[i] != 0)
                    {
                        k = prime[i];
                        break;
                    }
                }

                for (int i = p; i < s; i++)
                {
                    if (prime[i] > k)
                    {
                        if (prime[i] % k == 0) { prime[i] = 0; }
                    }
                    if (prime[s - 1] == 0)
                    {
                        s--;
                        Array.Resize(ref prime, s);
                    }
                    
                    if (i == s - 1) { p++; }
                }
            }


            for (int i = 0; i < s; i++) { if (prime[i] != 0) { Console.Write(prime[i] + " "); } }

        }
    }
}
