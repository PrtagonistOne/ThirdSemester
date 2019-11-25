using System;

namespace Problem_7
{
    class Box<T> where T : IComparable
    {
        T[] Boxxy;

        public Box() 
        { 
            Boxxy = new T[0];
        }

        public void Add(T element)
        {
             int n = Boxxy.Length + 1;

            Array.Resize(ref Boxxy, n);

            for (int i = n - 1; i < n; i++)
            {
                Boxxy[i] = element; 
            }
        }

        public void Remove(int indx)
        {
            int n = Boxxy.Length;

            for (int i = 0; i < n; i++)
            {
                if (i == indx)
                {
                    for (int j = i; j < n - 1; j++)
                        Boxxy[j] = Boxxy[j + 1];
                    n--;
                    Array.Resize(ref Boxxy, n);
                }
            }
        }

        public bool Contains(T element)
        {
            bool IsContains = false;

            for(int i = 0; i < Boxxy.Length;i++)
            {
                if(element.CompareTo(Boxxy[i]) == 0)
                { 
                    IsContains = true;
                }
            }

            return IsContains;
        }

        public void Swap(int indx1, int indx2)
        {
            T t = Boxxy[indx1];
            Boxxy[indx1] = Boxxy[indx2];
            Boxxy[indx2] = t;
        }

        public void Greater(T element)
        {
            int c = 0;
            for(int i=0;i< Boxxy.Length;i++)
            {
                if(element.CompareTo(Boxxy[i]) < 0)
                {
                    c++;
                }
            }

            Console.WriteLine(c);
        }

        public void Max()
        {
            T max = Boxxy[0];
            for(int i=0;i< Boxxy.Length;i++)
            {
                if(max.CompareTo(Boxxy[i]) < 0)
                {
                    max = Boxxy[i];
                }
            }

            Console.WriteLine(max);
        }

        public void Min()
        {
            T min = Boxxy[0];
            for (int i = 0; i < Boxxy.Length; i++)
            {
                if (min.CompareTo(Boxxy[i]) > 0)
                { 
                    min = Boxxy[i]; 
                }
            }

            Console.WriteLine(min);
        }

        public void Display()
        {
            for(int i=0;i< Boxxy.Length;i++)
            {
                Console.WriteLine(Boxxy[i]);
            }
        }
    }
}
