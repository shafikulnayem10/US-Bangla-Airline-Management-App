using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class visa : Form
    {
        public visa()
        {
            InitializeComponent();
        }

       
        private void cvvtextBox_TextChanged(object sender, EventArgs e)
        {
            if (cvvtextBox.Text.Length == 0) return;

            if (!int.TryParse(cvvtextBox.Text, out _))
            {
                MessageBox.Show("Only numbers are allowed");
                cvvtextBox.Clear();
                cvvtextBox.Focus();
                return;
            }

            if (cvvtextBox.Text.Length > 3)
            {
                MessageBox.Show("CVV must be exactly 3 digits");
                cvvtextBox.Clear();
                cvvtextBox.Focus();
            }
        }

       
        private void holdernametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (holdernametxtbox.Text.Length == 0) return;

            foreach (char c in holdernametxtbox.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Card holder name must contain letters only");
                    holdernametxtbox.Clear();
                    holdernametxtbox.Focus();
                    return;
                }
            }
        }

        private void cardnmbrtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (cardnmbrtxtbox.Text.Length == 0) return;

            if (!long.TryParse(cardnmbrtxtbox.Text, out _))
            {
                MessageBox.Show("Only numbers are allowed");
                cardnmbrtxtbox.Clear();
                cardnmbrtxtbox.Focus();
                return;
            }

            if (cardnmbrtxtbox.Text.Length > 12)
            {
                MessageBox.Show("Card number must be exactly 12 digits");
                cardnmbrtxtbox.Clear();
                cardnmbrtxtbox.Focus();
            }
        }

        
        public static void CardNumberStore(string cardNumber)
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                con.Open();

                string query =
                    "INSERT INTO paymentcardnumber (card_number) VALUES (@card)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@card", cardNumber);
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

        
        private void paynowbtn_Click(object sender, EventArgs e)
        {
            if (cardnmbrtxtbox.Text.Length != 12)
            {
                MessageBox.Show("Invalid card number");
                return;
            }

            if (holdernametxtbox.Text.Length == 0)
            {
                MessageBox.Show("Enter card holder name");
                return;
            }

            if (cvvtextBox.Text.Length != 3)
            {
                MessageBox.Show("Invalid CVV");
                return;
            }

            
            CardNumberStore(cardnmbrtxtbox.Text);

            
            UpdatePaymentAndBookingStatus();

            MessageBox.Show(
                "Payment Successful!\nBooking Confirmed ",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
            new CustomerDashboard().Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new CustomerDashboard().Show();
        }
        
        private void visa_Load(object sender, EventArgs e)
        {
            
        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}

