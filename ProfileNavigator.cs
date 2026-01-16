using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    class ProfileNavigator
    {
        public static void OpenProfile()
        {
            if (!LoggedInUser.IsLoggedIn)
            {
                MessageBox.Show("Session expired. Please login again.");
                return;
            }
            else
            {
                new UserProfileForm(LoggedInUser.ID).ShowDialog();
            }
        }

    }
}
