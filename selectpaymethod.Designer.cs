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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectpaymethod));
            this.bkslogobtn = new System.Windows.Forms.Button();
            this.selecttxt = new System.Windows.Forms.Label();
            this.selectmethodFormVISABtn = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bkslogobtn
            // 
            this.bkslogobtn.BackColor = System.Drawing.Color.Snow;
            this.bkslogobtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bkslogobtn.BackgroundImage")));
            this.bkslogobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bkslogobtn.Location = new System.Drawing.Point(163, 188);
            this.bkslogobtn.Name = "bkslogobtn";
            this.bkslogobtn.Size = new System.Drawing.Size(107, 72);
            this.bkslogobtn.TabIndex = 0;
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
            this.selectmethodFormVISABtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectmethodFormVISABtn.BackgroundImage")));
            this.selectmethodFormVISABtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectmethodFormVISABtn.Location = new System.Drawing.Point(407, 187);
            this.selectmethodFormVISABtn.Name = "selectmethodFormVISABtn";
            this.selectmethodFormVISABtn.Size = new System.Drawing.Size(107, 74);
            this.selectmethodFormVISABtn.TabIndex = 3;
            this.selectmethodFormVISABtn.UseVisualStyleBackColor = false;
            this.selectmethodFormVISABtn.Click += new System.EventHandler(this.selectmethodFormVISABtn_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Tomato;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(12, 387);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(78, 29);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // selectpaymethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
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
        private System.Windows.Forms.Button exitbutton;
    }
}