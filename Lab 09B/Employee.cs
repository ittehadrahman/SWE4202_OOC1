using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09B
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string type;
        public string contact;
        public string date;
        public string leaves;
        public double salary = 10000;
        
        public int employment()
        {
            int employment = 10;
            return employment;
        }
        
        public virtual double Salary(double amount)
        {
            return salary;
        }

        public string getInfo()
        {
            string Employee_Info =  Convert.ToString(ID) + "\t" + Name + "\t" + type +"\t" + contact + "\t" + Convert.ToString(date) + "\t" + (leaves) + "\t" + salary;
            return Employee_Info;
        }
    }
}
