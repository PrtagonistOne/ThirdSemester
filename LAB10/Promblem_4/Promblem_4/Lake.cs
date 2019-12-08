using System;
using System.Collections.Generic;
using System.Text;

namespace Promblem_4
{
    class Lake
    {
        public int [] Stoner { get; set; }
        public Lake(int[] rocks)
        {
            Stoner = new int[rocks.Length];

            for (int i = 0; i < Stoner.Length; i++)
            {
                Stoner[i] = rocks[i];
            }
        }
        public IEnumerable<int> GetEnumerator()
        {
            for (int i = 0; i < Stoner.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Stoner[i];
                }
            }
            for (int i= Stoner.Length-1; i >= 0 ; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Stoner[i];
                }
            }
        }


    }
}
