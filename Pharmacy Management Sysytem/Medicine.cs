using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_Sysytem
{
    public class Medicine
    {
        public string name;
        public int price;
        public int quantity;
        public int previous_stock;
        public void add()
        {
            this.previous_stock = this.quantity + this.previous_stock;
        }
        public void sell()
        {
            this.previous_stock = this.previous_stock - this.quantity ;
        }
        public string getInfo()
        {
            string medicineinfo = name + "\t" + Convert.ToString(previous_stock);
            return medicineinfo;
        }

    }
}
