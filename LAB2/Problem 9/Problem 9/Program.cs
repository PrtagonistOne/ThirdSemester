using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            // массив типа char для алфавита
            string a;

            Console.WriteLine("Input word");
            a = Console.ReadLine();
            //вводим слово
            char[] word = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                word[i] = a[i];
            }
            //введеное слово записываем в массив word типа char
            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (word[j] == letters[i])
                    {
                        Console.WriteLine($"{word[j]} -> {i}");//сравниваем элементы слова и алфавита и при нахождении совпадений выводим индекс совпавшей буквы
                    }

                }
            }
        }
    }
}
