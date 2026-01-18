using System;
using System.Data;
using System.Linq;
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

            // 🔐 Always keep old password (admin never touches it)
            DataRow existingUser = User.GetUserById(id);
            string password = existingUser["Password"].ToString();

            // 🔍 Check: is admin updating himself?
            bool isUpdatingSelf = LoggedInUser.ID == id;
            bool roleChanged =
                isUpdatingSelf &&
                !LoggedInUser.Role.Equals(newRole, StringComparison.OrdinalIgnoreCase);

            // ✅ Update user
            User.UpdateUser(id, username, password, newRole, status);

            MessageBox.Show("User updated successfully");

            // 🚨 Self-role change → force logout
            if (roleChanged)
            {
                MessageBox.Show(
                    "Your role has changed. Please login again.",
                    "Session Expired",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoggedInUser.Logout();

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
            new AllUsers().Show();
        }
    }
}

