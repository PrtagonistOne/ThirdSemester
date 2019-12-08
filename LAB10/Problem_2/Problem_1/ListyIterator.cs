using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    class ListyIterator<T>
    {
        private int indx;
        public T[] Input { get; set; }
        public ListyIterator()
        {

        }
        public void Create ( T[] smth)
        {
            int j = 1;
            Input = new T[smth.Length - 1];
            for (int i = 0; i < Input.Length; i++)
            {
                Input[i] = smth[j];
                j++;
            }
            indx = 0;
        }
        public bool HasNext()
        {
            if(indx + 1< Input.Length)
            {
                return true;
            }
            else { return false; }
        }
        public bool Move()
        {
            if (HasNext())
            {
                indx++;
                return true;
            }
            else return false;
        }
        public void Print()
        {
            Console.WriteLine(Input[indx]);
        }

        public IEnumerable<T> PrintAll()
        {
            foreach(T i in Input)
            {
                yield return i;
            }
        }
    }
}
