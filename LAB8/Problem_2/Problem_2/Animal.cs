using System;

namespace Problem_2
{
    class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        public virtual void ExplainSelf()
        {
            Console.WriteLine($"I am {Name} and my favourite food is {FavouriteFood}!");
        }
    }
}
