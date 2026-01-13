
namespace US_Bangla_Airline_Management_App
{
    partial class AdminProfileForm
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
            this.AdminProfileIDTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminProfileUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminProfilePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminProfileRoleCmbBox = new System.Windows.Forms.ComboBox();
            this.AdminProfileUpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // AdminProfileIDTxtBox
            // 
            this.AdminProfileIDTxtBox.Location = new System.Drawing.Point(207, 54);
            this.AdminProfileIDTxtBox.Name = "AdminProfileIDTxtBox";
            this.AdminProfileIDTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AdminProfileIDTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // AdminProfileUserNameTxtBox
            // 
            this.AdminProfileUserNameTxtBox.Location = new System.Drawing.Point(207, 99);
            this.AdminProfileUserNameTxtBox.Name = "AdminProfileUserNameTxtBox";
            this.AdminProfileUserNameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AdminProfileUserNameTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // AdminProfilePasswordTxtBox
            // 
            this.AdminProfilePasswordTxtBox.Location = new System.Drawing.Point(207, 149);
            this.AdminProfilePasswordTxtBox.Name = "AdminProfilePasswordTxtBox";
            this.AdminProfilePasswordTxtBox.Size = new System.Drawing.Size(100, 22);
            this.AdminProfilePasswordTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role:";
            // 
            // AdminProfileRoleCmbBox
            // 
            this.AdminProfileRoleCmbBox.FormattingEnabled = true;
            this.AdminProfileRoleCmbBox.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Counter Staff"});
            this.AdminProfileRoleCmbBox.Location = new System.Drawing.Point(198, 194);
            this.AdminProfileRoleCmbBox.Name = "AdminProfileRoleCmbBox";
            this.AdminProfileRoleCmbBox.Size = new System.Drawing.Size(121, 24);
            this.AdminProfileRoleCmbBox.TabIndex = 7;
            // 
            // AdminProfileUpdateBtn
            // 
            this.AdminProfileUpdateBtn.Location = new System.Drawing.Point(207, 308);
            this.AdminProfileUpdateBtn.Name = "AdminProfileUpdateBtn";
            this.AdminProfileUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.AdminProfileUpdateBtn.TabIndex = 8;
            this.AdminProfileUpdateBtn.Text = "Update Profile";
            this.AdminProfileUpdateBtn.UseVisualStyleBackColor = true;
            this.AdminProfileUpdateBtn.Click += new System.EventHandler(this.AdminProfileUpdateBtn_Click);
            // 
            // AdminProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminProfileUpdateBtn);
            this.Controls.Add(this.AdminProfileRoleCmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdminProfilePasswordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminProfileUserNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminProfileIDTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminProfileForm";
            this.Text = "AdminProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminProfileIDTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminProfileUserNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminProfilePasswordTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdminProfileRoleCmbBox;
        private System.Windows.Forms.Button AdminProfileUpdateBtn;
    }
}