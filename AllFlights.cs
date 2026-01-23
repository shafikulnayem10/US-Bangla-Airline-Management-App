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
            LoadAllFlights();
          
        }
       
        private void LoadAllFlights()
        {
            AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
        }

        private void AllFlightsFormAddFlightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddFlightForm f = new AddFlightForm();
            f.ShowDialog();
            AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
        }

        private void AllFlightsFormDeleteBtn_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = AllFlightsFormFlightDataTable.SelectedRows[0];
            int flightId = Convert.ToInt32(  row.Cells["FlightId"].Value  );

                var confirm = MessageBox.Show( "Are you sure you want to delete this flight?", "Confirm", MessageBoxButtons.YesNo );

                if (confirm == DialogResult.Yes)
                {
                    Flight.DeleteFlight(flightId);
                    MessageBox.Show("Flight deleted successfully.");

               
                AllFlightsFormFlightDataTable.DataSource = Flight.GetAllFlights();
                }
            

        }

        private void AllFlightsFormEditFlightBtn_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = AllFlightsFormFlightDataTable.SelectedRows[0];

            int flightId = Convert.ToInt32(row.Cells["FlightID"].Value);
            string departure = row.Cells["Departure"].Value.ToString();
            string destination = row.Cells["Destination"].Value.ToString();
            DateTime depTime = Convert.ToDateTime(row.Cells["DepartureDateTime"].Value);
            DateTime arrTime = Convert.ToDateTime(row.Cells["ArrivalDateTime"].Value);
            int totalSeats = Convert.ToInt32(row.Cells["TotalSeats"].Value);
            int aircraftNo = Convert.ToInt32(row.Cells["AircraftNo"].Value);
            int status = Convert.ToInt32(row.Cells["FlightStatus"].Value);

            SingleFlightForm frm = new SingleFlightForm(  flightId,  departure,  destination,  depTime,  arrTime, totalSeats,  aircraftNo,  status);

            frm.ShowDialog();

          
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
