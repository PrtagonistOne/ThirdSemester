using System;

namespace Problem_3
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;


        public override double Area()
        { 
            return Math.PI * Math.Pow(Radius,2); 
        }
        public override double Perimeter()
        { return 2 * Math.PI * Radius; }

        public override string Draw()
        {
            string Circle = "";

            for (double i = -Radius; i <= Radius; i++)
            {
                for (double j = -Radius; j <= Radius; j++)
                {
                    if (Math.Sqrt(i * i + j * j) <= (Radius * 0.90))
                    {
                        Circle += "0";
                    }
                    else Circle +=" ";
                }
                Circle +="\n";
            }
            return Circle;
        }
    }
}
