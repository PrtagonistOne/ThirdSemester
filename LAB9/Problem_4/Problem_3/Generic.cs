using System;
using System.Text;
namespace Problem_3
{
    class Generic<T>
    {
        public T[] Store { get; set; }
        public Generic(int n, T[] store)
        {
            Store = new T[n];
            for (int i = 0; i < n; i++)
            {
                Store[i] = store[i];
            }
        }
        public void Display()
        {
            for (int i = 0; i < Store.Length; i++)
            { 
           Console.WriteLine($"{Store[i].GetType().FullName}  -  {Store[i]}"); 
            }
        }

    }
}

