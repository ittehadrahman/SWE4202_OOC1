using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Book
    {
        public int BookID;
        public string Bookname;
        public string Author;
        public string Publisher;
        public int Quantity;
        public string getInfo()
        {
            string bookinfo = Convert.ToString(BookID) + "\t" + Bookname;
            return bookinfo;
        }
        public string get()
        {
            return this.BookID + "\t" + this.Bookname + "\t" + this.Author+"\t"+this.Publisher+"\t"+Convert.ToString(this.Quantity);
        }
        public void borrow()
        {
            this.Quantity--;
        }
    }
}
