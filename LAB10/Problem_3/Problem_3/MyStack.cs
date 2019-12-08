using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    class MyStack<T>
    {
        private T[] input;
        public T[] Input
        {
            get { return input; }
            set
            {
                input = value;
            }
        }
        public MyStack()
        {

        }
        public void Push(T[] smth) 
        {
            int k = 0;
            if (input != null)
            {
                k = input.Length;
            }

            for (int i = 0; i < smth.Length; i++)
            {
                k++;
                Array.Resize(ref input, k);
                Input[Input.Length - 1] = smth[i];
            }
        }
        public void Pop()
        {
            int k = Input.Length;
            if (k == 0)
            {
                Console.WriteLine("Stack is Empty!");
            }
            else
            {
                for (int i = 0; i < k - 1; i++)
                {
                    if (i == (k - 1))
                    {
                        for (int j = i; j < i; j++)
                         Input[j] = Input[j + 1]; 

                        k--;
                        Array.Resize(ref input, k);
                        break;
                    }

                }
            }
        }
        public IEnumerable<T>PrintAll()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    yield return input[j];
                }
            }
        }
    }
}
