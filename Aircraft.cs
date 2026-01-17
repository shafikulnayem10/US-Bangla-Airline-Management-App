using System.Data;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    class Aircraft
    {
        public int AircraftNo { get; set; }
        public string AircraftModel { get; set; }
        public string Manufacturer { get; set; }
        public int Capacity { get; set; }

        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
                              Initial Catalog=US-BanglaAirlineDB;
                              Integrated Security=True";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);
            string q = "SELECT * FROM AircraftInfo";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            sda.Fill(dt);
            return dt;
        }

        public bool insert(Aircraft a)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string q = "INSERT INTO AircraftInfo VALUES (@No,@Model,@Manu,@Cap)";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@No", a.AircraftNo);
            cmd.Parameters.AddWithValue("@Model", a.AircraftModel);
            cmd.Parameters.AddWithValue("@Manu", a.Manufacturer);
            cmd.Parameters.AddWithValue("@Cap", a.Capacity);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row > 0;
        }

        public bool delete(Aircraft a)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string q = "DELETE FROM AircraftInfo WHERE AircraftNo=@No";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@No", a.AircraftNo);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row > 0;
        }
    }
}