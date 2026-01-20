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
namespace US_Bangla_Airline_Management_App
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }
        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadBookingHistory();
        }

        private void LoadBookingHistory()
        {
            SqlConnection con = DbConfig.GetConnection();

            try
            {
                con.Open();

                string query = @" SELECT BookingID, FlightID, Departure, Destination, DepartureDate, ArrivalDate, SeatNumber, FlightStatus FROM BookingFlightsTable WHERE UserID = @UserID  ORDER BY DepartureDate DESC   ";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", LoggedInUser.ID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CustomerBookingHistoryGridView.DataSource = dt;

                
                CustomerBookingHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                CustomerBookingHistoryGridView.ReadOnly = true;
                CustomerBookingHistoryGridView.AllowUserToAddRows = false;
                CustomerBookingHistoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load booking history: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.ShowDialog();
        }

        private void AdminDashboardLogOutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AvailableFlightBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableFlight flightsForm = new AvailableFlight();
            flightsForm.ShowDialog();
        }

        private void CustomerDashboardProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileNavigator.OpenProfile();
    
        }

        private void CustomerDashboardFormCancelBooking_Click(object sender, EventArgs e)
        {
            if (CustomerBookingHistoryGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int bookingId = Convert.ToInt32( CustomerBookingHistoryGridView.SelectedRows[0].Cells["BookingID"].Value);



            var confirmResult = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                SqlConnection con = DbConfig.GetConnection();

                try
                {
                    con.Open();

                    string deleteQuery = @" DELETE FROM BookingFlightsTable WHERE BookingID = @BookingID AND UserID = @UserID";


                    SqlCommand cmd = new SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.Parameters.AddWithValue("@UserID", LoggedInUser.ID);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("✅ Booking cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookingHistory(); 
                    }
                    else
                    {
                        MessageBox.Show("Booking not found or already cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to cancel booking: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
