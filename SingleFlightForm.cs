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
    public partial class SingleFlightForm : Form
    {
       

        public SingleFlightForm(   int id,  string departure,  string destination, DateTime depTime,  DateTime arrTime,  int totalSeats,  int aircraftNo,int status )
        {
            InitializeComponent();

           

            SingleFlightFormFlightIDTxtBox.Text = id.ToString();
            SingleFlightFormDepartureTxtBox.Text = departure;
            SingleFlightFormDestinationTxtBox.Text = destination;
            SingleFlightFormDepartureDateTime.Value = depTime;
            SingleFlightFormArrivalDateTime.Value = arrTime;
            SingleFlightFormTotalSeatsTxtBox.Text = totalSeats.ToString();
            SingleFlightFormAircraftNoTxtBox.Text = aircraftNo.ToString();

            if (status == 1)
            {
                SingleFlightFormStatusCmbBox.SelectedIndex = 0;
            }
            else
            {
                SingleFlightFormStatusCmbBox.SelectedIndex = 1;
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void SingleFlightFormUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int flightId = Convert.ToInt32( SingleFlightFormFlightIDTxtBox.Text);
                string departure = SingleFlightFormDepartureTxtBox.Text;
                string destination = SingleFlightFormDestinationTxtBox.Text;
                DateTime departureTime = SingleFlightFormDepartureDateTime.Value;
                DateTime arrivalTime = SingleFlightFormArrivalDateTime.Value;
                int totalSeats = Convert.ToInt32(SingleFlightFormTotalSeatsTxtBox.Text);
                int aircraftNo = Convert.ToInt32(SingleFlightFormAircraftNoTxtBox.Text);
                int flightStatus;

                if (SingleFlightFormStatusCmbBox.SelectedIndex == 0)
                {
                    flightStatus = 1;
                }
                else
                {
                    flightStatus = 0;
                }



                Flight.UpdateFlight( flightId,departure, destination, departureTime, arrivalTime,totalSeats,aircraftNo,flightStatus  );


                MessageBox.Show("Flight updated successfully" );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message  );
            }
        }






        private void SingleFlightFormBackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AllFlights AF = new AllFlights();
            AF.Show();
        }

        private void SingleFlightFormUpdateBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
