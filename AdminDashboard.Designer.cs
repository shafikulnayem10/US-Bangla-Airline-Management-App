
namespace US_Bangla_Airline_Management_App
{
    partial class AdminDashboard
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
            this.AdminDashboardFlightListBtn = new System.Windows.Forms.Button();
            this.AdminDashBoardFlightBookingListBtn = new System.Windows.Forms.Button();
            this.AdminDashboardProfileBtn = new System.Windows.Forms.Button();
            this.AdminDashboardLogOutBtn = new System.Windows.Forms.Button();
            this.AdminDashBoardUserList = new System.Windows.Forms.Button();
            this.AdminDashBoardTitleLabel = new System.Windows.Forms.Label();
            this.AdminDashBoardAircarftListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminDashboardFlightListBtn
            // 
            this.AdminDashboardFlightListBtn.Location = new System.Drawing.Point(47, 129);
            this.AdminDashboardFlightListBtn.Name = "AdminDashboardFlightListBtn";
            this.AdminDashboardFlightListBtn.Size = new System.Drawing.Size(345, 86);
            this.AdminDashboardFlightListBtn.TabIndex = 0;
            this.AdminDashboardFlightListBtn.Text = "Flight List";
            this.AdminDashboardFlightListBtn.UseVisualStyleBackColor = true;
            this.AdminDashboardFlightListBtn.Click += new System.EventHandler(this.AdminDashboardFlightListBtn_Click);
            // 
            // AdminDashBoardFlightBookingListBtn
            // 
            this.AdminDashBoardFlightBookingListBtn.Location = new System.Drawing.Point(407, 221);
            this.AdminDashBoardFlightBookingListBtn.Name = "AdminDashBoardFlightBookingListBtn";
            this.AdminDashBoardFlightBookingListBtn.Size = new System.Drawing.Size(340, 86);
            this.AdminDashBoardFlightBookingListBtn.TabIndex = 1;
            this.AdminDashBoardFlightBookingListBtn.Text = "Booking Flights List";
            this.AdminDashBoardFlightBookingListBtn.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardProfileBtn
            // 
            this.AdminDashboardProfileBtn.Location = new System.Drawing.Point(21, 28);
            this.AdminDashboardProfileBtn.Name = "AdminDashboardProfileBtn";
            this.AdminDashboardProfileBtn.Size = new System.Drawing.Size(227, 69);
            this.AdminDashboardProfileBtn.TabIndex = 2;
            this.AdminDashboardProfileBtn.Text = "Profile";
            this.AdminDashboardProfileBtn.UseVisualStyleBackColor = true;
            this.AdminDashboardProfileBtn.Click += new System.EventHandler(this.AdminDashboardProfilebtn);
            // 
            // AdminDashboardLogOutBtn
            // 
            this.AdminDashboardLogOutBtn.Location = new System.Drawing.Point(270, 359);
            this.AdminDashboardLogOutBtn.Name = "AdminDashboardLogOutBtn";
            this.AdminDashboardLogOutBtn.Size = new System.Drawing.Size(262, 49);
            this.AdminDashboardLogOutBtn.TabIndex = 3;
            this.AdminDashboardLogOutBtn.Text = "Log Out";
            this.AdminDashboardLogOutBtn.UseVisualStyleBackColor = true;
            this.AdminDashboardLogOutBtn.Click += new System.EventHandler(this.AdminDashboardLogOutBtn_Click);
            // 
            // AdminDashBoardUserList
            // 
            this.AdminDashBoardUserList.Location = new System.Drawing.Point(407, 128);
            this.AdminDashBoardUserList.Name = "AdminDashBoardUserList";
            this.AdminDashBoardUserList.Size = new System.Drawing.Size(340, 87);
            this.AdminDashBoardUserList.TabIndex = 4;
            this.AdminDashBoardUserList.Text = "User List";
            this.AdminDashBoardUserList.UseVisualStyleBackColor = true;
            this.AdminDashBoardUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserListAction);
            // 
            // AdminDashBoardTitleLabel
            // 
            this.AdminDashBoardTitleLabel.AutoSize = true;
            this.AdminDashBoardTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDashBoardTitleLabel.Location = new System.Drawing.Point(300, 65);
            this.AdminDashBoardTitleLabel.Name = "AdminDashBoardTitleLabel";
            this.AdminDashBoardTitleLabel.Size = new System.Drawing.Size(257, 32);
            this.AdminDashBoardTitleLabel.TabIndex = 5;
            this.AdminDashBoardTitleLabel.Text = "Admin Dashboard";
            // 
            // AdminDashBoardAircarftListBtn
            // 
            this.AdminDashBoardAircarftListBtn.Location = new System.Drawing.Point(47, 221);
            this.AdminDashBoardAircarftListBtn.Name = "AdminDashBoardAircarftListBtn";
            this.AdminDashBoardAircarftListBtn.Size = new System.Drawing.Size(345, 86);
            this.AdminDashBoardAircarftListBtn.TabIndex = 6;
            this.AdminDashBoardAircarftListBtn.Text = "Aircraft List";
            this.AdminDashBoardAircarftListBtn.UseVisualStyleBackColor = true;
            this.AdminDashBoardAircarftListBtn.Click += new System.EventHandler(this.AdminDashBoardAircarftListBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDashBoardAircarftListBtn);
            this.Controls.Add(this.AdminDashBoardTitleLabel);
            this.Controls.Add(this.AdminDashBoardUserList);
            this.Controls.Add(this.AdminDashboardLogOutBtn);
            this.Controls.Add(this.AdminDashboardProfileBtn);
            this.Controls.Add(this.AdminDashBoardFlightBookingListBtn);
            this.Controls.Add(this.AdminDashboardFlightListBtn);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminDashboardFlightListBtn;
        private System.Windows.Forms.Button AdminDashBoardFlightBookingListBtn;
        private System.Windows.Forms.Button AdminDashboardProfileBtn;
        private System.Windows.Forms.Button AdminDashboardLogOutBtn;
        private System.Windows.Forms.Button AdminDashBoardUserList;
        private System.Windows.Forms.Label AdminDashBoardTitleLabel;
        private System.Windows.Forms.Button AdminDashBoardAircarftListBtn;
    }
}