using System;

namespace Problem_1
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            set
            {
                if(value > 0)
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        public void GetSurface()
        {
            double vol = (2 * length * width) + (2 * length * height) + (2 * width * height);
            Console.WriteLine($"Surface Are - {vol}");
        }
        public void GetLateral()
        {
            double vol = (2 * length * height) + (2 * width * height);
            Console.WriteLine($"Lateral Surface Area - {vol}");
        }
        public void GetVolume()
        {
            double vol = length * width * height;
            Console.WriteLine($"Volume - {vol}");
        }
  
   

    }
}
