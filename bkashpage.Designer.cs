namespace US_Bangla_Airline_Management_App
{
    partial class bkashpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bkashpage));
            this.nmbrtxt = new System.Windows.Forms.Label();
            this.numbertxtbox = new System.Windows.Forms.TextBox();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.pintxtbox = new System.Windows.Forms.TextBox();
            this.pintxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nmbrtxt
            // 
            this.nmbrtxt.AutoSize = true;
            this.nmbrtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(109)))));
            this.nmbrtxt.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbrtxt.Location = new System.Drawing.Point(261, 234);
            this.nmbrtxt.Name = "nmbrtxt";
            this.nmbrtxt.Size = new System.Drawing.Size(200, 20);
            this.nmbrtxt.TabIndex = 0;
            this.nmbrtxt.Text = "Your bKash account number";
            this.nmbrtxt.Click += new System.EventHandler(this.nmbrtxt_Click_1);
            // 
            // numbertxtbox
            // 
            this.numbertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbertxtbox.Location = new System.Drawing.Point(261, 257);
            this.numbertxtbox.Name = "numbertxtbox";
            this.numbertxtbox.Size = new System.Drawing.Size(196, 27);
            this.numbertxtbox.TabIndex = 1;
            this.numbertxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbertxtbox.TextChanged += new System.EventHandler(this.numbertxtbox_TextChanged);
            // 
            // proceedbtn
            // 
            this.proceedbtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.proceedbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proceedbtn.Location = new System.Drawing.Point(252, 376);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(102, 31);
            this.proceedbtn.TabIndex = 2;
            this.proceedbtn.Text = "PROCEED";
            this.proceedbtn.UseVisualStyleBackColor = false;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.closebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closebtn.Location = new System.Drawing.Point(394, 376);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(102, 31);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // pintxtbox
            // 
            this.pintxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintxtbox.Location = new System.Drawing.Point(261, 310);
            this.pintxtbox.Name = "pintxtbox";
            this.pintxtbox.PasswordChar = '*';
            this.pintxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pintxtbox.Size = new System.Drawing.Size(196, 27);
            this.pintxtbox.TabIndex = 4;
            this.pintxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pintxtbox.TextChanged += new System.EventHandler(this.pintxtbox_TextChanged);
            // 
            // pintxt
            // 
            this.pintxt.AutoSize = true;
            this.pintxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(109)))));
            this.pintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintxt.Location = new System.Drawing.Point(261, 287);
            this.pintxt.Name = "pintxt";
            this.pintxt.Size = new System.Drawing.Size(113, 20);
            this.pintxt.TabIndex = 5;
            this.pintxt.Text = "Enter your pin";
            this.pintxt.Click += new System.EventHandler(this.pintxt_Click_1);
            // 
            // bkashpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            //this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 561);
            this.Controls.Add(this.pintxt);
            this.Controls.Add(this.pintxtbox);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.proceedbtn);
            this.Controls.Add(this.numbertxtbox);
            this.Controls.Add(this.nmbrtxt);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "bkashpage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "bkashpage";
            this.Load += new System.EventHandler(this.bkashname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nmbrtxt;
        private System.Windows.Forms.TextBox numbertxtbox;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.TextBox pintxtbox;
        private System.Windows.Forms.Label pintxt;
    }
}