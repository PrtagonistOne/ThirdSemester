using System;

namespace P03_JediGalaxy
{
    interface ICoordinates
    {
         int X { get; set; }
         int Y { get; set; }

         void Move(int[,] matrica);

    }
}
