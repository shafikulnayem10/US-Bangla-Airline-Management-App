using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class AdminDashboard : Form
    {
        private Button AdminDashboardFlightListBtn;
        private Button AdminDashBoardFlightBookingListBtn;
        private Button AdminDashboardProfileBtn;
        private Button AdminDashboardLogOutBtn;
        private Button AdminDashBoardUserList;
        private Label AdminDashBoardTitleLabel;
        private Button AdminDashBoardAircarftListBtn;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserListAction(object sender, MouseEventArgs e)
        {
            this.Hide();
            AllUsers AU = new AllUsers();
            AU.Show();

        }

        private void AdminDashBoardAircarftListBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardFlightListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllFlights AF = new AllFlights();
            AF.Show();

        }
/*
        private void AdminDashboardBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm LF = new LogInForm();
            LF.Show();

        }
*/

        private void AdminDashboardProfilebtn(object sender, EventArgs e)
        {
            ProfileNavigator.OpenProfile();
        }

        private void AdminDashboardLogOutBtn_Click(object sender, EventArgs e)
        {
            LoggedInUser.Logout();
            this.Hide();
            new LogInForm().Show();
        }

  

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
            this.AdminDashboardFlightListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AdminDashboardFlightListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardFlightListBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardFlightListBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardFlightListBtn.Location = new System.Drawing.Point(47, 129);
            this.AdminDashboardFlightListBtn.Name = "AdminDashboardFlightListBtn";
            this.AdminDashboardFlightListBtn.Size = new System.Drawing.Size(345, 86);
            this.AdminDashboardFlightListBtn.TabIndex = 6;
            this.AdminDashboardFlightListBtn.Text = "✈ Flight List";
            this.AdminDashboardFlightListBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardFlightListBtn.Click += new System.EventHandler(this.AdminDashboardFlightListBtn_Click);
            // 
            // AdminDashBoardFlightBookingListBtn
            // 
            this.AdminDashBoardFlightBookingListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.AdminDashBoardFlightBookingListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashBoardFlightBookingListBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashBoardFlightBookingListBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashBoardFlightBookingListBtn.Location = new System.Drawing.Point(407, 221);
            this.AdminDashBoardFlightBookingListBtn.Name = "AdminDashBoardFlightBookingListBtn";
            this.AdminDashBoardFlightBookingListBtn.Size = new System.Drawing.Size(340, 86);
            this.AdminDashBoardFlightBookingListBtn.TabIndex = 5;
            this.AdminDashBoardFlightBookingListBtn.Text = "📄 Booking Flights List";
            this.AdminDashBoardFlightBookingListBtn.UseVisualStyleBackColor = false;
            // 
            // AdminDashboardProfileBtn
            // 
            this.AdminDashboardProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AdminDashboardProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardProfileBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardProfileBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardProfileBtn.Location = new System.Drawing.Point(21, 28);
            this.AdminDashboardProfileBtn.Name = "AdminDashboardProfileBtn";
            this.AdminDashboardProfileBtn.Size = new System.Drawing.Size(227, 69);
            this.AdminDashboardProfileBtn.TabIndex = 4;
            this.AdminDashboardProfileBtn.Text = " Profile";
            this.AdminDashboardProfileBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardProfileBtn.Click += new System.EventHandler(this.AdminDashboardProfilebtn);
            // 
            // AdminDashboardLogOutBtn
            // 
            this.AdminDashboardLogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.AdminDashboardLogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardLogOutBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardLogOutBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardLogOutBtn.Location = new System.Drawing.Point(270, 359);
            this.AdminDashboardLogOutBtn.Name = "AdminDashboardLogOutBtn";
            this.AdminDashboardLogOutBtn.Size = new System.Drawing.Size(262, 49);
            this.AdminDashboardLogOutBtn.TabIndex = 3;
            this.AdminDashboardLogOutBtn.Text = "🚪 Log Out";
            this.AdminDashboardLogOutBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardLogOutBtn.Click += new System.EventHandler(this.AdminDashboardLogOutBtn_Click);
            // 
            // AdminDashBoardUserList
            // 
            this.AdminDashBoardUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.AdminDashBoardUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashBoardUserList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashBoardUserList.ForeColor = System.Drawing.Color.Black;
            this.AdminDashBoardUserList.Location = new System.Drawing.Point(407, 128);
            this.AdminDashBoardUserList.Name = "AdminDashBoardUserList";
            this.AdminDashBoardUserList.Size = new System.Drawing.Size(340, 87);
            this.AdminDashBoardUserList.TabIndex = 2;
            this.AdminDashBoardUserList.Text = "👥 User List";
            this.AdminDashBoardUserList.UseVisualStyleBackColor = false;
            this.AdminDashBoardUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserListAction);
            // 
            // AdminDashBoardTitleLabel
            // 
            this.AdminDashBoardTitleLabel.AutoSize = true;
            this.AdminDashBoardTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AdminDashBoardTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.AdminDashBoardTitleLabel.Location = new System.Drawing.Point(270, 60);
            this.AdminDashBoardTitleLabel.Name = "AdminDashBoardTitleLabel";
            this.AdminDashBoardTitleLabel.Size = new System.Drawing.Size(273, 41);
            this.AdminDashBoardTitleLabel.TabIndex = 1;
            this.AdminDashBoardTitleLabel.Text = "Admin Dashboard";
            // 
            // AdminDashBoardAircarftListBtn
            // 
            this.AdminDashBoardAircarftListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.AdminDashBoardAircarftListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashBoardAircarftListBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashBoardAircarftListBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashBoardAircarftListBtn.Location = new System.Drawing.Point(47, 221);
            this.AdminDashBoardAircarftListBtn.Name = "AdminDashBoardAircarftListBtn";
            this.AdminDashBoardAircarftListBtn.Size = new System.Drawing.Size(345, 86);
            this.AdminDashBoardAircarftListBtn.TabIndex = 0;
            this.AdminDashBoardAircarftListBtn.Text = "🛩 Aircraft List";
            this.AdminDashBoardAircarftListBtn.UseVisualStyleBackColor = false;
            this.AdminDashBoardAircarftListBtn.Click += new System.EventHandler(this.AdminDashBoardAircarftListBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDashBoardAircarftListBtn);
            this.Controls.Add(this.AdminDashBoardTitleLabel);
            this.Controls.Add(this.AdminDashBoardUserList);
            this.Controls.Add(this.AdminDashboardLogOutBtn);
            this.Controls.Add(this.AdminDashboardProfileBtn);
            this.Controls.Add(this.AdminDashBoardFlightBookingListBtn);
            this.Controls.Add(this.AdminDashboardFlightListBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
