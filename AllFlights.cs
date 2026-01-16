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
    public partial class AllFlights : Form
    {
        public AllFlights()
        {
            InitializeComponent();
            this.Load += AllFlights_Load;
        }

        private void AllFlights_Load(object sender, EventArgs e)
        {
            AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
        }

        private void AllFlightsFormAddFlightBtn_Click(object sender, EventArgs e)
        {
            AddFlightForm f = new AddFlightForm();
            f.ShowDialog();
            AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
        }

        private void AllFlightsFormDeleteBtn_Click(object sender, EventArgs e)
        {
            
                if (AllFlightsFormFlightDataTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a flight first.");
                    return;
                }

                int flightId = Convert.ToInt32(
                    AllFlightsFormFlightDataTable.SelectedRows[0].Cells["FlightId"].Value
                );

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this flight?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    Flight.DeleteFlight(flightId);
                    MessageBox.Show("Flight deleted successfully.");

               
                AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
                }
            

        }

        private void AllFlightsFormEditFlightBtn_Click(object sender, EventArgs e)
        {
            if (AllFlightsFormFlightDataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a flight to edit",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            DataGridViewRow row = AllFlightsFormFlightDataTable.SelectedRows[0];

            int flightId = Convert.ToInt32(row.Cells["FlightID"].Value);
            string departure = row.Cells["Departure"].Value.ToString();
            string destination = row.Cells["Destination"].Value.ToString();
            DateTime depTime = Convert.ToDateTime(row.Cells["DepartureDateTime"].Value);
            DateTime arrTime = Convert.ToDateTime(row.Cells["ArrivalDateTime"].Value);
            int totalSeats = Convert.ToInt32(row.Cells["TotalSeats"].Value);
            int aircraftNo = Convert.ToInt32(row.Cells["AircraftNo"].Value);
            int status = Convert.ToInt32(row.Cells["FlightStatus"].Value);

            SingleFlightForm frm = new SingleFlightForm(
    flightId,
    departure,
    destination,
    depTime,
    arrTime,
    totalSeats,
    aircraftNo,
    status
);

            frm.ShowDialog();

            // update এর পরে grid refresh
            AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();


        }

        private void AllFlightsFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard AD = new AdminDashboard();
            AD.Show();

        }
    }
}
