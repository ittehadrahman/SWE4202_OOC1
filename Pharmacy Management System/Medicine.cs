using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    public class Medicine
    {
        public string name;
        public int price_of_each_medicine;
        public int quantity;
        public int previous_stock;
        public static int account_balance=0;
        public void add()
        {
            this.previous_stock = this.quantity + this.previous_stock;
        }
        public void sell()
        {
            this.previous_stock = this.previous_stock - this.quantity;
            account_balance = account_balance + this.quantity * this.price_of_each_medicine;
            
        }
        public string getInfo()
        {
            string medicineInfo = name + "\t" + Convert.ToString(this.previous_stock);
            return medicineInfo;
        }
    }
}
