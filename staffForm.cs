using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace US_Bangla_Airline_Management_App
{
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }
        public staffForm(String Departure, String Destination, string DepartureDateTime, string ArrivalDateTime, int TotalSeats, int AircraftNo, int FlightStatus, int FlightID)
        {
            InitializeComponent();
            departuretextBox.Text = Departure;
            DestinationTxtBox.Text = Destination;
            departuretimetextBox.Text = DepartureDateTime;
            arrivaltextBox.Text = ArrivalDateTime;
            TotalSeatsTxtBox.Text = TotalSeats.ToString();
            AircraftNoTxtBox.Text = AircraftNo.ToString();
            flightstatustextBox.Text = FlightStatus.ToString();
            FlightidTxtBox.Text = FlightID.ToString();




        }
        public static void TicketStore(
    string customer_Name,
    string Departure,
    string Destination,
    string DepartureDateTime,
    string ArrivalDateTime,
    string TotalSeats,
    string AircraftNo,
    string FlightStatus,
    string FlightID)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string insertQuery =
                "INSERT INTO Staffbookingtable " +
                "(customer_Name, Departure, Destination, DepartureDateTime, ArrivalDateTime, " +
                "TotalSeats, AircraftNo, FlightStatus, FlightID) " +
                "VALUES (@customer_Name, @Departure, @Destination, @DepartureDateTime, @ArrivalDateTime, " +
                "@TotalSeats, @AircraftNo, @FlightStatus, @FlightID)";

            SqlCommand cmd = new SqlCommand(insertQuery, con);

            cmd.Parameters.AddWithValue("@customer_Name", customer_Name);
            cmd.Parameters.AddWithValue("@Departure", Departure);
            cmd.Parameters.AddWithValue("@Destination", Destination);
            cmd.Parameters.AddWithValue("@DepartureDateTime", DepartureDateTime);
            cmd.Parameters.AddWithValue("@ArrivalDateTime", ArrivalDateTime);
            cmd.Parameters.AddWithValue("@TotalSeats", TotalSeats);
            cmd.Parameters.AddWithValue("@AircraftNo", AircraftNo);
            cmd.Parameters.AddWithValue("@FlightStatus", FlightStatus);
            cmd.Parameters.AddWithValue("@FlightID", FlightID);

            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void AddFlightFormDestinationTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightFormTotalSeatsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffdashboard s = new staffdashboard();
            s.Show();
        }

        private void AddFlightFormAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddFlightsFormAircraftNoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightFormFlightStatusCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightFormDepartureTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelDeparture_Click(object sender, EventArgs e)
        {

        }

        private void labelDestination_Click(object sender, EventArgs e)
        {

        }

        private void labelDepartureDate_Click(object sender, EventArgs e)
        {

        }

        private void labelArrivalDate_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalSeats_Click(object sender, EventArgs e)
        {

        }

        private void labelAircraftNo_Click(object sender, EventArgs e)
        {

        }

        private void labelFlightStatus_Click(object sender, EventArgs e)
        {

        }

        private void AddFlightFormArrivalDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightFormDepartureDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }

        private void departuretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightstatustextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            TicketStore(
                nametextBox.Text,
                departuretextBox.Text,
                DestinationTxtBox.Text,
                departuretimetextBox.Text,
                arrivaltextBox.Text,
                TotalSeatsTxtBox.Text,
                AircraftNoTxtBox.Text,
                flightstatustextBox.Text,
                FlightidTxtBox.Text
            );

            MessageBox.Show(
                "Successfully Purchased",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Hide();
            staffdashboard s = new staffdashboard();
            s.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
