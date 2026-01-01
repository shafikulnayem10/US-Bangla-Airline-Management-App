
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
    public partial class regis : Form
    {
        public regis()
        {
            InitializeComponent();
        }

        private void Fname_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void signup_MouseClick(object sender, MouseEventArgs e)
        {
            LogInForm If = new LogInForm();
            If.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            string connection =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                  AttachDbFilename=D:\AIUB\Fall 25-26\OOP 2\FINAL-TERM\US-Bangla-Airline-Management-App-main\regisdata.mdf;
                  Integrated Security=True;
                  Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    SqlCommand sq = new SqlCommand(
                        "INSERT INTO userInfo (FullName, Email, Npass) VALUES (@FullName, @Email, @Npass)",
                        conn
                    );

                    sq.Parameters.AddWithValue("@FullName", textBox1.Text); // Full Name
                    sq.Parameters.AddWithValue("@Email", textBox4.Text);    // Email
                    sq.Parameters.AddWithValue("@Npass", textBox5.Text);    // New Password

                    int rows = sq.ExecuteNonQuery();
                    MessageBox.Show("Rows inserted = " + rows);
                }

                MessageBox.Show("User added successfully");

                LogInForm lf = new LogInForm();
                lf.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Other error: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInFormCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
