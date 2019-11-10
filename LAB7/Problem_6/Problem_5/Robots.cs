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




    }
}
