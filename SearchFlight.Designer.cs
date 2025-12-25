namespace FlightBooking
{
    partial class SearchFlight
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.CheckBox cbDhakaSylhet;
        private System.Windows.Forms.CheckBox cbDhakaBandarban;
        private System.Windows.Forms.CheckBox cbDhakaCox;

        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.CheckBox cbDate1;
        private System.Windows.Forms.CheckBox cbDate2;
        private System.Windows.Forms.CheckBox cbDate3;

        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.CheckBox cbBusiness;
        private System.Windows.Forms.CheckBox cbPremium;
        private System.Windows.Forms.CheckBox cbNormal;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.cbDhakaSylhet = new System.Windows.Forms.CheckBox();
            this.cbDhakaBandarban = new System.Windows.Forms.CheckBox();
            this.cbDhakaCox = new System.Windows.Forms.CheckBox();

            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.cbDate1 = new System.Windows.Forms.CheckBox();
            this.cbDate2 = new System.Windows.Forms.CheckBox();
            this.cbDate3 = new System.Windows.Forms.CheckBox();

            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.cbBusiness = new System.Windows.Forms.CheckBox();
            this.cbPremium = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();

            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Text = "Destination";
            this.groupBoxDestination.Controls.Add(this.cbDhakaSylhet);
            this.groupBoxDestination.Controls.Add(this.cbDhakaBandarban);
            this.groupBoxDestination.Controls.Add(this.cbDhakaCox);
            this.groupBoxDestination.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDestination.Size = new System.Drawing.Size(200, 120);

            this.cbDhakaSylhet.Text = "Dhaka to Sylhet";
            this.cbDhakaSylhet.Location = new System.Drawing.Point(10, 20);
            this.cbDhakaBandarban.Text = "Dhaka to Bandarban";
            this.cbDhakaBandarban.Location = new System.Drawing.Point(10, 45);
            this.cbDhakaCox.Text = "Dhaka to Cox's Bazar";
            this.cbDhakaCox.Location = new System.Drawing.Point(10, 70);

            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Text = "Travel Date";
            this.groupBoxDate.Controls.Add(this.cbDate1);
            this.groupBoxDate.Controls.Add(this.cbDate2);
            this.groupBoxDate.Controls.Add(this.cbDate3);
            this.groupBoxDate.Location = new System.Drawing.Point(250, 20);
            this.groupBoxDate.Size = new System.Drawing.Size(200, 120);

            this.cbDate1.Text = "2025-12-26";
            this.cbDate1.Location = new System.Drawing.Point(10, 20);
            this.cbDate2.Text = "2025-12-27";
            this.cbDate2.Location = new System.Drawing.Point(10, 45);
            this.cbDate3.Text = "2025-12-28";
            this.cbDate3.Location = new System.Drawing.Point(10, 70);

            // 
            // groupBoxClass
            // 
            this.groupBoxClass.Text = "Class";
            this.groupBoxClass.Controls.Add(this.cbBusiness);
            this.groupBoxClass.Controls.Add(this.cbPremium);
            this.groupBoxClass.Controls.Add(this.cbNormal);
            this.groupBoxClass.Location = new System.Drawing.Point(480, 20);
            this.groupBoxClass.Size = new System.Drawing.Size(200, 120);

            this.cbBusiness.Text = "Business Class";
            this.cbBusiness.Location = new System.Drawing.Point(10, 20);
            this.cbPremium.Text = "Premium Class";
            this.cbPremium.Location = new System.Drawing.Point(10, 45);
            this.cbNormal.Text = "Normal Class";
            this.cbNormal.Location = new System.Drawing.Point(10, 70);

            // 
            // btnSearch
            // 
            this.btnSearch.Text = "Search Flight";
            this.btnSearch.Location = new System.Drawing.Point(20, 160);
            this.btnSearch.Size = new System.Drawing.Size(150, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(20, 210);
            this.lbResult.Size = new System.Drawing.Size(660, 200);

            // 
            // SearchFlight
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.groupBoxDestination);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbResult);
            this.Text = "Search Flight";
        }
    }
}
