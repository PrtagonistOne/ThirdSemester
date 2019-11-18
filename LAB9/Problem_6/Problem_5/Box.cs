using System;
using System.Collections.Generic;
namespace Problem_5
{
    class Box<T> where T : IComparable

    {
        List<T> boxxy = new List<T>();

        public Box(T[] s1)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                boxxy.Add(s1[i]);
            }
        }

        public int Compare(T[] comp)
        {
            int counter = 0;

            for (int i = 0; i < boxxy.Count; i++)
            {
                    if (comp[0].CompareTo(boxxy[i]) < 0)
                    {
                        counter++;                      
                    }
            }

            return counter;
        }
    }
}
