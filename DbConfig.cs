using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    public static class DbConfig
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=USB-DB;Integrated Security=True");

           
        }
    }
}
