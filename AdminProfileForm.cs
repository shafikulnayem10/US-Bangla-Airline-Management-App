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
    public partial class AdminProfileForm : Form
    {
        int adminId;
        string oldRole;



        public AdminProfileForm(int id)
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

            // 🔐 STORE OLD ROLE
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

            // 🔥 ROLE CHANGED → FORCE LOGOUT
            if (oldRole.ToLower() != newRole.ToLower())
            {
                MessageBox.Show(
                    "Role changed. Please login again.",
                    "Session Expired",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 🔐 Clear session
                LoggedInUser.ID = 0;
                LoggedInUser.UserName = null;
                LoggedInUser.Role = null;
                LoggedInUser.Status = 0;

                // 🔁 Close all forms except Login
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is LogInForm))
                        f.Close();
                }

                new LogInForm().Show();
            }

            this.Close();
        }

    }
}
