
namespace US_Bangla_Airline_Management_App
{
    partial class AddAircraft
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
            this.Manu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAircraftFormAircraftNoTxtBox = new System.Windows.Forms.TextBox();
            this.AddAircraftFormAircraftModelTxtBox = new System.Windows.Forms.TextBox();
            this.AddAircraftFormManufacturerTxtBox = new System.Windows.Forms.TextBox();
            this.AddAircraftFormCapacityTxtBox = new System.Windows.Forms.TextBox();
            this.AddAircraftFormADDBtn = new System.Windows.Forms.Button();
            this.AddAircraftFormBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aircarft No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aircraft Model:";
            // 
            // Manu
            // 
            this.Manu.AutoSize = true;
            this.Manu.Location = new System.Drawing.Point(87, 130);
            this.Manu.Name = "Manu";
            this.Manu.Size = new System.Drawing.Size(96, 17);
            this.Manu.TabIndex = 2;
            this.Manu.Text = "Manufacturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity:";
            // 
            // AddAircraftFormAircraftNoTxtBox
            // 
            this.AddAircraftFormAircraftNoTxtBox.Location = new System.Drawing.Point(260, 57);
            this.AddAircraftFormAircraftNoTxtBox.Name = "AddAircraftFormAircraftNoTxtBox";
            this.AddAircraftFormAircraftNoTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AddAircraftFormAircraftNoTxtBox.TabIndex = 4;
            // 
            // AddAircraftFormAircraftModelTxtBox
            // 
            this.AddAircraftFormAircraftModelTxtBox.Location = new System.Drawing.Point(251, 96);
            this.AddAircraftFormAircraftModelTxtBox.Name = "AddAircraftFormAircraftModelTxtBox";
            this.AddAircraftFormAircraftModelTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AddAircraftFormAircraftModelTxtBox.TabIndex = 5;
            // 
            // AddAircraftFormManufacturerTxtBox
            // 
            this.AddAircraftFormManufacturerTxtBox.Location = new System.Drawing.Point(251, 130);
            this.AddAircraftFormManufacturerTxtBox.Name = "AddAircraftFormManufacturerTxtBox";
            this.AddAircraftFormManufacturerTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AddAircraftFormManufacturerTxtBox.TabIndex = 6;
            // 
            // AddAircraftFormCapacityTxtBox
            // 
            this.AddAircraftFormCapacityTxtBox.Location = new System.Drawing.Point(251, 160);
            this.AddAircraftFormCapacityTxtBox.Name = "AddAircraftFormCapacityTxtBox";
            this.AddAircraftFormCapacityTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AddAircraftFormCapacityTxtBox.TabIndex = 7;
            // 
            // AddAircraftFormADDBtn
            // 
            this.AddAircraftFormADDBtn.Location = new System.Drawing.Point(173, 217);
            this.AddAircraftFormADDBtn.Name = "AddAircraftFormADDBtn";
            this.AddAircraftFormADDBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAircraftFormADDBtn.TabIndex = 8;
            this.AddAircraftFormADDBtn.Text = "ADD";
            this.AddAircraftFormADDBtn.UseVisualStyleBackColor = true;
            this.AddAircraftFormADDBtn.Click += new System.EventHandler(this.AddAircraftFormADDBtn_Click);
            // 
            // AddAircraftFormBackBtn
            // 
            this.AddAircraftFormBackBtn.Location = new System.Drawing.Point(354, 217);
            this.AddAircraftFormBackBtn.Name = "AddAircraftFormBackBtn";
            this.AddAircraftFormBackBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAircraftFormBackBtn.TabIndex = 9;
            this.AddAircraftFormBackBtn.Text = "Back";
            this.AddAircraftFormBackBtn.UseVisualStyleBackColor = true;
            this.AddAircraftFormBackBtn.Click += new System.EventHandler(this.AddAircraftFormBackBtn_Click);
            // 
            // AddAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAircraftFormBackBtn);
            this.Controls.Add(this.AddAircraftFormADDBtn);
            this.Controls.Add(this.AddAircraftFormCapacityTxtBox);
            this.Controls.Add(this.AddAircraftFormManufacturerTxtBox);
            this.Controls.Add(this.AddAircraftFormAircraftModelTxtBox);
            this.Controls.Add(this.AddAircraftFormAircraftNoTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Manu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAircraft";
            this.Text = "AddAircraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Manu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddAircraftFormAircraftNoTxtBox;
        private System.Windows.Forms.TextBox AddAircraftFormAircraftModelTxtBox;
        private System.Windows.Forms.TextBox AddAircraftFormManufacturerTxtBox;
        private System.Windows.Forms.TextBox AddAircraftFormCapacityTxtBox;
        private System.Windows.Forms.Button AddAircraftFormADDBtn;
        private System.Windows.Forms.Button AddAircraftFormBackBtn;
    }
}