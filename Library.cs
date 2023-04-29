using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaqazin
{
    internal class Library
    {
        private Book[] books = new Book[0];

        public void AddBook(Book book) 
        {
            Array.Resize(ref books, books.Length - 1);
            books[books.Length -1] = book;
        }

        public Book[] FindAllBooks(string name) {
            return Array.FindAll(books, x => x.Name == name );
        }

        public Book GetBook(string code) {
            return Array.Find(books, x => x.Code == code);
        }

        //public Book RemoveAll(string authorname) {
        //    return  books = books.Where((source, i)=>(source Authorname != authorname)).ToString();
        //}
    }
}
