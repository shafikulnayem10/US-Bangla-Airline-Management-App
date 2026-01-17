using System;
using System.Data;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class AircraftlistForm : Form
    {
        Aircraft a = new Aircraft();
      

        public AircraftlistForm()
        {
            InitializeComponent();

            aircraftGridView.ReadOnly = true;
            aircraftGridView.AllowUserToAddRows = false;
            aircraftGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // SHOW ALL
        private void showall_Click(object sender, EventArgs e)
        {
            aircraftGridView.DataSource = a.showAll();
        }

        // ADD
        private void addbtn_Click_1(object sender, EventArgs e)
        {
            int no, cap;

            if (!int.TryParse(txtNo.Text, out no))
            {
                MessageBox.Show("Enter valid Aircraft No");
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out cap))
            {
                MessageBox.Show("Enter valid Capacity");
                return;
            }

            a.AircraftNo = no;
            a.AircraftModel = txtModel.Text;
            a.Manufacturer = txtManufacturer.Text;
            a.Capacity = cap;

            if (a.insert(a))
            {
                MessageBox.Show("Aircraft Added Successfully");
                aircraftGridView.DataSource = a.showAll();
                clearText();
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
        }

        // DELETE
        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            int no;

            if (!int.TryParse(txtNo.Text, out no))
            {
                MessageBox.Show("Enter valid Aircraft No");
                return;
            }

            a.AircraftNo = no;

            if (a.delete(a))
            {
                MessageBox.Show("Aircraft Deleted Successfully");
                aircraftGridView.DataSource = a.showAll();
                clearText();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        // GRID ROW CLICK → TEXTBOX FILL
        private void aircraftGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = aircraftGridView.Rows[e.RowIndex];

                txtNo.Text = row.Cells["AircraftNo"].Value.ToString();
                txtModel.Text = row.Cells["AircraftModel"].Value.ToString();
                txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                txtCapacity.Text = row.Cells["Capacity"].Value.ToString();
            }
        }

        // CLEAR TEXTBOX
        void clearText()
        {
            txtNo.Clear();
            txtModel.Clear();
            txtManufacturer.Clear();
            txtCapacity.Clear();
        }
    }
}