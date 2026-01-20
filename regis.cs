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
            LoadRole();
        }

      
        private void LoadRole()
        {
            RegisFormRoleComBox.Items.Clear();
            RegisFormRoleComBox.Items.Add("Admin");
            RegisFormRoleComBox.Items.Add("Customer");
            RegisFormRoleComBox.Items.Add("Staff");
            RegisFormRoleComBox.SelectedIndex = 0;
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
            
        }





        // 🔹 SIGN UP BUTTON CLICK

private void signup_Click(object sender, EventArgs e)
    {
        
        int id = Convert.ToInt32(RegisFormIDTxtForm.Text);
        string username = RegisFormUserNameTxtBox.Text;
        string password = RegisFormPasswordTxtBox.Text;
        string role = RegisFormRoleComBox.SelectedItem.ToString();

       
        if (username == "" || password == "")
        {
            MessageBox.Show("All fields are required!");
            return;
        }

        try
        {
            
            User.CreateUser(id, username, password, role);

            MessageBox.Show("Sign Up Successful!");

            this.Hide();
            new LogInForm().Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    // 🔹 CANCEL BUTTON
    private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 🔹 LOGIN NOW BUTTON
        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }
    }
}
