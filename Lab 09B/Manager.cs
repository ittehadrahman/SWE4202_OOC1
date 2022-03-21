using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09B
{
    public class Manager : Employee
    {
        public override double Salary(double amount)
        {
            return this.salary * 1.15;
        }
    }
}
