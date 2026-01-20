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
        }

        private void AvailableFlight_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void show_Click(object sender, EventArgs e) { }

        private void LoadFlights()
        {
            SqlConnection con = DbConfig.GetConnection();

            try
            {
                con.Open();

                string query = @"
            SELECT
                FlightID        AS [Flight ID],
                Departure       AS [Departure],
                Destination     AS [Destination],
                DepartureDateTime AS [Departure Time],
                ArrivalDateTime   AS [Arrival Time],
                TotalSeats      AS [Total Seats],
                AircraftNo      AS [Aircraft No],
                FlightStatus    AS [Status]
            FROM FlightTable
        ";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvflight.DataSource = dt;

                
                dgvflight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvflight.ReadOnly = true;
                dgvflight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvflight.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerDashboard().Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (dgvflight.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a flight first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DataGridViewRow row = dgvflight.SelectedRows[0];

            int flightId = Convert.ToInt32(row.Cells["Flight ID"].Value);

            string departure = row.Cells["Departure"].Value.ToString();
            string destination = row.Cells["Destination"].Value.ToString();
            string depDateTime = row.Cells["Departure Time"].Value.ToString();
            string arrDateTime = row.Cells["Arrival Time"].Value.ToString();
            string aircraftNo = row.Cells["Aircraft No"].Value.ToString();
            string flightStatus = row.Cells["Status"].Value.ToString();

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
