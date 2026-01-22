using System;

using System.Data;

using System.Data.SqlClient;

using System.Windows.Forms;

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

                string query = @" 

                    SELECT BookingID, FlightID, Departure, Destination, 

                           DepartureDate, ArrivalDate, SeatNumber, FlightStatus 

                    FROM BookingFlightsTable 

                    WHERE UserID = @UserID 

                     ";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserID", LoggedInUser.ID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                CustomerBookingHistoryGridView.DataSource = dt;

               

                

                

               

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

        private void CustomerDashboardFormCancelBooking_Click(object sender, EventArgs e)

        {

         

            int bookingId = Convert.ToInt32(CustomerBookingHistoryGridView.SelectedRows[0].Cells["BookingID"].Value);

            var confirmResult = MessageBox.Show(

                "Are you sure you want to cancel this booking?",

                "Confirm Cancel",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Question

            );

            if (confirmResult == DialogResult.Yes)

            {

                DeleteBooking(bookingId);

               

                    MessageBox.Show("Booking cancelled successfully!", "Success",

                        MessageBoxButtons.OK);

                    LoadBookingHistory();

              

            }

        }

        private void  DeleteBooking(int bookingId)

        {

           

            SqlConnection con = DbConfig.GetConnection();

            try

            {

                con.Open();

                string deleteQuery = @" 

                    DELETE FROM BookingFlightsTable 

                    WHERE BookingID = @BookingID AND UserID = @UserID ";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);

                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                cmd.Parameters.AddWithValue("@UserID", LoggedInUser.ID);

                cmd.ExecuteNonQuery();

                con.Close();

              

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }

         

        }

        private void Back_Click(object sender, EventArgs e)

        {

            LogInForm loginForm = new LogInForm();

            loginForm.ShowDialog();

        }

        private void AdminDashboardLogOutBtn_Click(object sender, EventArgs e)

        {

            LoggedInUser.Logout();
            this.Close();


            new LogInForm().Show();

        }

        private void AvailableFlightBtn_Click(object sender, EventArgs e)

        {

            this.Hide();

            AvailableFlight flightsForm = new AvailableFlight();

            flightsForm.ShowDialog();

        }

        private void CustomerDashboardProfileBtn_Click(object sender, EventArgs e)

        {
            this.Hide();
            ProfileNavigator.OpenProfile();

        }

        private void CustomerBookingHistoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

    }

}

