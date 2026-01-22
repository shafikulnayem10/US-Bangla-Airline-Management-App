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
    public partial class AddFlightForm : Form
    {
        public AddFlightForm()
        {
            InitializeComponent();
            this.Load += AddFlightForm_Load;


        }

        private void AddFlightForm_Load(object sender, EventArgs e)
        {
            DataTable dt = Flight.GetAvailableAircraft();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show( "No available aircraft found. Please add an aircraft first.");

                this.Close();
                return;
            }

          
            AddFlightsFormAircraftNoTxtBox.Text = dt.Rows[0]["AircraftNo"].ToString();

            AddFlightFormTotalSeatsTxtBox.Text =  dt.Rows[0]["Capacity"].ToString();

          
           
           
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddFlightFormAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                string departure = AddFlightFormDepartureTxtBox.Text;
                string destination = AddFlightFormDestinationTxtBox.Text;
                DateTime departureTime = AddFlightFormDepartureDateTime.Value;
                DateTime arrivalTime = AddFlightFormArrivalDateTime.Value;
                int totalSeats = Convert.ToInt32(AddFlightFormTotalSeatsTxtBox.Text);
                int aircraftNo = Convert.ToInt32(AddFlightsFormAircraftNoTxtBox.Text);
                int flightStatus;

                if (AddFlightFormFlightStatusCmbBox.SelectedIndex == 0)
                {
                    flightStatus = 1;
                }
                else
                {
                    flightStatus = 0;
                }



                Flight.AddFlight(departure, destination, departureTime, arrivalTime, totalSeats, aircraftNo, flightStatus);

                MessageBox.Show("Flight added successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void AddFlightFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllFlights AF = new AllFlights();
            AF.Show();
        }
    }
}
