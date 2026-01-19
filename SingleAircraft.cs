
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class SingleAircraft : Form
    {
        private int aircraftNo;

        public SingleAircraft(int aircraftNo, string model, string manufacturer, int capacity)
        {
            InitializeComponent();

            this.aircraftNo = aircraftNo;

            
            SingleAircraftFormAircraftNoTxtBox.Text = aircraftNo.ToString();
            SingleAircraftFormAircraftModelTxtBox.Text = model;
            SingleAircraftFormManufactuerTxtBox.Text = manufacturer;
            SingleAircraftFormCapacityTxtBox.Text = capacity.ToString();

            
            SingleAircraftFormAircraftNoTxtBox.ReadOnly = true;
        }

        private void SingleAircraftFormUpdateBtn_Click(object sender, EventArgs e)
        {
            if (
                SingleAircraftFormAircraftModelTxtBox.Text == "" ||
                SingleAircraftFormManufactuerTxtBox.Text == "" ||
                SingleAircraftFormCapacityTxtBox.Text == ""
            )
            {
                MessageBox.Show("All fields are required");
                return;
            }

            int capacity;
            if (!int.TryParse(SingleAircraftFormCapacityTxtBox.Text, out capacity))
            {
                MessageBox.Show("Capacity must be a number");
                return;
            }

            try
            {
                using (SqlConnection con = DbConfig.GetConnection())
                {
                    con.Open();

                    string query = @"
                        UPDATE AircraftTable
                        SET
                            AircraftModel = @Model,
                            Manufacturer = @Manufacturer,
                            Capacity = @Capacity
                        WHERE AircraftNo = @AircraftNo";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Model", SingleAircraftFormAircraftModelTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", SingleAircraftFormManufactuerTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Capacity", capacity);
                    cmd.Parameters.AddWithValue("@AircraftNo", aircraftNo);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Aircraft updated successfully ✈️");

                this.Hide();
                AllAircrafts a = new AllAircrafts();
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed:\n" + ex.Message);
            }
        }

        private void SingleAircraftFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllAircrafts a = new AllAircrafts();
            a.Show();
        }
    }
}

