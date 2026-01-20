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
    public partial class selectpaymethod : Form
    {
        public selectpaymethod()
        {
            InitializeComponent();
        }

        private void selecttxt_Click(object sender, EventArgs e)
        {


        }

        private void bkslogobtn_Click(object sender, EventArgs e)
        {


            this.Hide();
            bkashpage b = new bkashpage();
            b.Show();

        }

        private void visalogobtn_Click(object sender, EventArgs e)
        {
            
        }

        private void selectmethodFormVISABtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new visa().Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}