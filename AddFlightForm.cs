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
            this.Load += new System.EventHandler(this.AddFlightForm_Load);

        }

        private void AddFlightForm_Load(object sender, EventArgs e)
        {
            DataTable dt = Flight.GetAvailableAircraft();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No available aircraft found. Please add an aircraft first.",
                    "No Aircraft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
                return;
            }

            AddFlightsFormAircraftNoTxtBox.Text =
                dt.Rows[0]["AircraftNo"].ToString();

            AddFlightFormTotalSeatsTxtBox.Text =
                dt.Rows[0]["Capacity"].ToString();

            AddFlightsFormAircraftNoTxtBox.ReadOnly = true;
            AddFlightFormTotalSeatsTxtBox.ReadOnly = true;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddFlightFormAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Flight.AddFlight(
        AddFlightFormDepartureTxtBox.Text,
        AddFlightFormDestinationTxtBox.Text,
        AddFlightFormDepartureDateTime.Value,
        AddFlightFormArrivalDateTime.Value,
        int.Parse(AddFlightFormTotalSeatsTxtBox.Text),
        int.Parse(AddFlightsFormAircraftNoTxtBox.Text), 
        AddFlightFormFlightStatusCmbBox.SelectedIndex == 0 ? 1 : 0
    );


                MessageBox.Show("Flight added successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
