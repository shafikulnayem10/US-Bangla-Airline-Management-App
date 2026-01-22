using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class SingleUser : Form
    {
       

        public SingleUser(int id, string username, string role, int status)
        {
            InitializeComponent();

            

            SignleUserFormUserIDTxtBox.Text = id.ToString();
            SingleUserFormUserNameTxtBox.Text = username;
            SingleUserFormRoleCmb.SelectedItem = role;
            if (status == 1)
            {
                SingleUserFormStatusCmbBox.SelectedIndex = 0;
            }
            else
            {
                SingleUserFormStatusCmbBox.SelectedIndex = 1;
            }

        }

        private void SingleUserFormUpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SignleUserFormUserIDTxtBox.Text);
            string username = SingleUserFormUserNameTxtBox.Text.Trim();
            string newRole = SingleUserFormRoleCmb.SelectedItem.ToString().Trim();
            int status;

            if (SingleUserFormStatusCmbBox.SelectedIndex == 0)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }



            if (User.IsUserCredentialTaken(username, id))
            {
                MessageBox.Show( "Username is  already exists. Please use a different one."  );
                return;
            }



            DataRow existingUser = User.GetUserById(id);
            string password = existingUser["Password"].ToString();


            bool isUpdatingSelf;
            bool roleChanged;

            if (LoggedInUser.ID == id)
            {
                isUpdatingSelf = true;

                if (LoggedInUser.Role.ToLower() != newRole.ToLower())
                {
                    roleChanged = true;
                }
                else
                {
                    roleChanged = false;
                }
            }
            else
            {
                isUpdatingSelf = false;
                roleChanged = false;
            }



            User.UpdateUser(id, username, password, newRole, status);

            MessageBox.Show("User updated successfully");

            
            if (roleChanged)
            {
                MessageBox.Show( "Your role has changed. Please login again" );

                LoggedInUser.Logout();


                this.Close();
                new LogInForm().Show();
                return;
            }


            this.Hide();
            new AllUsers().Show();

        }

        private void SingleUserFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new AllUsers().Show();
        }
    }
}

