using System;

namespace Problem_5
{
    class Robots : ICheckID
    {
        public string ID { get; set; }

        public string Model { get; set; }

        public Robots(string id, string model)
        {
            ID = id;
            Model = model;
        }

        public void Detaine(string fake)
        {
            int c = 0;
            for (int i = (ID.Length - 3); i < ID.Length; i++)
            {
                if (ID[i] == fake[i - (ID.Length - 3)])
                { c++; }
            }
            if (c == 3) { Console.WriteLine(ID); }
        }


    }
}
