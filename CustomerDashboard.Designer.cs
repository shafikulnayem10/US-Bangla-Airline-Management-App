namespace US_Bangla_Airline_Management_App
{
    partial class CustomerDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label CustomerDashBoardTitleLabel;
        private System.Windows.Forms.Button AdminDashboardLogOutBtn;
        private System.Windows.Forms.Button AdminDashboardProfileBtn;
        private System.Windows.Forms.Button AvailableFlightBtn;
        private System.Windows.Forms.DataGridView CustomerBookingHistoryGridView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.CustomerDashBoardTitleLabel = new System.Windows.Forms.Label();
            this.AdminDashboardLogOutBtn = new System.Windows.Forms.Button();
            this.AdminDashboardProfileBtn = new System.Windows.Forms.Button();
            this.AvailableFlightBtn = new System.Windows.Forms.Button();
            this.CustomerBookingHistoryGridView = new System.Windows.Forms.DataGridView();
            this.CustomerDashboardFormCancelBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBookingHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDashBoardTitleLabel
            // 
            this.CustomerDashBoardTitleLabel.AutoSize = true;
            this.CustomerDashBoardTitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerDashBoardTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.CustomerDashBoardTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.CustomerDashBoardTitleLabel.Location = new System.Drawing.Point(338, 64);
            this.CustomerDashBoardTitleLabel.Name = "CustomerDashBoardTitleLabel";
            this.CustomerDashBoardTitleLabel.Size = new System.Drawing.Size(314, 41);
            this.CustomerDashBoardTitleLabel.TabIndex = 8;
            this.CustomerDashBoardTitleLabel.Text = "Customer Dashboard";
            // 
            // AdminDashboardLogOutBtn
            // 
            this.AdminDashboardLogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.AdminDashboardLogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardLogOutBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardLogOutBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardLogOutBtn.Location = new System.Drawing.Point(99, 435);
            this.AdminDashboardLogOutBtn.Name = "AdminDashboardLogOutBtn";
            this.AdminDashboardLogOutBtn.Size = new System.Drawing.Size(261, 49);
            this.AdminDashboardLogOutBtn.TabIndex = 10;
            this.AdminDashboardLogOutBtn.Text = " Log Out";
            this.AdminDashboardLogOutBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardLogOutBtn.Click += new System.EventHandler(this.AdminDashboardLogOutBtn_Click);
            // 
            // AdminDashboardProfileBtn
            // 
            this.AdminDashboardProfileBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AdminDashboardProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardProfileBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardProfileBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardProfileBtn.Location = new System.Drawing.Point(52, 36);
            this.AdminDashboardProfileBtn.Name = "AdminDashboardProfileBtn";
            this.AdminDashboardProfileBtn.Size = new System.Drawing.Size(227, 69);
            this.AdminDashboardProfileBtn.TabIndex = 11;
            this.AdminDashboardProfileBtn.Text = " Profile";
            this.AdminDashboardProfileBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardProfileBtn.Click += new System.EventHandler(this.CustomerDashboardProfileBtn_Click);
            // 
            // AvailableFlightBtn
            // 
            this.AvailableFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AvailableFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailableFlightBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AvailableFlightBtn.ForeColor = System.Drawing.Color.White;
            this.AvailableFlightBtn.Location = new System.Drawing.Point(87, 245);
            this.AvailableFlightBtn.Name = "AvailableFlightBtn";
            this.AvailableFlightBtn.Size = new System.Drawing.Size(345, 86);
            this.AvailableFlightBtn.TabIndex = 13;
            this.AvailableFlightBtn.Text = "Available Flight";
            this.AvailableFlightBtn.UseVisualStyleBackColor = false;
            this.AvailableFlightBtn.Click += new System.EventHandler(this.AvailableFlightBtn_Click);
            // 
            // CustomerBookingHistoryGridView
            // 
            this.CustomerBookingHistoryGridView.AllowUserToAddRows = false;
            this.CustomerBookingHistoryGridView.AllowUserToDeleteRows = false;
            this.CustomerBookingHistoryGridView.AllowUserToResizeColumns = false;
            this.CustomerBookingHistoryGridView.AllowUserToResizeRows = false;
            this.CustomerBookingHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerBookingHistoryGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerBookingHistoryGridView.ColumnHeadersHeight = 29;
            this.CustomerBookingHistoryGridView.Location = new System.Drawing.Point(511, 130);
            this.CustomerBookingHistoryGridView.MultiSelect = false;
            this.CustomerBookingHistoryGridView.Name = "CustomerBookingHistoryGridView";
            this.CustomerBookingHistoryGridView.ReadOnly = true;
            this.CustomerBookingHistoryGridView.RowHeadersWidth = 51;
            this.CustomerBookingHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerBookingHistoryGridView.Size = new System.Drawing.Size(544, 276);
            this.CustomerBookingHistoryGridView.TabIndex = 14;
            // 
            // CustomerDashboardFormCancelBooking
            // 
            this.CustomerDashboardFormCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CustomerDashboardFormCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerDashboardFormCancelBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CustomerDashboardFormCancelBooking.ForeColor = System.Drawing.Color.White;
            this.CustomerDashboardFormCancelBooking.Location = new System.Drawing.Point(715, 412);
            this.CustomerDashboardFormCancelBooking.Name = "CustomerDashboardFormCancelBooking";
            this.CustomerDashboardFormCancelBooking.Size = new System.Drawing.Size(175, 62);
            this.CustomerDashboardFormCancelBooking.TabIndex = 15;
            this.CustomerDashboardFormCancelBooking.Text = "Cancel Booking";
            this.CustomerDashboardFormCancelBooking.UseVisualStyleBackColor = false;
            this.CustomerDashboardFormCancelBooking.Click += new System.EventHandler(this.CustomerDashboardFormCancelBooking_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CustomerDashboardFormCancelBooking);
            this.Controls.Add(this.CustomerBookingHistoryGridView);
            this.Controls.Add(this.CustomerDashBoardTitleLabel);
            this.Controls.Add(this.AdminDashboardLogOutBtn);
            this.Controls.Add(this.AdminDashboardProfileBtn);
            this.Controls.Add(this.AvailableFlightBtn);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBookingHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button CustomerDashboardFormCancelBooking;
    }
}
