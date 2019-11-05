using System;

namespace P03_JediGalaxy
{
    class Evil
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Evil(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int[,] matrica)
        {
            while (X >= 0 && Y >= 0)
            {
                if (X >= 0 && X < matrica.GetLength(0) && Y >= 0 && Y < matrica.GetLength(1))
                {
                    matrica[X, Y] = 0;
                }
                X--;
                Y--;
            }
        }
    }
}
