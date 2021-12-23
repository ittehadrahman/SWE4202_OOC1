namespace Laundry_Management_System
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
            this.Ownersectionoderidtextbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Ownerssectionbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ownerssectioncurrentbalancelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserIDaccounttextbox = new System.Windows.Forms.TextBox();
            this.Usernameaccounttextbox = new System.Windows.Forms.TextBox();
            this.Usernameaddresstextbox = new System.Windows.Forms.TextBox();
            this.Usersectioncreataccountbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIDplaceordertextbox = new System.Windows.Forms.TextBox();
            this.Shirttextbox = new System.Windows.Forms.TextBox();
            this.Panttextbox = new System.Windows.Forms.TextBox();
            this.Suitstextbox = new System.Windows.Forms.TextBox();
            this.Bedsheettextbox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Placeorderbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Orderdetailslistbox = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.OrderIDchecktextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner\'s Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID";
            // 
            // Ownersectionoderidtextbox
            // 
            this.Ownersectionoderidtextbox.Location = new System.Drawing.Point(75, 52);
            this.Ownersectionoderidtextbox.Name = "Ownersectionoderidtextbox";
            this.Ownersectionoderidtextbox.Size = new System.Drawing.Size(100, 22);
            this.Ownersectionoderidtextbox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Delivered"});
            this.comboBox1.Location = new System.Drawing.Point(181, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ownerssectionbutton
            // 
            this.Ownerssectionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownerssectionbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Ownerssectionbutton.Location = new System.Drawing.Point(308, 48);
            this.Ownerssectionbutton.Name = "Ownerssectionbutton";
            this.Ownerssectionbutton.Size = new System.Drawing.Size(118, 30);
            this.Ownerssectionbutton.TabIndex = 4;
            this.Ownerssectionbutton.Text = "Set Status";
            this.Ownerssectionbutton.UseVisualStyleBackColor = true;
            this.Ownerssectionbutton.Click += new System.EventHandler(this.Ownerssectionbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Balance:";
            // 
            // Ownerssectioncurrentbalancelabel
            // 
            this.Ownerssectioncurrentbalancelabel.AutoSize = true;
            this.Ownerssectioncurrentbalancelabel.Location = new System.Drawing.Point(142, 93);
            this.Ownerssectioncurrentbalancelabel.Name = "Ownerssectioncurrentbalancelabel";
            this.Ownerssectioncurrentbalancelabel.Size = new System.Drawing.Size(0, 16);
            this.Ownerssectioncurrentbalancelabel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(433, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 290);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";
            // 
            // UserIDaccounttextbox
            // 
            this.UserIDaccounttextbox.Location = new System.Drawing.Point(540, 53);
            this.UserIDaccounttextbox.Name = "UserIDaccounttextbox";
            this.UserIDaccounttextbox.Size = new System.Drawing.Size(155, 22);
            this.UserIDaccounttextbox.TabIndex = 12;
            // 
            // Usernameaccounttextbox
            // 
            this.Usernameaccounttextbox.Location = new System.Drawing.Point(540, 90);
            this.Usernameaccounttextbox.Name = "Usernameaccounttextbox";
            this.Usernameaccounttextbox.Size = new System.Drawing.Size(155, 22);
            this.Usernameaccounttextbox.TabIndex = 13;
            // 
            // Usernameaddresstextbox
            // 
            this.Usernameaddresstextbox.Location = new System.Drawing.Point(540, 129);
            this.Usernameaddresstextbox.Name = "Usernameaddresstextbox";
            this.Usernameaddresstextbox.Size = new System.Drawing.Size(155, 22);
            this.Usernameaddresstextbox.TabIndex = 14;
            // 
            // Usersectioncreataccountbutton
            // 
            this.Usersectioncreataccountbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersectioncreataccountbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Usersectioncreataccountbutton.Location = new System.Drawing.Point(739, 56);
            this.Usersectioncreataccountbutton.Name = "Usersectioncreataccountbutton";
            this.Usersectioncreataccountbutton.Size = new System.Drawing.Size(116, 82);
            this.Usersectioncreataccountbutton.TabIndex = 15;
            this.Usersectioncreataccountbutton.Text = "Create Account";
            this.Usersectioncreataccountbutton.UseVisualStyleBackColor = true;
            this.Usersectioncreataccountbutton.Click += new System.EventHandler(this.Usersectioncreataccountbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(889, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "User ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(889, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Shirt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(889, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bed-Sheet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Suits";
            // 
            // UserIDplaceordertextbox
            // 
            this.UserIDplaceordertextbox.Location = new System.Drawing.Point(985, 52);
            this.UserIDplaceordertextbox.Name = "UserIDplaceordertextbox";
            this.UserIDplaceordertextbox.Size = new System.Drawing.Size(140, 22);
            this.UserIDplaceordertextbox.TabIndex = 20;
            // 
            // Shirttextbox
            // 
            this.Shirttextbox.Location = new System.Drawing.Point(985, 90);
            this.Shirttextbox.Name = "Shirttextbox";
            this.Shirttextbox.Size = new System.Drawing.Size(140, 22);
            this.Shirttextbox.TabIndex = 21;
            // 
            // Panttextbox
            // 
            this.Panttextbox.Location = new System.Drawing.Point(985, 129);
            this.Panttextbox.Name = "Panttextbox";
            this.Panttextbox.Size = new System.Drawing.Size(140, 22);
            this.Panttextbox.TabIndex = 22;
            // 
            // Suitstextbox
            // 
            this.Suitstextbox.Location = new System.Drawing.Point(985, 169);
            this.Suitstextbox.Name = "Suitstextbox";
            this.Suitstextbox.Size = new System.Drawing.Size(140, 22);
            this.Suitstextbox.TabIndex = 23;
            // 
            // Bedsheettextbox
            // 
            this.Bedsheettextbox.Location = new System.Drawing.Point(985, 207);
            this.Bedsheettextbox.Name = "Bedsheettextbox";
            this.Bedsheettextbox.Size = new System.Drawing.Size(140, 22);
            this.Bedsheettextbox.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Iron",
            "Wash",
            "Both"});
            this.comboBox2.Location = new System.Drawing.Point(1153, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Iron",
            "Wash",
            "Both"});
            this.comboBox3.Location = new System.Drawing.Point(1153, 127);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 26;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Iron",
            "Wash",
            "Both"});
            this.comboBox4.Location = new System.Drawing.Point(1153, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 27;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Iron",
            "Wash",
            "Both"});
            this.comboBox5.Location = new System.Drawing.Point(1153, 205);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 28;
            // 
            // Placeorderbutton
            // 
            this.Placeorderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placeorderbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Placeorderbutton.Location = new System.Drawing.Point(892, 251);
            this.Placeorderbutton.Name = "Placeorderbutton";
            this.Placeorderbutton.Size = new System.Drawing.Size(382, 34);
            this.Placeorderbutton.TabIndex = 29;
            this.Placeorderbutton.Text = "Place Order";
            this.Placeorderbutton.UseVisualStyleBackColor = true;
            this.Placeorderbutton.Click += new System.EventHandler(this.Placeorderbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(12, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 11);
            this.panel2.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Order ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(230, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(227, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Amount:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(230, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 116);
            this.button1.TabIndex = 33;
            this.button1.Text = "See Order Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Orderdetailslistbox
            // 
            this.Orderdetailslistbox.FormattingEnabled = true;
            this.Orderdetailslistbox.ItemHeight = 16;
            this.Orderdetailslistbox.Location = new System.Drawing.Point(433, 319);
            this.Orderdetailslistbox.Name = "Orderdetailslistbox";
            this.Orderdetailslistbox.Size = new System.Drawing.Size(439, 244);
            this.Orderdetailslistbox.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(898, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(898, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Address:";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(310, 366);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(0, 16);
            this.Statuslabel.TabIndex = 37;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Location = new System.Drawing.Point(310, 403);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(0, 16);
            this.Amountlabel.TabIndex = 38;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(975, 366);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(0, 16);
            this.Namelabel.TabIndex = 39;
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Location = new System.Drawing.Point(975, 403);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(0, 16);
            this.Addresslabel.TabIndex = 40;
            // 
            // OrderIDchecktextbox
            // 
            this.OrderIDchecktextbox.Location = new System.Drawing.Point(308, 326);
            this.OrderIDchecktextbox.Name = "OrderIDchecktextbox";
            this.OrderIDchecktextbox.Size = new System.Drawing.Size(100, 22);
            this.OrderIDchecktextbox.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 575);
            this.Controls.Add(this.OrderIDchecktextbox);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Orderdetailslistbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Placeorderbutton);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Bedsheettextbox);
            this.Controls.Add(this.Suitstextbox);
            this.Controls.Add(this.Panttextbox);
            this.Controls.Add(this.Shirttextbox);
            this.Controls.Add(this.UserIDplaceordertextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Usersectioncreataccountbutton);
            this.Controls.Add(this.Usernameaddresstextbox);
            this.Controls.Add(this.Usernameaccounttextbox);
            this.Controls.Add(this.UserIDaccounttextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ownerssectioncurrentbalancelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ownerssectionbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Ownersectionoderidtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ownersectionoderidtextbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Ownerssectionbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ownerssectioncurrentbalancelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserIDaccounttextbox;
        private System.Windows.Forms.TextBox Usernameaccounttextbox;
        private System.Windows.Forms.TextBox Usernameaddresstextbox;
        private System.Windows.Forms.Button Usersectioncreataccountbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserIDplaceordertextbox;
        private System.Windows.Forms.TextBox Shirttextbox;
        private System.Windows.Forms.TextBox Panttextbox;
        private System.Windows.Forms.TextBox Suitstextbox;
        private System.Windows.Forms.TextBox Bedsheettextbox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button Placeorderbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Orderdetailslistbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.TextBox OrderIDchecktextbox;
    }
}

