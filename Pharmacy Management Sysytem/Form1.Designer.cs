namespace Pharmacy_Management_Sysytem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medicinenametextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eachmedicinepricetextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitysoldtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.purchasequantitytextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buyingpricetextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.purchasemedicinenametextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SellButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.currentstockmedicinenametextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentStockButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CurrrentAccountBalanceButton = new System.Windows.Forms.Button();
            this.CuurentStockListbox = new System.Windows.Forms.ListBox();
            this.accountbalancelabel = new System.Windows.Forms.Label();
            this.Previousstocktextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicines Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Name";
            // 
            // medicinenametextbox
            // 
            this.medicinenametextbox.Location = new System.Drawing.Point(205, 61);
            this.medicinenametextbox.Name = "medicinenametextbox";
            this.medicinenametextbox.Size = new System.Drawing.Size(199, 22);
            this.medicinenametextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price of each medicines";
            // 
            // eachmedicinepricetextbox
            // 
            this.eachmedicinepricetextbox.Location = new System.Drawing.Point(205, 103);
            this.eachmedicinepricetextbox.Name = "eachmedicinepricetextbox";
            this.eachmedicinepricetextbox.Size = new System.Drawing.Size(199, 22);
            this.eachmedicinepricetextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // quantitysoldtextbox
            // 
            this.quantitysoldtextbox.Location = new System.Drawing.Point(205, 143);
            this.quantitysoldtextbox.Name = "quantitysoldtextbox";
            this.quantitysoldtextbox.Size = new System.Drawing.Size(199, 22);
            this.quantitysoldtextbox.TabIndex = 6;
            this.quantitysoldtextbox.TextChanged += new System.EventHandler(this.quantitysoldtextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Medicine Purchase";
            // 
            // purchasequantitytextbox
            // 
            this.purchasequantitytextbox.Location = new System.Drawing.Point(205, 416);
            this.purchasequantitytextbox.Name = "purchasequantitytextbox";
            this.purchasequantitytextbox.Size = new System.Drawing.Size(199, 22);
            this.purchasequantitytextbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // buyingpricetextbox
            // 
            this.buyingpricetextbox.Location = new System.Drawing.Point(205, 376);
            this.buyingpricetextbox.Name = "buyingpricetextbox";
            this.buyingpricetextbox.Size = new System.Drawing.Size(199, 22);
            this.buyingpricetextbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Price of each medicines";
            // 
            // purchasemedicinenametextbox
            // 
            this.purchasemedicinenametextbox.Location = new System.Drawing.Point(205, 334);
            this.purchasemedicinenametextbox.Name = "purchasemedicinenametextbox";
            this.purchasemedicinenametextbox.Size = new System.Drawing.Size(199, 22);
            this.purchasemedicinenametextbox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Medicine Name";
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.Lime;
            this.SellButton.Location = new System.Drawing.Point(120, 189);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(134, 54);
            this.SellButton.TabIndex = 14;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuyButton.Location = new System.Drawing.Point(120, 499);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(134, 54);
            this.BuyButton.TabIndex = 15;
            this.BuyButton.Text = "Add";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // currentstockmedicinenametextbox
            // 
            this.currentstockmedicinenametextbox.Location = new System.Drawing.Point(587, 61);
            this.currentstockmedicinenametextbox.Name = "currentstockmedicinenametextbox";
            this.currentstockmedicinenametextbox.Size = new System.Drawing.Size(199, 22);
            this.currentstockmedicinenametextbox.TabIndex = 17;
            this.currentstockmedicinenametextbox.TextChanged += new System.EventHandler(this.currentstockmedicinenametextbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Medicine Name";
            // 
            // CurrentStockButton
            // 
            this.CurrentStockButton.BackColor = System.Drawing.Color.Lime;
            this.CurrentStockButton.Location = new System.Drawing.Point(557, 111);
            this.CurrentStockButton.Name = "CurrentStockButton";
            this.CurrentStockButton.Size = new System.Drawing.Size(134, 54);
            this.CurrentStockButton.TabIndex = 18;
            this.CurrentStockButton.Text = "Current stock";
            this.CurrentStockButton.UseVisualStyleBackColor = false;
            this.CurrentStockButton.Click += new System.EventHandler(this.CurrentStockButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(553, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Current Stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(483, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Current Account Balance";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // CurrrentAccountBalanceButton
            // 
            this.CurrrentAccountBalanceButton.BackColor = System.Drawing.Color.Lime;
            this.CurrrentAccountBalanceButton.Location = new System.Drawing.Point(557, 466);
            this.CurrrentAccountBalanceButton.Name = "CurrrentAccountBalanceButton";
            this.CurrrentAccountBalanceButton.Size = new System.Drawing.Size(134, 54);
            this.CurrrentAccountBalanceButton.TabIndex = 21;
            this.CurrrentAccountBalanceButton.Text = "Current Account Balance";
            this.CurrrentAccountBalanceButton.UseVisualStyleBackColor = false;
            this.CurrrentAccountBalanceButton.Click += new System.EventHandler(this.CurrrentAccountBalanceButton_Click);
            // 
            // CuurentStockListbox
            // 
            this.CuurentStockListbox.FormattingEnabled = true;
            this.CuurentStockListbox.ItemHeight = 16;
            this.CuurentStockListbox.Location = new System.Drawing.Point(458, 189);
            this.CuurentStockListbox.Name = "CuurentStockListbox";
            this.CuurentStockListbox.Size = new System.Drawing.Size(328, 180);
            this.CuurentStockListbox.TabIndex = 22;
            // 
            // accountbalancelabel
            // 
            this.accountbalancelabel.AutoSize = true;
            this.accountbalancelabel.Location = new System.Drawing.Point(618, 447);
            this.accountbalancelabel.Name = "accountbalancelabel";
            this.accountbalancelabel.Size = new System.Drawing.Size(0, 16);
            this.accountbalancelabel.TabIndex = 23;
            // 
            // Previousstocktextbox
            // 
            this.Previousstocktextbox.Location = new System.Drawing.Point(205, 457);
            this.Previousstocktextbox.Name = "Previousstocktextbox";
            this.Previousstocktextbox.Size = new System.Drawing.Size(199, 22);
            this.Previousstocktextbox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 460);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Previous Stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 565);
            this.Controls.Add(this.Previousstocktextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.accountbalancelabel);
            this.Controls.Add(this.CuurentStockListbox);
            this.Controls.Add(this.CurrrentAccountBalanceButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CurrentStockButton);
            this.Controls.Add(this.currentstockmedicinenametextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.purchasequantitytextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buyingpricetextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.purchasemedicinenametextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantitysoldtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eachmedicinepricetextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medicinenametextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicinenametextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eachmedicinepricetextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantitysoldtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox purchasequantitytextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buyingpricetextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox purchasemedicinenametextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox currentstockmedicinenametextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CurrentStockButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CurrrentAccountBalanceButton;
        private System.Windows.Forms.ListBox CuurentStockListbox;
        private System.Windows.Forms.Label accountbalancelabel;
        private System.Windows.Forms.TextBox Previousstocktextbox;
        private System.Windows.Forms.Label label12;
    }
}

