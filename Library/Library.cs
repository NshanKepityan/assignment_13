using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Library : ILibrary
    {
        /// <summary>
        /// list of books(library)
        /// </summary>
        private static List<Book> books = new List<Book>();
        /// <summary>
        /// gives all books from library
        /// </summary>
        /// <returns>Res with it's status message and books</returns>
        public Res AllBooks()
        {
            return new Res { Status = "Succsess", Message = $"There is {books.Count} books in library", Books = books };
        }

        /// <summary>
        /// add new book in library
        /// </summary>
        /// <param name="book">the new book to be added</param>
        /// <returns>Res with it's status message and books</returns>
        public Res NewBook(Book book)
        {
            foreach(var b in books)
            {
                if(b.Id == book.Id)
                return new Res { Status = "Failed", Message = "The book you want to add already exists in library", Books = null };
            }
            books.Add(book);
            return new Res { Status = "Succsess", Message = "The book was successfully added", Books = new List<Book>{ book } };
        }

        /// <summary>
        /// update book's price
        /// </summary>
        /// <param name="Id">book's id</param>
        /// <param name="price">new price</param>
        /// <returns>Res with it's status message and books</returns>
        public Res UpdatePrice(int Id, double price)
        {
            foreach(var book in books)
            {
                if (book.Id == Id)
                {
                    book.Price = price;
                    return new Res { Status = "Succsess", Message = "The price was successfully changed", Books = new List<Book> { book } };
                }
            }
            return new Res { Status = "Failed", Message = "The book was not found", Books = null };
        }
    }
}
