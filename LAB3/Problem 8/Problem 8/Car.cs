using System;
using System.Collections.Generic;

namespace Problem_8
{
    class Car : Cargo
    {
     public string Model { get; set; }
        public Car(string model,
            int egineSpeed, int eginePower,
             int weight, string type,
            double tire1pressure, int tire1age,
            double tire2pressure, int tire2age,
            double tire3pressure, int tire3age,
            double tire4pressure, int tire4age)
            :base(egineSpeed, eginePower,
                 weight, type,
                  tire1pressure, tire1age, tire2pressure, tire2age, tire3pressure, tire3age, tire4pressure, tire4age)
        {
            Model = model;
        }
    }
}
