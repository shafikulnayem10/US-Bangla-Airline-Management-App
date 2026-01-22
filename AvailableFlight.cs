using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    public partial class AvailableFlight : Form
    {
        public AvailableFlight()
        {
            InitializeComponent();
            LoadFlights();
        }

        private void AvailableFlight_Load(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void show_Click(object sender, EventArgs e) { }

        private void LoadFlights()
        {
            dgvflight.DataSource = Flight.GetAllFlights();
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerDashboard().Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow row = dgvflight.SelectedRows[0];

            int flightId = Convert.ToInt32(row.Cells["FlightID"].Value);

            string departure = row.Cells["Departure"].Value.ToString();
            string destination = row.Cells["Destination"].Value.ToString();
            string depDateTime = row.Cells["DepartureDateTime"].Value.ToString();
            string arrDateTime = row.Cells["ArrivalDateTime"].Value.ToString();
            string aircraftNo = row.Cells["AircraftNo"].Value.ToString();
            string flightStatus = row.Cells["FlightStatus"].Value.ToString();

            BookingForm bookingForm = new BookingForm(
                flightId,
                departure,
                destination,
                depDateTime,
                arrDateTime,
                aircraftNo,
                flightStatus
            );

            this.Hide();
            bookingForm.ShowDialog();
        }




        private void dgvflight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
