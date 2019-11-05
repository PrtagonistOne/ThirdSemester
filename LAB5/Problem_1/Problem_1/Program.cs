using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Box cube = new Box();
            Console.WriteLine($"Input length:");           
            cube.Length = double.Parse(Console.ReadLine());

            Console.WriteLine($"Input width:");
            cube.Width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Input height:");
            cube.Height = double.Parse(Console.ReadLine());

            cube.GetSurface();
            cube.GetLateral();
            cube.GetVolume();
        }
    }
}
