using System;
using System.Linq;
namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            string[] sentence = input.Split(chars, StringSplitOptions.RemoveEmptyEntries);

            string[] seperators = input.Split(sentence, StringSplitOptions.RemoveEmptyEntries);
            int n = sentence.Length;
            sentence = sentence.Reverse().ToArray();
            for (int i = 0; i < n; i++)
            {
                Console.Write(sentence[i] + seperators[i]);
            }
            Console.ReadKey();
        }
    }
}
