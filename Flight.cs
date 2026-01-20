using System;
using System.Data;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int TotalSeats { get; set; }
        public int AircraftNo { get; set; }
        public int FlightStatus { get; set; }

       
        public static int? GetAvailableAircraftNo()
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "SELECT TOP 1 a.AircraftNo " +
                "FROM AircraftTable a " +
                "WHERE a.AircraftNo NOT IN " +
                "(SELECT AircraftNo FROM FlightTable)";

            SqlCommand cmd = new SqlCommand(query, con);
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == null)
                return null;

            return Convert.ToInt32(result);
        }
        public static DataTable GetAvailableAircraft()
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = @"
        SELECT TOP 1 AircraftNo, Capacity
        FROM AircraftTable
        WHERE AircraftNo NOT IN (
            SELECT AircraftNo FROM FlightTable
        )";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();
            return dt;
        }


        public static void AddFlight(string departure, string destination,
            DateTime depTime, DateTime arrTime,
            int totalSeats, int aircraftNo, int status)
        {

            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "INSERT INTO FlightTable " +
                "( Departure, Destination, DepartureDateTime, ArrivalDateTime, TotalSeats, AircraftNo, FlightStatus) " +
                "VALUES (@Departure,@Destination,@Dep,@Arr,@Seats,@Aircraft,@Status)";

            SqlCommand cmd = new SqlCommand(query, con);
           
            cmd.Parameters.AddWithValue("@Departure", departure);
            cmd.Parameters.AddWithValue("@Destination", destination);
            cmd.Parameters.AddWithValue("@Dep", depTime);
            cmd.Parameters.AddWithValue("@Arr", arrTime);
            cmd.Parameters.AddWithValue("@Seats", totalSeats);
            cmd.Parameters.AddWithValue("@Aircraft", aircraftNo);
            cmd.Parameters.AddWithValue("@Status", status);

            cmd.ExecuteNonQuery();
            con.Close();
        }


       
        public static DataTable GetAllFlights()
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = "SELECT * FROM FlightTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Close();
            return dt;
        }

      
        public static void UpdateFlight(int id, string departure, string destination,
            DateTime depTime, DateTime arrTime,
            int totalSeats, int aircraftNo, int status)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "UPDATE FlightTable SET " +
                "Departure=@Departure, Destination=@Destination, " +
                "DepartureDateTime=@Dep, ArrivalDateTime=@Arr, " +
                "TotalSeats=@Seats, AircraftNo=@Aircraft, FlightStatus=@Status " +
                "WHERE FlightID=@ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Departure", departure);
            cmd.Parameters.AddWithValue("@Destination", destination);
            cmd.Parameters.AddWithValue("@Dep", depTime);
            cmd.Parameters.AddWithValue("@Arr", arrTime);
            cmd.Parameters.AddWithValue("@Seats", totalSeats);
            cmd.Parameters.AddWithValue("@Aircraft", aircraftNo);
            cmd.Parameters.AddWithValue("@Status", status);

            cmd.ExecuteNonQuery();
            con.Close();
        }

      
        public static void DeleteFlight(int flightId)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = "DELETE FROM FlightTable WHERE FlightID = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", flightId);

            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}

