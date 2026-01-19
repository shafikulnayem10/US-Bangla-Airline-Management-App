
namespace US_Bangla_Airline_Management_App
{
    partial class visa
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
            this.cardnmbrtxt = new System.Windows.Forms.Label();
            this.cardnmbrtxtbox = new System.Windows.Forms.TextBox();
            this.holdernametxtbox = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.Label();
            this.MMtxt = new System.Windows.Forms.Label();
            this.YYtxt = new System.Windows.Forms.Label();
            this.cvvtxt = new System.Windows.Forms.Label();
            this.cvvtextBox = new System.Windows.Forms.TextBox();
            this.MMcomboBox = new System.Windows.Forms.ComboBox();
            this.yycomboBox = new System.Windows.Forms.ComboBox();
            this.addcardtxt = new System.Windows.Forms.Label();
            this.paynowbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardnmbrtxt
            // 
            this.cardnmbrtxt.AutoSize = true;
            this.cardnmbrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnmbrtxt.Location = new System.Drawing.Point(62, 88);
            this.cardnmbrtxt.Name = "cardnmbrtxt";
            this.cardnmbrtxt.Size = new System.Drawing.Size(102, 18);
            this.cardnmbrtxt.TabIndex = 0;
            this.cardnmbrtxt.Text = "Card numbers";
            // 
            // cardnmbrtxtbox
            // 
            this.cardnmbrtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnmbrtxtbox.Location = new System.Drawing.Point(65, 124);
            this.cardnmbrtxtbox.Name = "cardnmbrtxtbox";
            this.cardnmbrtxtbox.Size = new System.Drawing.Size(252, 24);
            this.cardnmbrtxtbox.TabIndex = 1;
            this.cardnmbrtxtbox.TextChanged += new System.EventHandler(this.cardnmbrtxtbox_TextChanged);
            // 
            // holdernametxtbox
            // 
            this.holdernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdernametxtbox.Location = new System.Drawing.Point(417, 124);
            this.holdernametxtbox.Name = "holdernametxtbox";
            this.holdernametxtbox.Size = new System.Drawing.Size(252, 24);
            this.holdernametxtbox.TabIndex = 2;
            this.holdernametxtbox.TextChanged += new System.EventHandler(this.holdernametxtbox_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(414, 88);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(122, 18);
            this.nametxt.TabIndex = 3;
            this.nametxt.Text = "Cardholder name";
            // 
            // MMtxt
            // 
            this.MMtxt.AutoSize = true;
            this.MMtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMtxt.Location = new System.Drawing.Point(62, 170);
            this.MMtxt.Name = "MMtxt";
            this.MMtxt.Size = new System.Drawing.Size(34, 18);
            this.MMtxt.TabIndex = 4;
            this.MMtxt.Text = "MM";
            // 
            // YYtxt
            // 
            this.YYtxt.AutoSize = true;
            this.YYtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YYtxt.Location = new System.Drawing.Point(227, 170);
            this.YYtxt.Name = "YYtxt";
            this.YYtxt.Size = new System.Drawing.Size(26, 18);
            this.YYtxt.TabIndex = 5;
            this.YYtxt.Text = "YY";
            // 
            // cvvtxt
            // 
            this.cvvtxt.AutoSize = true;
            this.cvvtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvtxt.Location = new System.Drawing.Point(414, 170);
            this.cvvtxt.Name = "cvvtxt";
            this.cvvtxt.Size = new System.Drawing.Size(37, 18);
            this.cvvtxt.TabIndex = 6;
            this.cvvtxt.Text = "CVV";
            // 
            // cvvtextBox
            // 
            this.cvvtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvtextBox.Location = new System.Drawing.Point(417, 206);
            this.cvvtextBox.Name = "cvvtextBox";
            this.cvvtextBox.Size = new System.Drawing.Size(252, 24);
            this.cvvtextBox.TabIndex = 7;
            this.cvvtextBox.TextChanged += new System.EventHandler(this.cvvtextBox_TextChanged);
            // 
            // MMcomboBox
            // 
            this.MMcomboBox.FormattingEnabled = true;
            this.MMcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MMcomboBox.Location = new System.Drawing.Point(65, 208);
            this.MMcomboBox.Name = "MMcomboBox";
            this.MMcomboBox.Size = new System.Drawing.Size(121, 24);
            this.MMcomboBox.TabIndex = 8;
            // 
            // yycomboBox
            // 
            this.yycomboBox.FormattingEnabled = true;
            this.yycomboBox.Items.AddRange(new object[] {
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.yycomboBox.Location = new System.Drawing.Point(230, 208);
            this.yycomboBox.Name = "yycomboBox";
            this.yycomboBox.Size = new System.Drawing.Size(121, 24);
            this.yycomboBox.TabIndex = 9;
            this.yycomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // addcardtxt
            // 
            this.addcardtxt.AutoSize = true;
            this.addcardtxt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addcardtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcardtxt.Location = new System.Drawing.Point(59, 27);
            this.addcardtxt.Name = "addcardtxt";
            this.addcardtxt.Size = new System.Drawing.Size(138, 29);
            this.addcardtxt.TabIndex = 10;
            this.addcardtxt.Text = "Add a card";
            // 
            // paynowbtn
            // 
            this.paynowbtn.BackColor = System.Drawing.Color.GreenYellow;
            this.paynowbtn.Location = new System.Drawing.Point(334, 275);
            this.paynowbtn.Name = "paynowbtn";
            this.paynowbtn.Size = new System.Drawing.Size(95, 43);
            this.paynowbtn.TabIndex = 11;
            this.paynowbtn.Text = "pay now";
            this.paynowbtn.UseVisualStyleBackColor = false;
            this.paynowbtn.Click += new System.EventHandler(this.paynowbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Exitbtn.Location = new System.Drawing.Point(30, 374);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(85, 33);
            this.Exitbtn.TabIndex = 12;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // visa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.paynowbtn);
            this.Controls.Add(this.addcardtxt);
            this.Controls.Add(this.yycomboBox);
            this.Controls.Add(this.MMcomboBox);
            this.Controls.Add(this.cvvtextBox);
            this.Controls.Add(this.cvvtxt);
            this.Controls.Add(this.YYtxt);
            this.Controls.Add(this.MMtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.holdernametxtbox);
            this.Controls.Add(this.cardnmbrtxtbox);
            this.Controls.Add(this.cardnmbrtxt);
            this.Name = "visa";
            this.Text = "visapage";
            this.Load += new System.EventHandler(this.visa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardnmbrtxt;
        private System.Windows.Forms.TextBox cardnmbrtxtbox;
        private System.Windows.Forms.TextBox holdernametxtbox;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label MMtxt;
        private System.Windows.Forms.Label YYtxt;
        private System.Windows.Forms.Label cvvtxt;
        private System.Windows.Forms.TextBox cvvtextBox;
        private System.Windows.Forms.ComboBox MMcomboBox;
        private System.Windows.Forms.ComboBox yycomboBox;
        private System.Windows.Forms.Label addcardtxt;
        private System.Windows.Forms.Button paynowbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}