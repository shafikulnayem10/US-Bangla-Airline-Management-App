using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Bangla_Airline_Management_App
{
    public static class LoggedInUser
    {
        public static int ID { get; set; }
        public static string UserName { get; set; }
        public static string Role { get; set; }
        public static int Status { get; set; }

        public static bool IsLoggedIn
        {
            get { return ID > 0; }
        }

        public static void Logout()
        {
            ID = 0;
            UserName = null;
            Role = null;
            Status = 0;
        }
    }
}

