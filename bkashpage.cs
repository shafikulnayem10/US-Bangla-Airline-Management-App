using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class bkashpage : Form
    {
        public bkashpage()
        {
            InitializeComponent();
        }

        private void numbertxtbox_TextChanged(object sender, EventArgs e)
        {
            if (numbertxtbox.Text.Length == 0) return;

            if (!long.TryParse(numbertxtbox.Text, out _))
            {
                MessageBox.Show("Only numbers are allowed");
                numbertxtbox.Clear();
                numbertxtbox.Focus();
                return;
            }

            if (numbertxtbox.Text.Length > 11)
            {
                MessageBox.Show("Number must be exactly 11 digits");
                numbertxtbox.Clear();
                numbertxtbox.Focus();
            }
        }

        private void pintxtbox_TextChanged(object sender, EventArgs e)
        {
            if (pintxtbox.Text.Length == 0) return;

            if (!int.TryParse(pintxtbox.Text, out _))
            {
                MessageBox.Show("Only numbers are allowed");
                pintxtbox.Clear();
                pintxtbox.Focus();
                return;
            }

            if (pintxtbox.Text.Length > 5)
            {
                MessageBox.Show("PIN must be exactly 5 digits");
                pintxtbox.Clear();
                pintxtbox.Focus();
            }
        }

       
        public static void BkashNumberStore(string phone)
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                con.Open();
                string q =
                    "INSERT INTO paymentphonenumbertable (Phone_Number) VALUES (@p)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.ExecuteNonQuery();
            }
        }

        
        public static void UpdatePaymentAndBookingStatus()
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE BookingFlightsTable
                    SET 
                        PaymentStatus = 1,
                        BookingStatus = 1
                    WHERE BookingID = (
                        SELECT TOP 1 BookingID
                        FROM BookingFlightsTable
                        WHERE UserID = @uid
                        ORDER BY BookingID DESC
                    )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", LoggedInUser.ID);
                cmd.ExecuteNonQuery();
            }
        }

        
        private void proceedbtn_Click(object sender, EventArgs e)
        {
            if (numbertxtbox.Text.Length != 11)
            {
                MessageBox.Show("Invalid number");
                return;
            }

            if (pintxtbox.Text.Length != 5)
            {
                MessageBox.Show("Invalid PIN");
                return;
            }

            
            BkashNumberStore(numbertxtbox.Text);

            
            UpdatePaymentAndBookingStatus();

            MessageBox.Show(
                "Payment Successful!\nBooking Confirmed.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            new CustomerDashboard().Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pintxt_Click_1(object sender, EventArgs e)
        {
           
        }

        private void nmbrtxt_Click_1(object sender, EventArgs e)
        {
        }

        private void bkashname_Load(object sender, EventArgs e)
        {
            
        }

    }
}

