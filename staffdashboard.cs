using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class staffdashboard : Form
    {
        public staffdashboard()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                showAllflight();
            }
        }

        public static DataTable GetAllFlight(string flightIdText)
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                string query = @"SELECT FlightID, Departure, Destination,
                                        DepartureDateTime, ArrivalDateTime,
                                        TotalSeats, AircraftNo, FlightStatus
                                 FROM FlightTable";

                SqlDataAdapter sda;

                if (!string.IsNullOrWhiteSpace(flightIdText))
                {
                    query += " WHERE FlightID = @fid";
                    sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.Parameters.AddWithValue(
                        "@fid", Convert.ToInt32(flightIdText)
                    );
                }
                else
                {
                    sda = new SqlDataAdapter(query, con);
                }

                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        private void showAllflight()
        {
            staffbookingGridView.DataSource = GetAllFlight("");
            staffbookingGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffbookingGridView.MultiSelect = false;
        }

        private void bookingFlight_Click(object sender, EventArgs e)
        {
            if (staffbookingGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight");
                return;
            }

            DataGridViewRow row = staffbookingGridView.SelectedRows[0];

            int FlightID = Convert.ToInt32(row.Cells["FlightID"].Value);
            string Departure = row.Cells["Departure"].Value.ToString();
            string Destination = row.Cells["Destination"].Value.ToString();

            DateTime depTime = Convert.ToDateTime(row.Cells["DepartureDateTime"].Value);
            string DepartureDateTime = depTime.ToString("yyyy-MM-dd HH:mm");

            DateTime arrTime = Convert.ToDateTime(row.Cells["ArrivalDateTime"].Value);
            string ArrivalDateTime = arrTime.ToString("yyyy-MM-dd HH:mm");

            int TotalSeats = Convert.ToInt32(row.Cells["TotalSeats"].Value);
            int AircraftNo = Convert.ToInt32(row.Cells["AircraftNo"].Value);
            int FlightStatus = Convert.ToInt32(row.Cells["FlightStatus"].Value);

            staffForm sf = new staffForm(
                Departure,
                Destination,
                DepartureDateTime,
                ArrivalDateTime,
                TotalSeats,
                AircraftNo,
                FlightStatus,
                FlightID
            );

            sf.Show();
            this.Hide();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchtextBox.Text))
            {
                showAllflight();
                return;
            }

            if (!int.TryParse(searchtextBox.Text.Trim(), out _))
            {
                return;
            }

            staffbookingGridView.DataSource =
                GetAllFlight(searchtextBox.Text.Trim());
        }

        private void staffbookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void StaffDashboardFormProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileNavigator.OpenProfile();
        }
    }
}
