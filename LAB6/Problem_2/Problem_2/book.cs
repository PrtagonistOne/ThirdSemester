using System;
using System.Text;
namespace Problem_2
{
    class Book
    {
        private string author;
        private string title;
        private decimal price;

        protected virtual string Author
        {
            get { return author; }
            set
            {
                string[] smth = value.Split(" ");
                string secondName = smth[1];
                bool number = false;

                for (int i = 0; i < secondName.Length; i++)
                {
                    number = Char.IsDigit(secondName[0]);
                }
                if (number == true)
                {
                    throw new ArgumentException("Author not valid!");
                }
                else author = value;
            }


        }
        
        protected virtual string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else title = value;
            }
        }
        protected virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                else
                price = value;

            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

                string result = resultBuilder.ToString().TrimEnd();
                return result;
        }

    }
}
