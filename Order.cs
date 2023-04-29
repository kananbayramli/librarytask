using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaqazin
{
    internal class Order
    {
        private Book[] books = new Book[0];

        private int id;
        public int Id 
        {
            get { return id; }
            private set { this.id = value; } //set oluna bilmemesi ucun private
        }
       
        public string Booklist { 
            get; 
            set;
        }
        public decimal TotalPrice {
            get;
            set; 
        }
         public DateTime Date { get; set; }
    }
}
