using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management
{
    internal class Admin
    {

        public int adminid;
        public string adminname;
        public string admindesignation;
        public int adminsalary;
        public string getInfo()
        {
            string adminInfo = adminid.ToString() + "\t" + adminname + "\t" + admindesignation + "\t" + "$" + adminsalary.ToString();
            return adminInfo;
        }
    }
}
