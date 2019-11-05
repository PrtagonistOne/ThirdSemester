using System;

namespace Problem_2
{
    class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
              : base(name, favouriteFood)
        { }

        public override void ExplainSelf()
        {
            Console.WriteLine($"I am {Name} and my favourite food is {FavouriteFood}!");
        }
    }
}
