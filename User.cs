using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace US_Bangla_Airline_Management_App
{


        public class User
        {
           
            public int ID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public int Status { get; set; }


        public static void CreateUser(int id, string username, string password, string role)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            // Check duplicate ID or UserName
            string checkQuery =
                "SELECT COUNT(*) FROM UserTable WHERE ID=@ID OR UserName=@UserName";

            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@ID", id);
            checkCmd.Parameters.AddWithValue("@UserName", username);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                con.Close();
                throw new Exception("User ID or Username already exists!");
            }

            //  Insert new user
            string insertQuery =
                "INSERT INTO UserTable (ID, UserName, Password, Role, Status) " +
                "VALUES (@ID, @UserName, @Password, @Role, @Status)";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Status", 1);

            cmd.ExecuteNonQuery();
            con.Close();
        }



        //  READ
        public static DataRow GetUserByUsername(string username)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = "SELECT * FROM UserTable WHERE UserName = @UserName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", username.Trim());

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Close();

            if (dt.Rows.Count > 0)
                return dt.Rows[0];   // first matching user
            else
                return null;
        }

        public static DataRow GetUserById(int id)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = "SELECT * FROM UserTable WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Close();

            if (dt.Rows.Count == 1)
                return dt.Rows[0];
            else
                return null;
        }


        public static bool ReadUser(string username, string password)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "SELECT COUNT(*) FROM UserTable " +
                "WHERE UserName=@username AND Password=@password AND Status=1";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
                return true;
            else
                return false;
        }

   
 //get all users
public static DataTable GetAllUsers()
    {
        SqlConnection con = DbConfig.GetConnection();
        con.Open();

        string query = "SELECT ID, UserName, Role, Status FROM UserTable";

        SqlDataAdapter sda = new SqlDataAdapter(query, con);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        con.Close();
        return dt;
    }
        //update user
        public static bool IsUserNameTaken(string username, int currentUserId)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "SELECT COUNT(*) FROM UserTable " +
                "WHERE UserName=@UserName AND ID<>@ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@ID", currentUserId);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        public static void UpdateUser(int id, string username, string password, string role, int status)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query =
                "UPDATE UserTable SET " +
                "UserName=@UserName, Password=@Password, Role=@Role, Status=@Status " +
                "WHERE ID=@ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Status", status);

            cmd.ExecuteNonQuery();
            con.Close();
        }


        //Delete User
        public static void DeleteUser(int id)
        {
            SqlConnection con = DbConfig.GetConnection();
            con.Open();

            string query = "DELETE FROM UserTable WHERE ID=@ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
            con.Close();
        }



    }







}
