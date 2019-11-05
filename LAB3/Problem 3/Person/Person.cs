using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public string name;
        public int age;
        public Person() { name = "No name"; age = 1; }      //конструктор 1 без аргументов

        public Person(int n) : this(" ", n) { name = "No name"; age = n; }   //конструктор 2 с аргументом который принимает только значение int 

        public Person(string a, int n) { name = a; age = n; }   //конструктор 3 с двумя аргументами string и int 
        public string Name { get; set; }
        public int Age { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");  //вывод имени и возраста
        }
    }
}
