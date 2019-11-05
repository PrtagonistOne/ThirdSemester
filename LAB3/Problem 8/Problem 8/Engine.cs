using System;
using System.Collections.Generic;

namespace Problem_8
{
    class Engine : Tire
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public Engine(int egineSpeed, int eginePower,
            double tire1pressure, int tire1age,
            double tire2pressure, int tire2age,
            double tire3pressure, int tire3age,
            double tire4pressure, int tire4age)
            : base(tire1pressure, tire1age, tire2pressure, tire2age, tire3pressure, tire3age, tire4pressure, tire4age)
        {
            EnginePower = eginePower;
            EngineSpeed = egineSpeed;

        }
    }
}
