using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library
{
    [ServiceContract]
    public interface ILibrary
    {
        /// <summary>
        /// Returns all books from library
        /// </summary>
        /// <returns>Res struckt</returns>
        [OperationContract]
        Res AllBooks();

        /// <summary>
        /// add new book in library
        /// </summary>
        /// <param name="book">the book to be added</param>
        /// <returns>Res struckt</returns>
        [OperationContract]
        Res NewBook(Book book);

        /// <summary>
        /// change price of the book with given id
        /// </summary>
        /// <param name="Id">the id of the book</param>
        /// <param name="price">the new price</param>
        /// <returns>Res struckt</returns>
        [OperationContract]
        Res UpdatePrice(int Id,double price);
    }

    /// <summary>
    /// gives status message and books in out
    /// </summary>
    [DataContract]
    public struct Res
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<Book> Books { get; set; }

    }
}
