using System;
using System.Collections.Generic;
namespace Problem_4
{
    class Person
    {
        private string name;
        private int money;


        List<Product> BagOf = new List<Product>();

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Name cannot be empty string.");
                    Console.ReadLine();
                }
                else name = value;
            }
        }
        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Console.ReadLine();
                }
                else money = value;
            }
        }

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }
        public void AddProduct(Product bought)
        {
            if (Money >= bought.Cost)
            {
                Money -= bought.Cost;
                Product t = new Product(bought.ProdName, bought.Cost);
                BagOf.Add(t);

                Console.WriteLine($"{Name} bought {bought.ProdName}");
            }
            else { Console.WriteLine($"{Name} can`t afford {bought.ProdName}"); }

        }
        public void Display()
        {

                Console.Write($"{Name} - ");
                if (BagOf.Count == 0) { Console.Write("Nothing bought"); }
                else
                {
                    for (int i = 0; i < BagOf.Count; i++)
                    {
                    if (i == BagOf.Count - 1)
                    {
                        Console.Write($"{BagOf[i].ProdName}");
                    }
                    else Console.Write($"{BagOf[i].ProdName}, "); 


                    }
                }
            }
        }

    }

