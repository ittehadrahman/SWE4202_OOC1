using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {
        public int ID;
        public string title;
        public string author;
        public string publisher;
        public int quantity;

        public void borrow()
        {
            this.quantity=this.quantity-1;
        }
    }
}
