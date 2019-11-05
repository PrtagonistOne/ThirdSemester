using System;
using System.Collections.Generic;

namespace Problem_8
{
    class Cargo : Engine
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int egineSpeed, int eginePower,
             int weight, string type,
            double tire1pressure, int tire1age,
            double tire2pressure, int tire2age,
            double tire3pressure, int tire3age,
            double tire4pressure, int tire4age)
            : base(egineSpeed, eginePower,
                  tire1pressure, tire1age, tire2pressure, tire2age, tire3pressure, tire3age, tire4pressure, tire4age)
        {
            Weight = weight;
            Type = type;
        }

    }
}
