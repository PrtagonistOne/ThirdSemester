using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {

            Animal dog = new Dog("Pasha", "Whiskey");
            Animal cat = new Cat("Gosha", "Meet");

            dog.ExplainSelf();
            cat.ExplainSelf();
        }
    }
}
