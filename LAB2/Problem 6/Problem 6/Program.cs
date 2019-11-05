using System;

namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input array size:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input integers:");

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++) { a[i] = int.Parse(Console.ReadLine()); }

            int start = a[0], len = 1;
            int oldStart = 0, oldLen = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == start)
                {
                    start = a[i];
                    len++;
                }

                if (a[i] != start)
                {
                    //oldStart = start;
                    start = a[i];
                    //oldLen = len;
                    len = 1;
                }
                if (len >= 2)
                {
                    if (len > oldLen)
                    {
                        oldLen = len;
                        oldStart = start;
                    }
                }
            }

            int[] maxLen = new int[oldLen];

            for (int i = 0; i < oldLen; i++) { maxLen[i] = oldStart; }

            Console.WriteLine();

            for (int i = 0; i < oldLen; i++) { Console.Write(maxLen[i] + " "); }
        }
    }
}
