using System;

namespace Problem_3
{
        abstract class Shape
        {
            public abstract double Perimeter();

            public abstract double Area();

            public virtual string Draw()
            { return ""; }
        }
    
}
