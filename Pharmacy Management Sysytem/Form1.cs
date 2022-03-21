using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pharmacy_Management_Sysytem
{
    public partial class Form1 : Form
    {
        public List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void quantitysoldtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentstockmedicinenametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string purchasemedicinename = purchasemedicinenametextbox.Text;
            int purchasemedicineprice = Convert.ToInt32(buyingpricetextbox.Text);
            int purchasemedicinequantity = Convert.ToInt32(purchasequantitytextbox.Text);
            int previousstock = Convert.ToInt32(Previousstocktextbox.Text);

            Medicine dummy_medicine = new Medicine();
            dummy_medicine.name = purchasemedicinename;
            dummy_medicine.price = purchasemedicineprice;
            dummy_medicine.quantity = purchasemedicinequantity;
            dummy_medicine.previous_stock = previousstock;
            dummy_medicine.add();
            medicines.Add(dummy_medicine);
            

            MessageBox.Show("Medicine has been added successfully!");
            
        }

        private void CurrentStockButton_Click(object sender, EventArgs e)
        {
            foreach (Medicine dummy in medicines)
            {
                if (dummy.name == (currentstockmedicinenametextbox.Text))
                {
                    CuurentStockListbox.Items.Clear();

                    for (int i = 0; i < medicines.Count; i++)
                    {
                        CuurentStockListbox.Items.Add(medicines[i].getInfo());
                    }
                }
                else
                {
                    MessageBox.Show("Medicine not available");
                }
            }

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            string purchasemedicinename = purchasemedicinenametextbox.Text;
            int purchasemedicineprice = Convert.ToInt32(buyingpricetextbox.Text);
            int purchasemedicinequantity = Convert.ToInt32(purchasequantitytextbox.Text);

            Medicine dummy_medicine = new Medicine();
            dummy_medicine.name = purchasemedicinename;
            dummy_medicine.price = purchasemedicineprice;
            dummy_medicine.quantity = purchasemedicinequantity;
            dummy_medicine.sell();
            medicines.Add(dummy_medicine);

            MessageBox.Show("Medicine has been sold successfully!");
        }

        private void CurrrentAccountBalanceButton_Click(object sender, EventArgs e)
        {

            
        }
    }
}
