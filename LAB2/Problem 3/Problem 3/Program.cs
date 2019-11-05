using System;

namespace Problem_3
{
    class Program
    {
        static void Main()

        {
            int k, ki;

            Console.WriteLine("Input the amount of 4*k integers");

            k = int.Parse(Console.ReadLine());
            ki = k;

            k *= 4; //Увеличиваем размер k в 4 раза

            int[] a = new int[k]; //Инициализация главного массива

            Console.WriteLine($"Array size is {k}\n Please input integers");
            for (int i = 0; i < k; i++)
            {
                a[i] = int.Parse(Console.ReadLine()); //Вводим данные главного массива
            }

            int[] k1 = new int[k / 2]; 
            int[] k2 = new int[k / 2]; //   массивы для свернутых значений
            int[] sum = new int[k / 2]; // массив для суммы свернутых массивов
            int j = 0, j1 = 0;

            for (int i = 0; i < k; i++)
            {
                if ((i < ki) || (i >= (k - ki))) //таким образом разделив размерность массива на два, получившиеся число делим на половину и берем столько значений с начала массива и конца
                {                             
                    k1[j] = a[i];  //все эти числа записываем в отдельный массив
                    j++;
                }
                else //Для теж значения которые не были свёрнутыми
                {
                    k2[j1] = a[i];
                    j1++;
                }
            }
            int[] rvrs1 = new int[ki]; // для первой половины k1
            int[] rvrs2 = new int[ki]; // для второй половины k1
            int q = ki - 1;
            for (int i = 0; i < ki; i++)
            {
                rvrs1[q] = k1[i]; 
                q--;
                
            }
            for (int i = 0; i < ki; i++)
            {
                k1[i] = rvrs1[i];
            }//Заполняем первую половину массива для свернутых чисел реверсными значения 

            int q1 = ki - 1;
            q = k1.Length / 2;
            for (int i = q; i < k1.Length; i++) 
            {
                rvrs2[q1] = k1[i];
                q1--;
            }
            q1 = 0;
            for (int i = q; i < k1.Length; i++)
            {
                k1[i] = rvrs2[q1]; q1++;
            } //Заполняем вторую половину массива для свернутых чисел реверсными значения 

            int p = k / 2;
            for (int i = 0; i < p; i++)
            {
                sum[i] = k1[i] + k2[i];
            }

            for (int i = 0; i < k1.Length; i++)
            { Console.Write(k1[i] + "\t"); }

            Console.Write("+\n");

            for (int i = 0; i < k2.Length; i++)
            { Console.Write(k2[i] + "\t"); }

            Console.Write("=\n");

            for (int i = 0; i < p; i++)
            { Console.Write(sum[i] + "\t"); }
        }
    }
}
