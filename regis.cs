using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class regis : Form
    {
       
        public regis()
        {
            InitializeComponent();
        
        }

    
        

        private void FullName_Click(object sender, EventArgs e)
        {
           
        }

        private void RegisFormUserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
      

     

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





       

        private void signup_Click(object sender, EventArgs e)
        {
            if (RegisFormIDTxtForm.Text == "")
            {
                MessageBox.Show("ID is required!");
                return;
            }

            int ID;
            try
            {
                ID = Convert.ToInt32(RegisFormIDTxtForm.Text);
            }
            catch
            {
                MessageBox.Show("ID must be a valid number!");
                return;
            }

            if (ID <= 0)
            {
                MessageBox.Show("ID must be greater than 0!");
                return;
            }


            string username = RegisFormUserNameTxtBox.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Username is required!");
                return;


            }

            try
            {
                Convert.ToInt32(username);
                MessageBox.Show("Username cannot be only numbers!");
                return;
            }
            catch
            {
               
            }

            string password = RegisFormPasswordTxtBox.Text;
            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters !");
                return;
            }

            if (RegisFormRoleComBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role!");
                return;
            }

            string role = RegisFormRoleComBox.SelectedItem.ToString();

            try
            {
                User.CreateUser(ID, username, password, role);

                MessageBox.Show("Sign up successful!");

                this.Hide();
                new LogInForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

       
        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }
    }
}
