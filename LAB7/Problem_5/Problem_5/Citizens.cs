﻿using System;

namespace Problem_5
{
    class Citizens : ICheckID
    {
        public string ID { get; set; }
        public string Name { get; set; }      
        public int Age { get; set; }

        public Citizens(string name, int age, string id)
        {
            ID = id;
            Name = name;
            Age = age;
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
