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
        int flightId;

        public SingleFlightForm(
            int id,
            string departure,
            string destination,
            DateTime depTime,
            DateTime arrTime,
            int totalSeats,
            int aircraftNo,
            int status
        )
        {
            InitializeComponent();

            flightId = id;

            SingleFlightFormFlightIDTxtBox.Text = id.ToString();
            SingleFlightFormDepartureTxtBox.Text = departure;
            SingleFlightFormDestinationTxtBox.Text = destination;
            SingleFlightFormDepartureDateTime.Value = depTime;
            SingleFlightFormArrivalDateTime.Value = arrTime;
            SingleFlightFormTotalSeatsTxtBox.Text = totalSeats.ToString();
            SingleFlightFormAircraftNoTxtBox.Text = aircraftNo.ToString();

            SingleFlightFormStatusCmbBox.SelectedIndex =
                status == 1 ? 0 : 1;

            // 🔒 READ ONLY fields
            SingleFlightFormFlightIDTxtBox.ReadOnly = true;
            SingleFlightFormAircraftNoTxtBox.ReadOnly = true;
            SingleFlightFormTotalSeatsTxtBox.ReadOnly = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void SingleFlightFormUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Flight.UpdateFlight(
                    flightId,
                    SingleFlightFormDepartureTxtBox.Text,
                    SingleFlightFormDestinationTxtBox.Text,
                    SingleFlightFormDepartureDateTime.Value,
                    SingleFlightFormArrivalDateTime.Value,
                    int.Parse(SingleFlightFormTotalSeatsTxtBox.Text),
                    int.Parse(SingleFlightFormAircraftNoTxtBox.Text),
                    SingleFlightFormStatusCmbBox.SelectedIndex == 0 ? 1 : 0
                );

                MessageBox.Show(
                    "Flight updated successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
