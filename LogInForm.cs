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
     
        public LogInForm()
        {
            InitializeComponent();
        }



        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = LogInFormUserNameTextBox.Text.Trim();
            string password = LogInFormPassTxtBox.Text.Trim();

            
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and  password");
                return;
            }

         
            DataRow user = User.GetUserByUsername(username);

            if (user == null)
            {
                MessageBox.Show("Username or Password incorrect");
                return;
            }


            string dbPassword = user["Password"].ToString().Trim();
            

            if (!dbPassword.Equals(password))
            {
                MessageBox.Show("Username or Password incorrect");
                return;
            }

            int status = Convert.ToInt32(user["Status"]);

            if (status != 1)
            {
                MessageBox.Show("User account is inactive");
                return;
            }

            
            LoggedInUser.ID = Convert.ToInt32(user["ID"]);
            LoggedInUser.UserName = user["UserName"].ToString();
            LoggedInUser.Role = user["Role"].ToString().Trim();
            LoggedInUser.Status = status;

            
            this.Hide();

            string role = LoggedInUser.Role.Replace(" ", "").ToLower();
      


            if (role == "admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "customer")
            {
              
                new CustomerDashboard().Show();
            }
            else if (role == "counterstaff"||role=="staff")
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
