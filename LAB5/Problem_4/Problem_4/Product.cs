using System;

namespace Problem_4
{
    class Product
    {
        private string prodName;
        private int cost;
        public string ProdName
        {
            get { return prodName; }         
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Name cannot be empty string.");
                    Console.ReadLine();
                }
                else prodName = value;
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cost cannot be negative");
                    Console.ReadLine();
                }
                else cost = value;
            }
        }
        public Product(string prodName, int cost)
        {
            this.ProdName = prodName;
            this.Cost = cost;
        }
        public Product() { }
    }
}
