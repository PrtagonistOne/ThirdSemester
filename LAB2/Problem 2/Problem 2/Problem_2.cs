using System;

    class Problem_2
    {
        static void Main()
        {

        Console.WriteLine("Input elements:");

        string beg;
        beg = Console.ReadLine();              // ввели числа через пробел
        string[] beg1 = beg.Split(" ");         //создали массив подстрок, разбивая входную строку по одному или нескольким разделителям

        int n = beg1.Length;  // задали переменной n количество чисел которые ввели в консоль

        int[] array = new int[n];   // выделили память для массива чисел
       
        for (int i = 0; i < n; i++)
        array[i] = Convert.ToInt32(beg1[i]);  //Массив подстрок состоящий из string чисел конвертируєм в массив чисел іnt 

        Console.WriteLine("Input the amount of rotation:");
        int k = int.Parse(Console.ReadLine());   //количество вращений

        int[] sumArray = new int[n];  // выделяем память для массив суммы

        for (int j = 0; j < k; j++)
        {
            int t = array[n - 1];      //переменной присвоили значение последнего элемента в массиве чисел
            for (int i = n - 1; i > 0; i--)
            {
                array[i] = array[i - 1]; //двигаем элементы массива чисел
            }
            array[0] = t; //присвоили первому элементу массива чисел значения последнего
            for (int p = 0; p < n; p++)
            {
                sumArray[p] += array[p]; // присваиваем массиву сумм его значения
            }


        }

        Console.WriteLine("Output:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(sumArray[i] + " "); //вывод массива сумм через пробел в ряд
        }


    }
    }

