using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class BookingForm : Form
    {
        int flightId;

        public BookingForm()
        {
            InitializeComponent();
        }

        public BookingForm(
            int flightId,
            string departure,
            string destination,
            string departureDateTime,
            string arrivalDateTime,
            string aircraftNo,
            string flightStatus
        )
        {
            InitializeComponent();

            this.flightId = flightId;

            // Auto load flight info
            txtDeparture.Text = departure;
            textDestination.Text = destination;
            textDepartureDate.Text = departureDateTime;
            textArrivalDate.Text = arrivalDateTime;
            textAircraftNo.Text = aircraftNo;
            textFlightStatus.Text = flightStatus;

            // Read-only flight info
            txtDeparture.ReadOnly = true;
            textDestination.ReadOnly = true;
            textDepartureDate.ReadOnly = true;
            textArrivalDate.ReadOnly = true;
            textAircraftNo.ReadOnly = true;
            textFlightStatus.ReadOnly = true;

            // Auto load username
            BookingFormUNTxtBox.Text = LoggedInUser.UserName;
            BookingFormUNTxtBox.ReadOnly = true;

            // Seat auto-generated later
            BookingFormSeatNumberTxtBox.ReadOnly = true;
        }

        // ================= DESIGNER-SAFE EMPTY METHODS =================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // intentionally left blank
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            // Designer happy, logic not needed
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadAutoSeatNumber();
        }
        // ================================================================

        // 🔢 AUTO SEAT NUMBER GENERATOR
        private void LoadAutoSeatNumber()
        {
            SqlConnection con = DbConfig.GetConnection();

            try
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*) 
                    FROM BookingFlightsTable 
                    WHERE FlightID = @FlightID
                ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FlightID", flightId);

                int bookedSeats = Convert.ToInt32(cmd.ExecuteScalar());
                int nextSeat = bookedSeats + 1;

                BookingFormSeatNumberTxtBox.Text = nextSeat.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seat generation failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ✅ BOOK FLIGHT WITH CHECK SEAT AVAILABILITY
        private void BookingFormBookFlightBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BookingFormUNTxtBox.Text))
            {
                MessageBox.Show("Please enter NID.");
                return;
            }

            SqlConnection con = DbConfig.GetConnection();

            try
            {
                con.Open();

                // 1️⃣ CHECK SEAT AVAILABILITY
                string seatCheckQuery = "SELECT TotalSeats FROM FlightTable WHERE FlightID = @FlightID";
                SqlCommand seatCmd = new SqlCommand(seatCheckQuery, con);
                seatCmd.Parameters.AddWithValue("@FlightID", flightId);

                int totalSeats = Convert.ToInt32(seatCmd.ExecuteScalar());

                if (totalSeats <= 0)
                {
                    MessageBox.Show(
                        "❌ No seats available for this flight.",
                        "Booking Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // 2️⃣ INSERT BOOKING
                string insertBookingQuery = @"
                    INSERT INTO BookingFlightsTable
                    (UserID, UserName, FlightID, Departure, Destination,
                     DepartureDate, ArrivalDate, SeatNumber,
                     FlightStatus, PaymentStatus, BookingStatus)
                    VALUES
                    (@UserID, @UserName, @FlightID, @Departure, @Destination,
                     @DepartureDate, @ArrivalDate, @SeatNumber,
                     @FlightStatus, 0, 1)
                ";

                SqlCommand cmd = new SqlCommand(insertBookingQuery, con);

                cmd.Parameters.AddWithValue("@UserID", LoggedInUser.ID);
                cmd.Parameters.AddWithValue("@UserName", LoggedInUser.UserName);
                cmd.Parameters.AddWithValue("@FlightID", flightId);
                cmd.Parameters.AddWithValue("@Departure", txtDeparture.Text);
                cmd.Parameters.AddWithValue("@Destination", textDestination.Text);
                cmd.Parameters.AddWithValue("@DepartureDate", DateTime.Parse(textDepartureDate.Text));
                cmd.Parameters.AddWithValue("@ArrivalDate", DateTime.Parse(textArrivalDate.Text));
                cmd.Parameters.AddWithValue("@SeatNumber", BookingFormSeatNumberTxtBox.Text);
                cmd.Parameters.AddWithValue("@FlightStatus", textFlightStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "✅ Flight booked successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CustomerDashboard c = new CustomerDashboard();
                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            new AvailableFlight().Show();
        }
    }
}

