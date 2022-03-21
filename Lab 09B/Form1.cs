using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09B
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(enterIDtextbox.Text);
            string Name = enternametextbox.Text;
            string Type = entertypetextbox.Text;
            string Contact = entercontacttextbox.Text;
            string date_of_joining = (enterdatetextbox.Text);
            string leaves = enterleavestextbox.Text;

            Employee dummy_employee = new Employee();
            dummy_employee.ID = ID;
            dummy_employee.Name = Name;
            dummy_employee.type = Type;
            dummy_employee.contact = Contact;
            dummy_employee.date = date_of_joining;
            dummy_employee.leaves = leaves;
            if (dummy_employee.type == "Manager")
            {
                dummy_employee.salary = 10000 * 1.15;
            }
            if (dummy_employee.type == "Salesperson")
            {
                dummy_employee.salary = 10000 * 1.10;
            }
            if (dummy_employee.type == "Typewriter")
            {
                dummy_employee.salary = 10000 * 1.05;
            }
            employees.Add(dummy_employee);

            MessageBox.Show("Employee has been added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Employee dummy in employees)
            {
                if(Convert.ToInt32(editIDtextbox.Text) == dummy.ID)
                {
                    dummy.Name = editnametextbox.Text;
                    dummy.type = edittypetextbox.Text;
                    dummy.contact = editcontacttextbox.Text;
                    dummy.date = (editdatetextbox.Text);
                    dummy.leaves = editleavestextbox.Text;
                    MessageBox.Show("Employee Info has been edited");
                }
                else
                {
                    MessageBox.Show("No employee found");
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Employee dummy in employees)
            {
                listBox1.Items.Clear();
                if (dummy.ID == Convert.ToInt32(infoIDtextbox.Text))
                {
                    foreach (Employee employee in employees)
                    {
                        listBox1.Items.Add(employee.getInfo());
                    }
                }
                else
                {
                    MessageBox.Show("No employee found");
                }
            }  
        }
    }
}
