using System;

namespace P03_JediGalaxy
{
        public class Ivo : ICoordinates
        {
            public int X { get; set; }
            public int Y { get; set; }

            public static int Sum { get; set; }

            public Ivo(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Move(int[,] matrica)
            {
                while (X >= 0 && Y < matrica.GetLength(1))
                {
                    if (X >= 0 && X < matrica.GetLength(0) && Y >= 0 && Y < matrica.GetLength(1))
                    {
                        Sum += matrica[X, Y];
                    }
                    Y++;
                    X--;
                }
            }

        }
    }
