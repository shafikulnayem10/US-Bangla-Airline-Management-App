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
    public partial class AllUsers : Form
    {
       
        public AllUsers()
        {
            InitializeComponent();

            
                LoadAllUsers();
            
        }



        private void LoadAllUsers()
        {
            AllUsersTable.DataSource = User.GetAllUsers();
        }

        private void SelectUserBtn_Click(object sender, EventArgs e)
        {


                

               
                DataGridViewRow row = AllUsersTable.SelectedRows[0];

             
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string username = row.Cells["UserName"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();
                int status = Convert.ToInt32(row.Cells["Status"].Value);

               
                SingleUser su = new SingleUser(id, username, role, status);
                this.Hide();
               
                su.ShowDialog();

              
                LoadAllUsers();
            

        }

        private void AllUsersFormDeleteUserBtn_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = AllUsersTable.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            bool isDeletingSelf = false;
            if (LoggedInUser.ID == id)
            {
                isDeletingSelf = true;
            }
            else
            {
                isDeletingSelf= false;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                User.DeleteUser(id);
                MessageBox.Show("User deleted successfully");
            }
            else
            {
               
                return ;
            }



            if (isDeletingSelf)
            {
                MessageBox.Show(
                    "Your account has been deleted. Please sign up again.",
                    "Session Ended",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoggedInUser.Logout();

               
              

            
                new regis().Show();
                return;
            }

           
            LoadAllUsers();
        }


        private void AllUsersBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard a = new AdminDashboard();
            a.Show();

        }
    }
}
