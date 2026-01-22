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
    public partial class UserProfileForm : Form
    {
        int UserId;
        string oldRole;



        public UserProfileForm(int id)
        {
            InitializeComponent();
            UserId = id;
            LoadUserProfile();
        }
        private void LoadUserProfile()
        {
            DataRow user = User.GetUserById(UserId);

            AdminProfileIDTxtBox.Text = user["ID"].ToString();
            AdminProfileUserNameTxtBox.Text = user["UserName"].ToString();
            AdminProfilePasswordTxtBox.Text = user["Password"].ToString();
            AdminProfileRoleCmbBox.SelectedItem = user["Role"].ToString();

           

            
            oldRole = user["Role"].ToString().Trim();
        }


        private void AdminProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            string newRole = AdminProfileRoleCmbBox.SelectedItem.ToString().Trim();

            User.UpdateUser(
                UserId,
                AdminProfileUserNameTxtBox.Text,
                AdminProfilePasswordTxtBox.Text,
                newRole,
                1
            );

            MessageBox.Show("Profile updated successfully");

            
            if (oldRole.ToLower() != newRole.ToLower())
            {
                MessageBox.Show("Role changed. Please login again.");

                LoggedInUser.ID = 0;
                LoggedInUser.UserName = null;
                LoggedInUser.Role = null;
                LoggedInUser.Status = 0;

                this.Close();
                new LogInForm().Show();

                return; 
            }

           
            this.Hide();

            string role = "";

            if (LoggedInUser.Role != null)
            {
                role = LoggedInUser.Role.Replace(" ", "").ToLower().Trim();
            }

            if (role == "admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "customer")
            {
                new CustomerDashboard().Show();
            }
            else if (role == "counterstaff" || role == "staff")
            {
                new staffdashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid role. Please login again.");
                LoggedInUser.Logout();
                new LogInForm().Show();
            }
        }


        private void AdminProfileFormBackBtn_click(object sender, EventArgs e)
        {
            this.Hide();

            string role = "";

            if (LoggedInUser.Role != null)
            {
                role = LoggedInUser.Role.Replace(" ", "").ToLower().Trim();
            }


            if (role == "admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "customer")
            {
                new CustomerDashboard().Show();
            }
            else if (role == "counterstaff" || role == "staff")
            {
                new staffdashboard().Show();
              
            }
            else
            {
                MessageBox.Show("Invalid role. Please login again.");
                LoggedInUser.Logout();
                new LogInForm().Show();
            }
        }

    }
}
