using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_System_Dependencies;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string purchasemedicinename = purchasemedicinenametextbox.Text;
            int purchasepriceofeachmedicine = Convert.ToInt32(buyingpricetextbox.Text);
            int purchasequantity = Convert.ToInt32(purchasequantitytextbox.Text);               
                
            Medicine dummy_medicine = new Medicine();
            dummy_medicine.name = purchasemedicinename;
            dummy_medicine.price_of_each_medicine = purchasepriceofeachmedicine;
            dummy_medicine.quantity = purchasequantity;
            dummy_medicine.previous_stock = Convert.ToInt32(Previousstocktextbox.Text);
            dummy_medicine.add();
            medicines.Add(dummy_medicine);
            MessageBox.Show("Medicine has been added succesfully!");
                   
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            foreach (Medicine dummy in medicines)
            {
                if(dummy.name == medicinenametextbox.Text)
                {
                    dummy.quantity = Convert.ToInt32(quantitysoldtextbox.Text);
                    if (dummy.quantity <= dummy.previous_stock)
                    {
                        dummy.sell();
                        //MessageBox.Show("Qty" + Convert.ToString(dummy.previous_stock));
                        MessageBox.Show(dummy.name + " have been sold succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("There is not sufficient " + dummy.name + " in stock for sale!");
                    }

                }
                else
                {
                    MessageBox.Show("Medicine not found!");
                }
            }
        }

        private void CurrentStockButton_Click(object sender, EventArgs e)
        {
            CuurentStockListbox.Items.Clear();
            foreach (Medicine dummy in medicines)
            {
                if(dummy.name == currentstockmedicinenametextbox.Text)
                {

                    for (int i = 0; i < medicines.Count; i++)
                    {                     
                        CuurentStockListbox.Items.Add(medicines[i].getInfo());
                    }
                }
                else
                {
                    MessageBox.Show("Medicine not found!");
                }
            }
        }

        private void CurrrentAccountBalanceButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Account Balance:"+ Convert.ToString(Medicine.account_balance));
        }
    }
}
