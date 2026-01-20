using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class AddAircraft : Form
    {
        public AddAircraft()
        {
            InitializeComponent();
        }

        private void AddAircraftFormADDBtn_Click(object sender, EventArgs e)
        {
           
            if (
                AddAircraftFormAircraftNoTxtBox.Text == "" ||
                AddAircraftFormAircraftModelTxtBox.Text == "" ||
                AddAircraftFormManufacturerTxtBox.Text == "" ||
                AddAircraftFormCapacityTxtBox.Text == ""
            )
            {
                MessageBox.Show("All fields are required");
                return;
            }

            int aircraftNo;
            int capacity;

            
            if (
                !int.TryParse(AddAircraftFormAircraftNoTxtBox.Text, out aircraftNo) ||
                !int.TryParse(AddAircraftFormCapacityTxtBox.Text, out capacity)
            )
            {
                MessageBox.Show("Aircraft No and Capacity must be numbers");
                return;
            }

            try
            {
                using (SqlConnection con = DbConfig.GetConnection())
                {
                    con.Open();

                    
                    string checkQuery =
                        "SELECT COUNT(*) FROM AircraftTable WHERE AircraftNo = @AircraftNo";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@AircraftNo", aircraftNo);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show(
                            "Aircraft No already exists ❌\nPlease use a different Aircraft No."
                        );
                        return;
                    }

                    
                    string insertQuery = @"
                        INSERT INTO AircraftTable
                        (AircraftNo, AircraftModel, Manufacturer, Capacity)
                        VALUES
                        (@AircraftNo, @AircraftModel, @Manufacturer, @Capacity)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@AircraftNo", aircraftNo);
                    insertCmd.Parameters.AddWithValue(
                        "@AircraftModel",
                        AddAircraftFormAircraftModelTxtBox.Text
                    );
                    insertCmd.Parameters.AddWithValue(
                        "@Manufacturer",
                        AddAircraftFormManufacturerTxtBox.Text
                    );
                    insertCmd.Parameters.AddWithValue("@Capacity", capacity);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Aircraft added successfully ✈️");

                
                this.Hide();
                AllAircrafts a = new AllAircrafts();
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void AddAircraftFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllAircrafts a = new AllAircrafts();
            a.Show();
        }

        private void AddAircraftFormAircraftModelTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAircraftFormManufacturerTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAircraftFormCapacityTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAircraftFormAircraftNoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAircraft_Load(object sender, EventArgs e)
        {

        }
    }
}
