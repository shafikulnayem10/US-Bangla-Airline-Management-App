namespace US_Bangla_Airline_Management_App
{
    partial class SingleUser
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(SingleUser));

            this.mainPanel = new System.Windows.Forms.Panel();
            this.SingleUserFormUserIDLabel = new System.Windows.Forms.Label();
            this.SignleUserFormUserIDTxtBox = new System.Windows.Forms.TextBox();
            this.SignleUserFormUserNameLabel = new System.Windows.Forms.Label();
            this.SingleUserFormUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.SingleUserFormRoleLabel = new System.Windows.Forms.Label();
            this.SingleUserFormRoleCmb = new System.Windows.Forms.ComboBox();
            this.SingleUserFormStatusLabel = new System.Windows.Forms.Label();
            this.SingleUserFormStatusCmbBox = new System.Windows.Forms.ComboBox();
            this.SingleUserFormUpdateBtn = new System.Windows.Forms.Button();
            this.SingleUserFormBackBtn = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.mainPanel.SuspendLayout();

            // mainPanel
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.mainPanel.Location = new System.Drawing.Point(120, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(430, 360);
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // User ID Label
            this.SingleUserFormUserIDLabel.Text = "User ID:";
            this.SingleUserFormUserIDLabel.Location = new System.Drawing.Point(40, 30);

            // User ID TextBox
            this.SignleUserFormUserIDTxtBox.Location = new System.Drawing.Point(160, 30);
            this.SignleUserFormUserIDTxtBox.ReadOnly = true;
            this.SignleUserFormUserIDTxtBox.Size = new System.Drawing.Size(200, 22);

            // User Name Label
            this.SignleUserFormUserNameLabel.Text = "User Name:";
            this.SignleUserFormUserNameLabel.Location = new System.Drawing.Point(40, 80);

            // User Name TextBox
            this.SingleUserFormUserNameTxtBox.Location = new System.Drawing.Point(160, 80);
            this.SingleUserFormUserNameTxtBox.Size = new System.Drawing.Size(200, 22);

            // Role Label
            this.SingleUserFormRoleLabel.Text = "Role:";
            this.SingleUserFormRoleLabel.Location = new System.Drawing.Point(40, 130);

            // Role ComboBox
            this.SingleUserFormRoleCmb.Items.AddRange(new object[] {
                "Admin",
                "Customer",
                "Counter Staff"
            });
            this.SingleUserFormRoleCmb.Location = new System.Drawing.Point(160, 130);
            this.SingleUserFormRoleCmb.Size = new System.Drawing.Size(200, 24);

            // Status Label
            this.SingleUserFormStatusLabel.Text = "Status:";
            this.SingleUserFormStatusLabel.Location = new System.Drawing.Point(40, 180);

            // Status ComboBox
            this.SingleUserFormStatusCmbBox.Items.AddRange(new object[] {
                "Active",
                "Inactive"
            });
            this.SingleUserFormStatusCmbBox.Location = new System.Drawing.Point(160, 180);
            this.SingleUserFormStatusCmbBox.Size = new System.Drawing.Size(200, 24);

            // Update Button
            this.SingleUserFormUpdateBtn.Text = "Update User";
            this.SingleUserFormUpdateBtn.Location = new System.Drawing.Point(40, 260);
            this.SingleUserFormUpdateBtn.Size = new System.Drawing.Size(150, 40);
            this.SingleUserFormUpdateBtn.Click +=
                new System.EventHandler(this.SingleUserFormUpdateBtn_Click);

            // Back Button
            this.SingleUserFormBackBtn.Text = "Back";
            this.SingleUserFormBackBtn.Location = new System.Drawing.Point(210, 260);
            this.SingleUserFormBackBtn.Size = new System.Drawing.Size(150, 40);
            this.SingleUserFormBackBtn.Click +=
                new System.EventHandler(this.SingleUserFormBackBtn_Click);

            // Add controls
            this.mainPanel.Controls.Add(this.SingleUserFormUserIDLabel);
            this.mainPanel.Controls.Add(this.SignleUserFormUserIDTxtBox);
            this.mainPanel.Controls.Add(this.SignleUserFormUserNameLabel);
            this.mainPanel.Controls.Add(this.SingleUserFormUserNameTxtBox);
            this.mainPanel.Controls.Add(this.SingleUserFormRoleLabel);
            this.mainPanel.Controls.Add(this.SingleUserFormRoleCmb);
            this.mainPanel.Controls.Add(this.SingleUserFormStatusLabel);
            this.mainPanel.Controls.Add(this.SingleUserFormStatusCmbBox);
            this.mainPanel.Controls.Add(this.SingleUserFormUpdateBtn);
            this.mainPanel.Controls.Add(this.SingleUserFormBackBtn);

            // Form
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 474);
            this.Controls.Add(this.mainPanel);
            this.Text = "Edit User";
            this.DoubleBuffered = true;

            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label SingleUserFormUserIDLabel;
        private System.Windows.Forms.TextBox SignleUserFormUserIDTxtBox;
        private System.Windows.Forms.Label SignleUserFormUserNameLabel;
        private System.Windows.Forms.TextBox SingleUserFormUserNameTxtBox;
        private System.Windows.Forms.Label SingleUserFormRoleLabel;
        private System.Windows.Forms.ComboBox SingleUserFormRoleCmb;
        private System.Windows.Forms.Label SingleUserFormStatusLabel;
        private System.Windows.Forms.ComboBox SingleUserFormStatusCmbBox;
        private System.Windows.Forms.Button SingleUserFormUpdateBtn;
        private System.Windows.Forms.Button SingleUserFormBackBtn;
    }
}



