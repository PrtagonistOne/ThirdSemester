using System;

    class Problem_1
    {
        static void Main()
        {
        string array1, array2;  // для введения предложений
        
        Console.WriteLine("Input first array: ");                
        array1 = Console.ReadLine();                                                   //ввели первый массив слов
        string[] a1 = array1.Split(' '); //создает массив подстрок, разбивая входную строку по одному или нескольким разделителям

        Console.WriteLine("Input second array: ");     
        array2 = Console.ReadLine();                                             //ввели второй массив слов
        string[] a2 = array2.Split(' ');//создает массив подстрок, разбивая входную строку по одному или нескольким разделителям

        int output = 0;  // для подсчета одинаковых слов
       
        if (a1.Length <= a2.Length)     // если слов в первом меньше чем во втором, то выполняем алгоритм чтения с лева на право
        {
            for (int i = 0; i < a1.Length; i++)  
            {
                if (a1[i] == a2[i]) {      // сравниваем оба массива на одинаковые слова
                    output++;   // счетчик слов
                }
            }
        }
        else              // в другом случае выполняем алгоритм чтения с права на лево
        
        {
            for (int i = a2.Length - 1; i >= 0; i--)     
            {
                for (int j = a1.Length - 1; j >= (a1.Length - a2.Length); j--)   //  чтобы после прохождения по второму закончилось и прохождение по первому который больше
                {
                    if (a1[j] == a2[i]) {
                        output++; // счетчик слов
                    }

                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Output:  {output}");  //вывод значения
        Console.Read(); // для паузы
    }
    }

