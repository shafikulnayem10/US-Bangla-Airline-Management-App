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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserListAction(object sender, MouseEventArgs e)
        {
            this.Hide();
            AllUsers AU = new AllUsers();
            AU.Show();

        }

        private void AdminDashBoardAircarftListBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardFlightListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllFlights AF = new AllFlights();
            AF.Show();

        }
/*
        private void AdminDashboardBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm LF = new LogInForm();
            LF.Show();

        }
*/

        private void AdminDashboardProfilebtn(object sender, EventArgs e)
        {
            if (!LoggedInUser.IsLoggedIn)
            {
                MessageBox.Show("Session expired. Please login again.");
                return;
            }

            AdminProfileForm frm =
                new AdminProfileForm(LoggedInUser.ID);

            frm.ShowDialog();
        }

        private void AdminDashboardLogOutBtn_Click(object sender, EventArgs e)
        {
            LoggedInUser.Logout();
            this.Hide();
            new LogInForm().Show();
        }
    }
}
