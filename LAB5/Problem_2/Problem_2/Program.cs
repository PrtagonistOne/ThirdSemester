using System;

namespace Problem_2
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
            try
            {
                cube.GetSurface();
                cube.GetLateral();
                cube.GetVolume();
            }

            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
