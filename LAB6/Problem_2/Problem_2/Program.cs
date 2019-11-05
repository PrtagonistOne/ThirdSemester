using System;
using System.Text;
namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }
    }
}
