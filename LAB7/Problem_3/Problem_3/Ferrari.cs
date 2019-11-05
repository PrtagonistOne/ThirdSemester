using System;

namespace Problem_3
{
    class Ferrari : IFerrari
    {
        public string Name { get; set; }
        public string Model { get; } = "488-Spider";

        public Ferrari(string Name) => this.Name = Name;

        public string Brake() => "Brakes!";
        public string Gas() => "Zadu6avam sA!";

        public void Display() => Console.WriteLine($"\n {Model} / {Brake()} / {Gas()} / {Name}");
    }
}
