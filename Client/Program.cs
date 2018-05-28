using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.LibraryClient();
            var res1 = client.NewBook(new ServiceReference1.Book() { Id = 1, Author = "Author1", Title = "Title1", Price = 1500, Year = 2009 });
            Console.WriteLine(res1.Message);
            var res2 = client.NewBook(new ServiceReference1.Book() { Id = 2, Author = "Author2", Title = "Title2", Price = 2500, Year = 2013 });
            Console.WriteLine(res2.Message);
            var result = client.AllBooks();
            Console.WriteLine(result.Message);

            foreach(var book in result.Books)
            {
                Console.WriteLine("--------- book with Id:{0} -----------",book.Id);
                Console.WriteLine("the author is:{0}",book.Author);
                Console.WriteLine("the title is:{0}",book.Title);
                Console.WriteLine("the price is:{0}",book.Price);
                Console.WriteLine("was published in:{0}",book.Year);
                Console.WriteLine("--------------------------------------");
            }
            var res3 = client.UpdatePrice(1, 2800);
            Console.WriteLine("--------- book with Id:{0} -----------", res3.Books[0].Id);
            Console.WriteLine("the author is:{0}", res3.Books[0].Author);
            Console.WriteLine("the title is:{0}", res3.Books[0].Title);
            Console.WriteLine("the price is:{0}", res3.Books[0].Price);
            Console.WriteLine("was published in:{0}", res3.Books[0].Year);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
    }
}
