using System;
using System.Text;
namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string sentece = Console.ReadLine();
            char[] constr = { '.', '!', '?' };

            string[] sentences = sentece.Split(constr, StringSplitOptions.RemoveEmptyEntries);

         
            Console.WriteLine();
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
            }

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] subSenteces = sentences[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool did = false;
                for (int j = 0; j < subSenteces.Length; j++)
                {
                    if (subSenteces[j] == word)
                    {
                        did = true;
                        break;
                    }
                }
                if (did)
                    Console.WriteLine(sentences[i]);
            }
        }
    }
}
