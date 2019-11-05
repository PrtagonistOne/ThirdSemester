using System;
using System.Collections.Generic;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
           
                Console.WriteLine("Input amount customers");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Input clients: ");
                List<Person> customers = new List<Person>();
                for (int i = 0; i < n; i++)
                {

                    string[] s1 = Console.ReadLine().Split("=");
                    Console.WriteLine($"{s1[1]}");
                    Person t = new Person(s1[0], int.Parse(s1[1]));
                    customers.Add(t);
                }


                Console.WriteLine("Input prodcuts: ");
                List<Product> prods = new List<Product>();
                for (int i = 0; i < n; i++)
                {

                    string[] s1 = Console.ReadLine().Split("=");
                    Product t = new Product(s1[0], int.Parse(s1[1]));
                    prods.Add(t);
                }

            Console.WriteLine();
            Console.WriteLine("Input customer`s name and wanted product: ");

            string exit = Console.ReadLine();

            while (exit != "END")
            {
                string[] s1 = exit.Split(" ");

                Product bought = new Product();

                for (int i = 0; i < prods.Count; i++)
                {
                    if (s1[1] == prods[i].ProdName)
                    {
                        bought = new Product(prods[i].ProdName, prods[i].Cost);
                    }
                }
                for (int i = 0; i < customers.Count; i++)
                {
                    if (s1[0] == customers[i].Name)
                    { 
                        customers[i].AddProduct(bought); 
                        Console.WriteLine();

                    }  
                }


                exit = Console.ReadLine();
            }

            for (int i = 0; i < customers.Count; i++)
            { 
                customers[i].Display(); Console.WriteLine(); 
            }  
        }
    }
}

