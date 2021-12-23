using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Owner> owners = new List<Owner>();
        List<Order> orders = new List<Order>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usersectioncreataccountbutton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDaccounttextbox.Text);
            string username = Usernameaccounttextbox.Text;
            string useraddress = Usernameaddresstextbox.Text;
            

            User dummy_user = new User();
            dummy_user.UserID = userID;
            dummy_user.Name = username;
            dummy_user.Address = useraddress;
            
            users.Add(dummy_user);

            MessageBox.Show("User has been added successfully!");
        }

        private void Placeorderbutton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDplaceordertextbox.Text);
            int shirt = Convert.ToInt32(Shirttextbox.Text);
            int pant = Convert.ToInt32(Panttextbox.Text);
            int suit = Convert.ToInt32(Suitstextbox.Text);
            int bedsheet = Convert.ToInt32(Bedsheettextbox.Text);

            Order dummy_order = new Order();
            dummy_order.user = new User();
            dummy_order.user.UserID = userID;
            dummy_order.shirt = shirt;
            dummy_order.pant = pant;
            dummy_order.suit = suit;
            dummy_order.bedsheet = bedsheet;
            dummy_order.orderID = orders.Count;

            orders.Add(dummy_order);
            foreach (Order dummy in orders) {
                if (dummy_order.user.UserID == Convert.ToInt32(UserIDplaceordertextbox.Text))
                {
                    int amount=0;
                    if(comboBox2.Text == "Wash")
                    {
                        amount += 5;

                    }
                    else if (comboBox2.Text == "Iron")
                    {
                        amount += 5;

                    }
                    else if (comboBox2.Text == "Both")
                    {
                        amount += 10;

                    }
                    if (comboBox3.Text == "Wash")
                    {
                        amount += 5;

                    }
                    else if (comboBox3.Text == "Iron")
                    {
                        amount += 5;

                    }
                    else if (comboBox3.Text == "Both")
                    {
                        amount += 10;

                    }
                    if (comboBox4.Text == "Wash")
                    {
                        amount += 5;

                    }
                    else if (comboBox4.Text == "Iron")
                    {
                        amount += 5;

                    }
                    else if (comboBox4.Text == "Both")
                    {
                        amount += 10;

                    }
                    if (comboBox5.Text == "Wash")
                    {
                        amount += 5;

                    }
                    else if (comboBox5.Text == "Iron")
                    {
                        amount += 5;

                    }
                    else if (comboBox5.Text == "Both")
                    {
                        amount += 10;

                    }
                    dummy_order.amount = amount;
                    MessageBox.Show("Order has been added succesfully and the amount is " + amount);
                }
                else
                {
                    MessageBox.Show("Order ID not found");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Order dummy in orders)
            {
                if (dummy.orderID == Convert.ToInt32(OrderIDchecktextbox.Text))
                {
                    Orderdetailslistbox.Items.Clear();
                    Statuslabel.Text = dummy.status;
                    Namelabel.Text = dummy.user.Name;
                    Addresslabel.Text = dummy.user.Address;
                    Amountlabel.Text = Convert.ToString(dummy.amount);
                    
                    
                        
                    foreach (Order order in orders)
                    {
                        Orderdetailslistbox.Items.Add(order.getInfo());
                    }
                       
                    
                    MessageBox.Show("Order has been added succesfully");
                }
                else
                {
                    MessageBox.Show("Order ID not found");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ownerssectionbutton_Click(object sender, EventArgs e)
        {
            foreach (Order dummy in orders)
            {
                if (dummy.orderID == Convert.ToInt32(Ownersectionoderidtextbox.Text))
                {
                    dummy.status = comboBox1.Text;
                    Ownerssectioncurrentbalancelabel.Text = Convert.ToString(dummy.amount);
                    MessageBox.Show("Order has been added succesfully");
                }
                else
                {
                    MessageBox.Show("Order ID not found");
                }
            }
        }
    }
}
