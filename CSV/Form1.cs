using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new System.IO.StreamReader(@"F:\CSV\userInfo.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Employee dummy_employee = new Employee(values[0], values[1], values[2], values[3], values[4], values[5], (values[6]), (values[7]), (values[8]), values[9]);
                    List_of_Employees.employeeList.Add(dummy_employee);
                    
                }
            }
            InitializeListBoxValues();

        }
        private void InitializeListBoxValues()
        {
            EmployeeInformationListbox.Items.Clear();
            foreach (Employee temp in List_of_Employees.employeeList)
            {
                EmployeeInformationListbox.Items.Add(temp.getInfo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Employee temp in List_of_Employees.employeeList)
            {
                if (temp.phone == (searchphonetextbox.Text))
                {
                    EmployeeShowListbox.Items.Add(temp.getDetailedInformation());
                    using (System.IO.StreamWriter writer = System.IO.File.AppendText(@"F:\CSV\log.txt"))
                    {
                        writer.WriteLine(temp.getDetailedInformation() + DateTime.Now);
                    }
                    found = true;
                }

            }
            if (!found)
            {
                MessageBox.Show("ID Not Found");
                using (System.IO.StreamWriter writer = System.IO.File.AppendText(@"F:\CSV\log.txt"))
                {
                    writer.WriteLine(searchphonetextbox.Text + ": ID Not Found" + DateTime.Now);
                }
            }
        }
    }
}
