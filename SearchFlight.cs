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
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current == null) return;

            if (current.Checked)
            {
                foreach (Control ctrl in grpDestination.Controls)
                {
                    if (ctrl is CheckBox cb && cb != current)
                    {
                        cb.Checked = false;
                    }
                }
    }
}
