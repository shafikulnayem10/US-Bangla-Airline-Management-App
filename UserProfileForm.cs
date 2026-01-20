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
        int adminId;
        string oldRole;



        public UserProfileForm(int id)
        {
            InitializeComponent();
            adminId = id;
            LoadAdminProfile();
        }
        private void LoadAdminProfile()
        {
            DataRow user = User.GetUserById(adminId);

            AdminProfileIDTxtBox.Text = user["ID"].ToString();
            AdminProfileUserNameTxtBox.Text = user["UserName"].ToString();
            AdminProfilePasswordTxtBox.Text = user["Password"].ToString();
            AdminProfileRoleCmbBox.SelectedItem = user["Role"].ToString();

            AdminProfileIDTxtBox.ReadOnly = true;
            AdminProfileUserNameTxtBox.ReadOnly = true;

            
            oldRole = user["Role"].ToString().Trim();
        }


        private void AdminProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            string newRole = AdminProfileRoleCmbBox.SelectedItem.ToString().Trim();

            User.UpdateUser(
                adminId,
                AdminProfileUserNameTxtBox.Text,
                AdminProfilePasswordTxtBox.Text,
                newRole,
                1
            );

            MessageBox.Show("Profile updated successfully");

          
            if (oldRole.ToLower() != newRole.ToLower())
            {
                MessageBox.Show(
                    "Role changed. Please login again.",
                    "Session Expired",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

               
                LoggedInUser.ID = 0;
                LoggedInUser.UserName = null;
                LoggedInUser.Role = null;
                LoggedInUser.Status = 0;

               
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is LogInForm))
                        f.Close();
                }

                new LogInForm().Show();
            }

            this.Close();
        }

        private void AdminProfileFormBackBtn_click(object sender, EventArgs e)
        {
            this.Hide();

            string role = LoggedInUser.Role?.ToLower();

            if (role == "admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "customer")
            {
                new CustomerDashboard().Show();
            }
            else if (role == "staff")
            {
              
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
