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
    public partial class staffdashboard : Form
    {
        public staffdashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookingFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffForm sf = new staffForm();
            sf.Show();
        }

        private void staffbookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
