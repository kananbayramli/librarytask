using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace BookMaqazin
{
    internal class Book
    {
        private Book[] books = new Book[0];

        public int PageCount { get; set; }
        public string Name { get; set; }
        public string Authorname { get; set; }
        public decimal Price { get; set; }

        //capsulation
        private string code;
        public string Code
        { 
            set { this.code = value; }
            get { return code[0].ToString() + code.IndexOf(BookMaqazin.Book.books).ToString();} //indexi tapa bilmedim
        }



        public Book() { }

        public Book(int pagecount, string name, string authorname, decimal price, string code) 
        { 
            PageCount = pagecount;
            Name = name;
            Authorname = authorname;
            Price = price;
            Code = code;
        
        }

    }

}
