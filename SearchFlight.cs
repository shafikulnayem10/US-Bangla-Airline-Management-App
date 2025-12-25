using System;
using System.Text;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Selected Destinations:");
            if (cbDhakaSylhet.Checked) sb.AppendLine("Dhaka to Sylhet");
            if (cbDhakaBandarban.Checked) sb.AppendLine("Dhaka to Bandarban");
            if (cbDhakaCox.Checked) sb.AppendLine("Dhaka to Cox's Bazar");

            sb.AppendLine("\nSelected Travel Dates:");
            if (cbDate1.Checked) sb.AppendLine("2025-12-26");
            if (cbDate2.Checked) sb.AppendLine("2025-12-27");
            if (cbDate3.Checked) sb.AppendLine("2025-12-28");

            sb.AppendLine("\nSelected Class:");
            if (cbBusiness.Checked) sb.AppendLine("Business Class");
            if (cbPremium.Checked) sb.AppendLine("Premium Class");
            if (cbNormal.Checked) sb.AppendLine("Normal Class");

            lbResult.Items.Clear();
            lbResult.Items.Add(sb.ToString());
        }
    }
}
