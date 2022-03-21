namespace TicTacToe
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
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.OpponentLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Movecombobox = new System.Windows.Forms.ComboBox();
            this.Markercombobox = new System.Windows.Forms.ComboBox();
            this.Opponentcombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(57, 213);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 61);
            this.button11.TabIndex = 4;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button5_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(134, 213);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 61);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(213, 213);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 61);
            this.button13.TabIndex = 6;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(57, 289);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 61);
            this.button21.TabIndex = 7;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(134, 289);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 61);
            this.button22.TabIndex = 8;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic Tac Toe";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(213, 289);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 61);
            this.button23.TabIndex = 10;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(57, 366);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(60, 61);
            this.button31.TabIndex = 11;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose your marker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(19, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Play Against:";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(134, 366);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(60, 61);
            this.button32.TabIndex = 15;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(213, 366);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(60, 61);
            this.button33.TabIndex = 16;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(338, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(338, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Opponent:";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(422, 52);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(0, 16);
            this.Player1Label.TabIndex = 19;
            // 
            // OpponentLabel
            // 
            this.OpponentLabel.AutoSize = true;
            this.OpponentLabel.Location = new System.Drawing.Point(422, 85);
            this.OpponentLabel.Name = "OpponentLabel";
            this.OpponentLabel.Size = new System.Drawing.Size(0, 16);
            this.OpponentLabel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(21, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Move first?";
            // 
            // Movecombobox
            // 
            this.Movecombobox.FormattingEnabled = true;
            this.Movecombobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Movecombobox.Location = new System.Drawing.Point(157, 66);
            this.Movecombobox.Name = "Movecombobox";
            this.Movecombobox.Size = new System.Drawing.Size(121, 24);
            this.Movecombobox.TabIndex = 22;
            // 
            // Markercombobox
            // 
            this.Markercombobox.FormattingEnabled = true;
            this.Markercombobox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.Markercombobox.Location = new System.Drawing.Point(157, 107);
            this.Markercombobox.Name = "Markercombobox";
            this.Markercombobox.Size = new System.Drawing.Size(121, 24);
            this.Markercombobox.TabIndex = 23;
            // 
            // Opponentcombobox
            // 
            this.Opponentcombobox.FormattingEnabled = true;
            this.Opponentcombobox.Items.AddRange(new object[] {
            "Computer",
            "Defensive AI"});
            this.Opponentcombobox.Location = new System.Drawing.Point(157, 152);
            this.Opponentcombobox.Name = "Opponentcombobox";
            this.Opponentcombobox.Size = new System.Drawing.Size(121, 24);
            this.Opponentcombobox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.Opponentcombobox);
            this.Controls.Add(this.Markercombobox);
            this.Controls.Add(this.Movecombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OpponentLabel);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label OpponentLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Movecombobox;
        private System.Windows.Forms.ComboBox Markercombobox;
        private System.Windows.Forms.ComboBox Opponentcombobox;
    }
}

