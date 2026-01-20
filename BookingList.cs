using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class BookingList : Form
    {
        public BookingList()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                ShowAllBooking();
            }
        }

        private void ShowAllBooking()
        {
            bookinglistGridView.DataSource = GetBookingList("");
        }

        public static DataTable GetBookingList(string searchText)
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                string query = "SELECT * FROM BookingFlightsTable";

                SqlDataAdapter sda;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query += " WHERE UserName LIKE @search";
                    sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.Parameters.AddWithValue(
                        "@search", "%" + searchText + "%"
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

        private void bookinglistGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            bookinglistGridView.DataSource =
                GetBookingList(searchtextBox.Text.Trim());
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bookinglistGridView.DataSource =
                GetBookingList(searchtextBox.Text.Trim());
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
        }

        private void BookingListFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        private void bookinglistGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingListFormDeleteBtn_Click(object sender, EventArgs e)
        {
            if (bookinglistGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first");
                return;
            }

           
            DataGridViewRow row = bookinglistGridView.SelectedRows[0];
            int bookingId = Convert.ToInt32(row.Cells["BookingID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this booking?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = DbConfig.GetConnection())
                {
                    string query = "DELETE FROM BookingFlightsTable WHERE BookingID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", bookingId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking deleted successfully");

                ShowAllBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed:\n" + ex.Message);
            }
        }

    }
}

