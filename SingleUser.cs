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
    public partial class SingleUser : Form
    {
        int userId;

        public SingleUser(int id, string username, string role, int status)
        {
            InitializeComponent();

            userId = id;

            SignleUserFormUserIDTxtBox.Text = id.ToString();
            SingleUserFormUserNameTxtBox.Text = username;
            SingleUserFormRoleCmb.SelectedItem = role;
            SingleUserFormStatusCmbBox.SelectedIndex = status == 1 ? 0 : 1;
        }

        private void SingleUserFormUpdateBtn_Click(object sender, EventArgs e)
        {
            int id = userId;
            string username = SingleUserFormUserNameTxtBox.Text.Trim();
            string password = SingleUserFormPasswordTxtBox.Text;
            string newRole = SingleUserFormRoleCmb.SelectedItem.ToString();
            int status = SingleUserFormStatusCmbBox.SelectedIndex == 0 ? 1 : 0;

            // 🔁 Duplicate username check
            if (User.IsUserNameTaken(username, id))
            {
                MessageBox.Show(
                    "Username already exists. Please choose another one.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 🔐 If password textbox is empty → keep old password
            if (string.IsNullOrWhiteSpace(password))
            {
                DataRow existingUser = User.GetUserById(id);
                password = existingUser["Password"].ToString();
            }

            // 🔍 Check: is admin updating himself?
            bool isUpdatingSelf = LoggedInUser.ID == id;

            bool roleChanged =
                isUpdatingSelf &&
                !LoggedInUser.Role.Equals(newRole, StringComparison.OrdinalIgnoreCase);

            // ✅ Update user
            User.UpdateUser(id, username, password, newRole, status);

            MessageBox.Show("User updated successfully");

            // 🚨 If admin changed his own role → force logout
            if (roleChanged)
            {
                MessageBox.Show(
                    "Your role has changed. Please login again.",
                    "Session Expired",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoggedInUser.Logout();

                // Close all forms except Login
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is LogInForm))
                        f.Close();
                }

                new LogInForm().Show();
                return;
            }

            this.Close();
        }


        private void SingleUserFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllUsers a = new AllUsers();
            a.Show();

        }
    }
}
