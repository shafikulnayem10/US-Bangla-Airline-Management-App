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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.ShowDialog();
        }

        private void AdminDashboardLogOutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AvailableFlightBtn_Click(object sender, EventArgs e)
        {
            AvailableFlight flightsForm = new AvailableFlight();
            flightsForm.ShowDialog();
        }

        private void CustomerDashboardProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileNavigator.OpenProfile();
    
        }
    }
}
