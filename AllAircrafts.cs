using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class AllAircrafts : Form
    {
        public AllAircrafts()
        {
            InitializeComponent();

            // 🔥 Form খুললেই aircraft list load হবে
            LoadAllAircrafts();
        }

        private void LoadAllAircrafts()
        {
            try
            {
                using (SqlConnection con = DbConfig.GetConnection())
                {
                    string query = @"
                        SELECT 
                            AircraftNo,
                            AircraftModel,
                            Manufacturer,
                            Capacity
                        FROM AircraftTable";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    AllAircraftsFormDatatable.DataSource = dt;

                    // UI polish (optional but pro)
                    AllAircraftsFormDatatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AllAircraftsFormDatatable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AllAircraftsFormDatatable.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading aircrafts:\n" + ex.Message);
            }
        }

        private void AllAircraftsFormAddAircraftBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAircraft a = new AddAircraft();
            a.Show();
        }

        private void AllAircraftFormEditAircraftBtn_Click(object sender, EventArgs e)
        {
            if (AllAircraftsFormDatatable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an aircraft first");
                return;
            }

            DataGridViewRow row = AllAircraftsFormDatatable.SelectedRows[0];

            int aircraftNo = Convert.ToInt32(row.Cells["AircraftNo"].Value);
            string model = row.Cells["AircraftModel"].Value.ToString();
            string manufacturer = row.Cells["Manufacturer"].Value.ToString();
            int capacity = Convert.ToInt32(row.Cells["Capacity"].Value);

            this.Hide();
            SingleAircraft sa = new SingleAircraft(
                aircraftNo,
                model,
                manufacturer,
                capacity
            );
            sa.Show();
        }


        private void AllAircraftFormDeleteAircraftBtn_Click(object sender, EventArgs e)
        {
            if (AllAircraftsFormDatatable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an aircraft first");
                return;
            }

            int aircraftNo = Convert.ToInt32(
                AllAircraftsFormDatatable.SelectedRows[0].Cells["AircraftNo"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this aircraft?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = DbConfig.GetConnection())
                    {
                        con.Open();

                        string query = "DELETE FROM AircraftTable WHERE AircraftNo = @AircraftNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@AircraftNo", aircraftNo);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Aircraft deleted successfully ✈️");

                    // 🔥 Refresh DataGridView
                    LoadAllAircrafts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed:\n" + ex.Message);
                }
            }
        }

        private void AllAircraftsFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }
    }
}

