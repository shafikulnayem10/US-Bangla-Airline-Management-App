using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class staffbookinglist : Form
    {
        public staffbookinglist()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                ShowAllBooking();
            }
        }

        private void staffbookinglist_Load(object sender, EventArgs e)
        {
            // Hide Primary Key column for UI cleanliness
            if (staffbookinglistGridView.Columns.Contains("staffBookingID"))
            {
                staffbookinglistGridView.Columns["staffBookingID"].Visible = false;
            }
        }

        private void ShowAllBooking()
        {
            staffbookinglistGridView.DataSource = GetStaffBookingList("");

            staffbookinglistGridView.AutoGenerateColumns = true;
            staffbookinglistGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            staffbookinglistGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            staffbookinglistGridView.ReadOnly = true;
            staffbookinglistGridView.AllowUserToAddRows = false;
            staffbookinglistGridView.MultiSelect = false;
        }

        public static DataTable GetStaffBookingList(string searchText)
        {
            using (SqlConnection con = DbConfig.GetConnection())
            {
                string query =
                    @"SELECT *
                      FROM Staffbookingtable";

                SqlDataAdapter sda;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query += " WHERE customer_Name LIKE @search";
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

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            staffbookinglistGridView.DataSource =
                GetStaffBookingList(searchtextBox.Text.Trim());
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            staffbookinglistGridView.DataSource =
                GetStaffBookingList(searchtextBox.Text.Trim());
        }

        private void BookingListFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }
        private void staffbookinglistGridView_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e
)
        {
            // intentionally left blank
        }

        private void staffBookingListFormDeleteBtn_Click(object sender, EventArgs e)
        {
            if (staffbookinglistGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a booking first",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DataGridViewRow row =
                staffbookinglistGridView.SelectedRows[0];

            int staffBookingID =
                Convert.ToInt32(row.Cells["staffBookingID"].Value);

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
                    string query =
                        "DELETE FROM Staffbookingtable WHERE staffBookingID = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", staffBookingID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Booking deleted successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ShowAllBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}


