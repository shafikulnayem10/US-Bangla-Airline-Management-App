using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    public partial class LogInForm : Form
    {
       // string connectionString =  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";
        public LogInForm()
        {
            InitializeComponent();
        }



        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = LogInFormUserNameTextBox.Text.Trim();
            string password = LogInFormPassTxtBox.Text.Trim();

            // 🔴 Empty check
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            // 🔍 STEP 1: Get user from DB
            DataRow user = User.GetUserByUsername(username);

            if (user == null)
            {
                MessageBox.Show("Username or Password incorrect");
                return;
            }

            // 🔐 STEP 2: Password & Status validation (SAFE)
            string dbPassword = user["Password"].ToString().Trim();
            int status = Convert.ToInt32(user["Status"]);

            if (dbPassword != password)
            {
                MessageBox.Show("Username or Password incorrect");
                return;
            }

            if (status != 1)
            {
                MessageBox.Show("User account is inactive");
                return;
            }

            // 🧠 STEP 3: Store Logged-in user (SESSION)
            LoggedInUser.ID = Convert.ToInt32(user["ID"]);
            LoggedInUser.UserName = user["UserName"].ToString();
            LoggedInUser.Role = user["Role"].ToString().Trim();
            LoggedInUser.Status = status;

            // 🎯 STEP 4: Role-based navigation
            this.Hide();

            string role = LoggedInUser.Role.ToLower();

            if (role == "admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "customer")
            {
              
                new CustomerDashboard().Show();
            }
            else if (role == "counterstaff")
            {
                
                new staffdashboard().Show();
            }
            else
            {
                MessageBox.Show("Unknown role: " + LoggedInUser.Role);
                this.Show();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            regis If = new regis();
            If.Show();
            this.Hide();
        }
    }
}
