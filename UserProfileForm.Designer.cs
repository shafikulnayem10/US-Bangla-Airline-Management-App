namespace US_Bangla_Airline_Management_App
{
    partial class UserProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel MainPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminProfileIDTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminProfileUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminProfilePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminProfileRoleCmbBox = new System.Windows.Forms.ComboBox();
            this.AdminProfileUpdateBtn = new System.Windows.Forms.Button();
            this.AdminProfileFormBackBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.AdminProfileIDTxtBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.AdminProfileUserNameTxtBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.AdminProfilePasswordTxtBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.AdminProfileRoleCmbBox);
            this.MainPanel.Controls.Add(this.AdminProfileUpdateBtn);
            this.MainPanel.Controls.Add(this.AdminProfileFormBackBtn);
            this.MainPanel.Location = new System.Drawing.Point(200, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 330);
            this.MainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // AdminProfileIDTxtBox
            // 
            this.AdminProfileIDTxtBox.BackColor = System.Drawing.Color.AliceBlue;
            this.AdminProfileIDTxtBox.Location = new System.Drawing.Point(160, 30);
            this.AdminProfileIDTxtBox.Name = "AdminProfileIDTxtBox";
            this.AdminProfileIDTxtBox.ReadOnly = true;
            this.AdminProfileIDTxtBox.Size = new System.Drawing.Size(180, 22);
            this.AdminProfileIDTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // AdminProfileUserNameTxtBox
            // 
            this.AdminProfileUserNameTxtBox.BackColor = System.Drawing.Color.AliceBlue;
            this.AdminProfileUserNameTxtBox.Location = new System.Drawing.Point(160, 75);
            this.AdminProfileUserNameTxtBox.Name = "AdminProfileUserNameTxtBox";
            this.AdminProfileUserNameTxtBox.ReadOnly = true;
            this.AdminProfileUserNameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.AdminProfileUserNameTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // AdminProfilePasswordTxtBox
            // 
            this.AdminProfilePasswordTxtBox.BackColor = System.Drawing.Color.AliceBlue;
            this.AdminProfilePasswordTxtBox.Location = new System.Drawing.Point(160, 120);
            this.AdminProfilePasswordTxtBox.Name = "AdminProfilePasswordTxtBox";
            this.AdminProfilePasswordTxtBox.Size = new System.Drawing.Size(180, 22);
            this.AdminProfilePasswordTxtBox.TabIndex = 5;
            this.AdminProfilePasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role:";
            // 
            // AdminProfileRoleCmbBox
            // 
            this.AdminProfileRoleCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminProfileRoleCmbBox.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "CounterStaff"});
            this.AdminProfileRoleCmbBox.Location = new System.Drawing.Point(160, 165);
            this.AdminProfileRoleCmbBox.Name = "AdminProfileRoleCmbBox";
            this.AdminProfileRoleCmbBox.Size = new System.Drawing.Size(180, 24);
            this.AdminProfileRoleCmbBox.TabIndex = 7;
            // 
            // AdminProfileUpdateBtn
            // 
            this.AdminProfileUpdateBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminProfileUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminProfileUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.AdminProfileUpdateBtn.Location = new System.Drawing.Point(40, 230);
            this.AdminProfileUpdateBtn.Name = "AdminProfileUpdateBtn";
            this.AdminProfileUpdateBtn.Size = new System.Drawing.Size(140, 45);
            this.AdminProfileUpdateBtn.TabIndex = 8;
            this.AdminProfileUpdateBtn.Text = "Update Profile";
            this.AdminProfileUpdateBtn.UseVisualStyleBackColor = false;
            this.AdminProfileUpdateBtn.Click += new System.EventHandler(this.AdminProfileUpdateBtn_Click);
            // 
            // AdminProfileFormBackBtn
            // 
            this.AdminProfileFormBackBtn.BackColor = System.Drawing.Color.Firebrick;
            this.AdminProfileFormBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminProfileFormBackBtn.ForeColor = System.Drawing.Color.White;
            this.AdminProfileFormBackBtn.Location = new System.Drawing.Point(200, 230);
            this.AdminProfileFormBackBtn.Name = "AdminProfileFormBackBtn";
            this.AdminProfileFormBackBtn.Size = new System.Drawing.Size(140, 45);
            this.AdminProfileFormBackBtn.TabIndex = 9;
            this.AdminProfileFormBackBtn.Text = "Back";
            this.AdminProfileFormBackBtn.UseVisualStyleBackColor = false;
            this.AdminProfileFormBackBtn.Click += new System.EventHandler(this.AdminProfileFormBackBtn_click);
            // 
            // UserProfileForm
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "UserProfileForm";
            this.Text = "User Profile";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button AdminProfileFormBackBtn;
    }
}

