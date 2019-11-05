using System;
using System.Collections.Generic;

namespace Problem_1
{
    abstract class Tire
    {
        public int Tire1Age { get; set; }
        public double Tire1Pressure { get; set; }

        public int Tire2Age { get; set; }
        public double Tire2Pressure { get; set; }

        public int Tire3Age { get; set; }
        public double Tire3Pressure { get; set; }

        public int Tire4Age { get; set; }
        public double Tire4Pressure { get; set; }

        public Tire(double tire1pressure, int tire1age,
            double tire2pressure, int tire2age,
            double tire3pressure, int tire3age,
            double tire4pressure, int tire4age)
        {
            this.Tire1Age = tire1age;
            this.Tire1Pressure = tire1pressure;

            this.Tire2Age = tire2age;
            this.Tire2Pressure = tire2pressure;

            this.Tire3Age = tire3age;
            this.Tire3Pressure = tire3pressure;

            Tire4Age = tire4age;
            Tire4Pressure = tire4pressure;
        }
        public double TirePressure()
        {
            double val = (Tire1Pressure + Tire2Pressure + Tire3Pressure + Tire4Pressure) / 4;
            return val;
        }
    }
}
