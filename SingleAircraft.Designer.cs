
namespace US_Bangla_Airline_Management_App
{
    partial class SingleAircraft
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SingleAircraftFormAircraftNoTxtBox = new System.Windows.Forms.TextBox();
            this.SingleAircraftFormAircraftModelTxtBox = new System.Windows.Forms.TextBox();
            this.SingleAircraftFormManufactuerTxtBox = new System.Windows.Forms.TextBox();
            this.SingleAircraftFormCapacityTxtBox = new System.Windows.Forms.TextBox();
            this.SingleAircraftFormUpdateBtn = new System.Windows.Forms.Button();
            this.SingleAircraftFormBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aircraft No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aircraft Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity";
            // 
            // SingleAircraftFormAircraftNoTxtBox
            // 
            this.SingleAircraftFormAircraftNoTxtBox.Location = new System.Drawing.Point(199, 54);
            this.SingleAircraftFormAircraftNoTxtBox.Name = "SingleAircraftFormAircraftNoTxtBox";
            this.SingleAircraftFormAircraftNoTxtBox.Size = new System.Drawing.Size(100, 22);
            this.SingleAircraftFormAircraftNoTxtBox.TabIndex = 4;
            // 
            // SingleAircraftFormAircraftModelTxtBox
            // 
            this.SingleAircraftFormAircraftModelTxtBox.Location = new System.Drawing.Point(183, 99);
            this.SingleAircraftFormAircraftModelTxtBox.Name = "SingleAircraftFormAircraftModelTxtBox";
            this.SingleAircraftFormAircraftModelTxtBox.Size = new System.Drawing.Size(100, 22);
            this.SingleAircraftFormAircraftModelTxtBox.TabIndex = 5;
            // 
            // SingleAircraftFormManufactuerTxtBox
            // 
            this.SingleAircraftFormManufactuerTxtBox.Location = new System.Drawing.Point(214, 150);
            this.SingleAircraftFormManufactuerTxtBox.Name = "SingleAircraftFormManufactuerTxtBox";
            this.SingleAircraftFormManufactuerTxtBox.Size = new System.Drawing.Size(100, 22);
            this.SingleAircraftFormManufactuerTxtBox.TabIndex = 6;
            // 
            // SingleAircraftFormCapacityTxtBox
            // 
            this.SingleAircraftFormCapacityTxtBox.Location = new System.Drawing.Point(223, 191);
            this.SingleAircraftFormCapacityTxtBox.Name = "SingleAircraftFormCapacityTxtBox";
            this.SingleAircraftFormCapacityTxtBox.Size = new System.Drawing.Size(100, 22);
            this.SingleAircraftFormCapacityTxtBox.TabIndex = 7;
            // 
            // SingleAircraftFormUpdateBtn
            // 
            this.SingleAircraftFormUpdateBtn.Location = new System.Drawing.Point(80, 265);
            this.SingleAircraftFormUpdateBtn.Name = "SingleAircraftFormUpdateBtn";
            this.SingleAircraftFormUpdateBtn.Size = new System.Drawing.Size(92, 32);
            this.SingleAircraftFormUpdateBtn.TabIndex = 8;
            this.SingleAircraftFormUpdateBtn.Text = "Update";
            this.SingleAircraftFormUpdateBtn.UseVisualStyleBackColor = true;
            this.SingleAircraftFormUpdateBtn.Click += new System.EventHandler(this.SingleAircraftFormUpdateBtn_Click);
            // 
            // SingleAircraftFormBackBtn
            // 
            this.SingleAircraftFormBackBtn.Location = new System.Drawing.Point(269, 265);
            this.SingleAircraftFormBackBtn.Name = "SingleAircraftFormBackBtn";
            this.SingleAircraftFormBackBtn.Size = new System.Drawing.Size(78, 32);
            this.SingleAircraftFormBackBtn.TabIndex = 9;
            this.SingleAircraftFormBackBtn.Text = "Back";
            this.SingleAircraftFormBackBtn.UseVisualStyleBackColor = true;
            this.SingleAircraftFormBackBtn.Click += new System.EventHandler(this.SingleAircraftFormBackBtn_Click);
            // 
            // SingleAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SingleAircraftFormBackBtn);
            this.Controls.Add(this.SingleAircraftFormUpdateBtn);
            this.Controls.Add(this.SingleAircraftFormCapacityTxtBox);
            this.Controls.Add(this.SingleAircraftFormManufactuerTxtBox);
            this.Controls.Add(this.SingleAircraftFormAircraftModelTxtBox);
            this.Controls.Add(this.SingleAircraftFormAircraftNoTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SingleAircraft";
            this.Text = "SingleAircraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SingleAircraftFormAircraftNoTxtBox;
        private System.Windows.Forms.TextBox SingleAircraftFormAircraftModelTxtBox;
        private System.Windows.Forms.TextBox SingleAircraftFormManufactuerTxtBox;
        private System.Windows.Forms.TextBox SingleAircraftFormCapacityTxtBox;
        private System.Windows.Forms.Button SingleAircraftFormUpdateBtn;
        private System.Windows.Forms.Button SingleAircraftFormBackBtn;
    }
}