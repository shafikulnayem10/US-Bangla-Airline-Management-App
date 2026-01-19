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
            // 1️⃣ Empty check
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

            // 2️⃣ Number validation
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

                    // 3️⃣ CHECK: AircraftNo already exists?
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

                    // 4️⃣ INSERT
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

                // 5️⃣ Back to AllAircrafts
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
    }
}
