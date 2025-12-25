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
            MessageBox.Show(
    "TB1 = [" + textBox1.Text + "]\n" +
    "TB4 = [" + textBox4.Text + "]\n" +
    "TB5 = [" + textBox5.Text + "]"
);

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=D:\AIUB\Fall 25-26\OOP 2\US-Bangla-Airline-Management-App\FlightSearches.mdf;
    Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sq = new SqlCommand(
    "INSERT INTO dbo.userInfo (FullName, Email, Npass) VALUES (@FullName, @Email, @Npass)",
    conn
);

            sq.Parameters.AddWithValue("@FullName", textBox1.Text);
            sq.Parameters.AddWithValue("@Email", textBox4.Text);
            sq.Parameters.AddWithValue("@Npass", textBox5.Text);

            int rows = sq.ExecuteNonQuery();
            MessageBox.Show("Rows inserted = " + rows);

            //sq.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("User added successfully");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInFormCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
