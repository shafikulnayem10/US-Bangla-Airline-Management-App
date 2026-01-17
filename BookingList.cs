using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class BookingList : Form
    {
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
                              Initial Catalog=USB-DB;
                              Integrated Security=True";

        public BookingList()
        {
            InitializeComponent();

            bookinglistGridView.ReadOnly = true;
            bookinglistGridView.AllowUserToAddRows = false;
            bookinglistGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += BookingList_Load;
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
            LoadBookingData();
        }

        private void LoadBookingData()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT * FROM BookingFlightsTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bookinglistGridView.DataSource = dt;
            }
        }

        private void bookinglistGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}