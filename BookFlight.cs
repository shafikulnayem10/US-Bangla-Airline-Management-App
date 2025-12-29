/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
           
        }
    }
}
*/

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
    public partial class BookFlight : Form
    {
       
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\regisdata.mdf;
              Integrated Security=True;
              Connect Timeout=30";

        public BookFlight()
        {
            InitializeComponent();
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(age.Text) ||
                string.IsNullOrWhiteSpace(nid.Text) )
             //   nationality.SelectedIndex == -1 ||
              //  destination.SelectedIndex == -1)
            {
                MessageBox.Show("fullfilled table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Age check
            if (!int.TryParse(age.Text, out int passengerAge) || passengerAge <= 0 || passengerAge > 120)
            {
                MessageBox.Show("age 1-120", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // INSERT 
            string query = @"INSERT INTO Bookings 
                            (FlightCode, PassengerName, Age, NID, Nationality, Destination, FlightDate)
                            VALUES (@FlightCode, @PassengerName, @Age, @NID, @Nationality, @Destination, @FlightDate)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) 
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FlightCode", id.Text.Trim());
                        cmd.Parameters.AddWithValue("@PassengerName", name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Age", passengerAge);
                        cmd.Parameters.AddWithValue("@NID", nid.Text.Trim());
                      //  cmd.Parameters.AddWithValue("@Nationality", nationality.SelectedItem.ToString());
                      //  cmd.Parameters.AddWithValue("@Destination", destination.SelectedItem.ToString());
                       // cmd.Parameters.AddWithValue("@FlightDate", date.Value.Date); // date = তোমার DateTimePicker

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Rows inserted = " + rows + "\nbooking successfull",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); 
                            
                        }
                        else
                        {
                            MessageBox.Show("database not saved", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}