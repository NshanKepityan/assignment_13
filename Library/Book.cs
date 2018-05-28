using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Library
{
    public class Book
    {
        /// <summary>
        /// the unique number of the current book
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the author of the book
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// the title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// the price of the book
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// the year of publishing of the book
        /// </summary>
        public int Year { get; set; }
        public Book()
        {

        }

    }
}