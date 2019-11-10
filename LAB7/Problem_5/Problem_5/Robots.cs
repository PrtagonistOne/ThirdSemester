using System;

namespace Problem_5
{
    class Robots : ICheckID
    {
        public string ID { get; set; }

        public string Model { get; set; }

        public Robots(string model, string id)
        {
            ID = id;
            Model = model;
        }

        public void Detaine(string s)
        {
            int c = 0;
            for (int i = (ID.Length - 3); i < ID.Length; i++)
            {
                if (ID[i] == s[i - (ID.Length - 3)])
                { c++; }
            }
            if (c == 3) { Console.WriteLine(ID); }
        }


    }
}
