namespace US_Bangla_Airline_Management_App
{
    partial class selectpaymethod
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
            this.bkslogobtn = new System.Windows.Forms.Button();
            this.selecttxt = new System.Windows.Forms.Label();
            this.selectmethodFormVISABtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bkslogobtn
            // 
            this.bkslogobtn.BackColor = System.Drawing.Color.Snow;
            this.bkslogobtn.Location = new System.Drawing.Point(109, 188);
            this.bkslogobtn.Name = "bkslogobtn";
            this.bkslogobtn.Size = new System.Drawing.Size(210, 72);
            this.bkslogobtn.TabIndex = 0;
            this.bkslogobtn.Text = "Pay With BKASH";
            this.bkslogobtn.UseVisualStyleBackColor = false;
            this.bkslogobtn.Click += new System.EventHandler(this.bkslogobtn_Click);
            // 
            // selecttxt
            // 
            this.selecttxt.AutoSize = true;
            this.selecttxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selecttxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selecttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecttxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.selecttxt.Location = new System.Drawing.Point(97, 93);
            this.selecttxt.Name = "selecttxt";
            this.selecttxt.Size = new System.Drawing.Size(524, 38);
            this.selecttxt.TabIndex = 2;
            this.selecttxt.Text = "please select your payment method:";
            this.selecttxt.Click += new System.EventHandler(this.selecttxt_Click);
            // 
            // selectmethodFormVISABtn
            // 
            this.selectmethodFormVISABtn.BackColor = System.Drawing.Color.Snow;
            this.selectmethodFormVISABtn.Location = new System.Drawing.Point(396, 188);
            this.selectmethodFormVISABtn.Name = "selectmethodFormVISABtn";
            this.selectmethodFormVISABtn.Size = new System.Drawing.Size(181, 72);
            this.selectmethodFormVISABtn.TabIndex = 3;
            this.selectmethodFormVISABtn.Text = "Pay With VISA";
            this.selectmethodFormVISABtn.UseVisualStyleBackColor = false;
            this.selectmethodFormVISABtn.Click += new System.EventHandler(this.selectmethodFormVISABtn_Click);
            // 
            // selectpaymethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectmethodFormVISABtn);
            this.Controls.Add(this.selecttxt);
            this.Controls.Add(this.bkslogobtn);
            this.Name = "selectpaymethod";
            this.Text = "selectmethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bkslogobtn;
        private System.Windows.Forms.Label selecttxt;
        private System.Windows.Forms.Button selectmethodFormVISABtn;
    }
}