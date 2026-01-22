namespace US_Bangla_Airline_Management_App
{
    partial class AddFlightForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel MainPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelTotalSeats = new System.Windows.Forms.Label();
            this.labelAircraftNo = new System.Windows.Forms.Label();
            this.labelFlightStatus = new System.Windows.Forms.Label();
            this.AddFlightFormDepartureTxtBox = new System.Windows.Forms.TextBox();
            this.AddFlightFormDestinationTxtBox = new System.Windows.Forms.TextBox();
            this.AddFlightFormDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.AddFlightFormArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.AddFlightFormTotalSeatsTxtBox = new System.Windows.Forms.TextBox();
            this.AddFlightsFormAircraftNoTxtBox = new System.Windows.Forms.TextBox();
            this.AddFlightFormFlightStatusCmbBox = new System.Windows.Forms.ComboBox();
            this.AddFlightFormAddBtn = new System.Windows.Forms.Button();
            this.AddFlightFormBackBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.labelTitle);
            this.MainPanel.Controls.Add(this.labelDeparture);
            this.MainPanel.Controls.Add(this.labelDestination);
            this.MainPanel.Controls.Add(this.labelDepartureDate);
            this.MainPanel.Controls.Add(this.labelArrivalDate);
            this.MainPanel.Controls.Add(this.labelTotalSeats);
            this.MainPanel.Controls.Add(this.labelAircraftNo);
            this.MainPanel.Controls.Add(this.labelFlightStatus);
            this.MainPanel.Controls.Add(this.AddFlightFormDepartureTxtBox);
            this.MainPanel.Controls.Add(this.AddFlightFormDestinationTxtBox);
            this.MainPanel.Controls.Add(this.AddFlightFormDepartureDateTime);
            this.MainPanel.Controls.Add(this.AddFlightFormArrivalDateTime);
            this.MainPanel.Controls.Add(this.AddFlightFormTotalSeatsTxtBox);
            this.MainPanel.Controls.Add(this.AddFlightsFormAircraftNoTxtBox);
            this.MainPanel.Controls.Add(this.AddFlightFormFlightStatusCmbBox);
            this.MainPanel.Controls.Add(this.AddFlightFormAddBtn);
            this.MainPanel.Controls.Add(this.AddFlightFormBackBtn);
            this.MainPanel.Location = new System.Drawing.Point(70, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(760, 420);
            this.MainPanel.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(300, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add New Flight";
            // 
            // labelDeparture
            // 
            this.labelDeparture.Location = new System.Drawing.Point(120, 90);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(100, 23);
            this.labelDeparture.TabIndex = 1;
            this.labelDeparture.Text = "Departure:";
            // 
            // labelDestination
            // 
            this.labelDestination.Location = new System.Drawing.Point(120, 130);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(100, 23);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Destination:";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.Location = new System.Drawing.Point(120, 170);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(100, 23);
            this.labelDepartureDate.TabIndex = 3;
            this.labelDepartureDate.Text = "Departure Date:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.Location = new System.Drawing.Point(120, 210);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(100, 23);
            this.labelArrivalDate.TabIndex = 4;
            this.labelArrivalDate.Text = "Arrival Date:";
            // 
            // labelTotalSeats
            // 
            this.labelTotalSeats.Location = new System.Drawing.Point(120, 250);
            this.labelTotalSeats.Name = "labelTotalSeats";
            this.labelTotalSeats.Size = new System.Drawing.Size(100, 23);
            this.labelTotalSeats.TabIndex = 5;
            this.labelTotalSeats.Text = "Total Seats:";
            // 
            // labelAircraftNo
            // 
            this.labelAircraftNo.Location = new System.Drawing.Point(120, 290);
            this.labelAircraftNo.Name = "labelAircraftNo";
            this.labelAircraftNo.Size = new System.Drawing.Size(100, 23);
            this.labelAircraftNo.TabIndex = 6;
            this.labelAircraftNo.Text = "Aircraft No:";
            // 
            // labelFlightStatus
            // 
            this.labelFlightStatus.Location = new System.Drawing.Point(120, 330);
            this.labelFlightStatus.Name = "labelFlightStatus";
            this.labelFlightStatus.Size = new System.Drawing.Size(100, 23);
            this.labelFlightStatus.TabIndex = 7;
            this.labelFlightStatus.Text = "Flight Status:";
            // 
            // AddFlightFormDepartureTxtBox
            // 
            this.AddFlightFormDepartureTxtBox.Location = new System.Drawing.Point(270, 90);
            this.AddFlightFormDepartureTxtBox.Name = "AddFlightFormDepartureTxtBox";
            this.AddFlightFormDepartureTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDepartureTxtBox.TabIndex = 8;
            // 
            // AddFlightFormDestinationTxtBox
            // 
            this.AddFlightFormDestinationTxtBox.Location = new System.Drawing.Point(270, 130);
            this.AddFlightFormDestinationTxtBox.Name = "AddFlightFormDestinationTxtBox";
            this.AddFlightFormDestinationTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDestinationTxtBox.TabIndex = 9;
            // 
            // AddFlightFormDepartureDateTime
            // 
            this.AddFlightFormDepartureDateTime.Location = new System.Drawing.Point(270, 170);
            this.AddFlightFormDepartureDateTime.Name = "AddFlightFormDepartureDateTime";
            this.AddFlightFormDepartureDateTime.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDepartureDateTime.TabIndex = 10;
            // 
            // AddFlightFormArrivalDateTime
            // 
            this.AddFlightFormArrivalDateTime.Location = new System.Drawing.Point(270, 210);
            this.AddFlightFormArrivalDateTime.Name = "AddFlightFormArrivalDateTime";
            this.AddFlightFormArrivalDateTime.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormArrivalDateTime.TabIndex = 11;
            // 
            // AddFlightFormTotalSeatsTxtBox
            // 
            this.AddFlightFormTotalSeatsTxtBox.Location = new System.Drawing.Point(270, 250);
            this.AddFlightFormTotalSeatsTxtBox.Name = "AddFlightFormTotalSeatsTxtBox";
            this.AddFlightFormTotalSeatsTxtBox.ReadOnly = true;
            this.AddFlightFormTotalSeatsTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormTotalSeatsTxtBox.TabIndex = 12;
            // 
            // AddFlightsFormAircraftNoTxtBox
            // 
            this.AddFlightsFormAircraftNoTxtBox.Location = new System.Drawing.Point(270, 290);
            this.AddFlightsFormAircraftNoTxtBox.Name = "AddFlightsFormAircraftNoTxtBox";
            this.AddFlightsFormAircraftNoTxtBox.ReadOnly = true;
            this.AddFlightsFormAircraftNoTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightsFormAircraftNoTxtBox.TabIndex = 13;
            // 
            // AddFlightFormFlightStatusCmbBox
            // 
            this.AddFlightFormFlightStatusCmbBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddFlightFormFlightStatusCmbBox.Location = new System.Drawing.Point(270, 330);
            this.AddFlightFormFlightStatusCmbBox.Name = "AddFlightFormFlightStatusCmbBox";
            this.AddFlightFormFlightStatusCmbBox.Size = new System.Drawing.Size(250, 24);
            this.AddFlightFormFlightStatusCmbBox.TabIndex = 14;
            // 
            // AddFlightFormAddBtn
            // 
            this.AddFlightFormAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddFlightFormAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightFormAddBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddFlightFormAddBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightFormAddBtn.Location = new System.Drawing.Point(200, 370);
            this.AddFlightFormAddBtn.Name = "AddFlightFormAddBtn";
            this.AddFlightFormAddBtn.Size = new System.Drawing.Size(150, 40);
            this.AddFlightFormAddBtn.TabIndex = 15;
            this.AddFlightFormAddBtn.Text = "Add Flight";
            this.AddFlightFormAddBtn.UseVisualStyleBackColor = false;
            this.AddFlightFormAddBtn.Click += new System.EventHandler(this.AddFlightFormAddBtn_Click);
            // 
            // AddFlightFormBackBtn
            // 
            this.AddFlightFormBackBtn.BackColor = System.Drawing.Color.Gray;
            this.AddFlightFormBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightFormBackBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddFlightFormBackBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightFormBackBtn.Location = new System.Drawing.Point(410, 370);
            this.AddFlightFormBackBtn.Name = "AddFlightFormBackBtn";
            this.AddFlightFormBackBtn.Size = new System.Drawing.Size(150, 40);
            this.AddFlightFormBackBtn.TabIndex = 16;
            this.AddFlightFormBackBtn.Text = "Back";
            this.AddFlightFormBackBtn.UseVisualStyleBackColor = false;
            this.AddFlightFormBackBtn.Click += new System.EventHandler(this.AddFlightFormBackBtn_Click);
            // 
            // AddFlightForm
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flight";
            this.Load += new System.EventHandler(this.AddFlightForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelTotalSeats;
        private System.Windows.Forms.Label labelAircraftNo;
        private System.Windows.Forms.Label labelFlightStatus;

        private System.Windows.Forms.TextBox AddFlightFormDepartureTxtBox;
        private System.Windows.Forms.TextBox AddFlightFormDestinationTxtBox;
        private System.Windows.Forms.DateTimePicker AddFlightFormDepartureDateTime;
        private System.Windows.Forms.DateTimePicker AddFlightFormArrivalDateTime;
        private System.Windows.Forms.TextBox AddFlightFormTotalSeatsTxtBox;
        private System.Windows.Forms.TextBox AddFlightsFormAircraftNoTxtBox;
        private System.Windows.Forms.ComboBox AddFlightFormFlightStatusCmbBox;

        private System.Windows.Forms.Button AddFlightFormAddBtn;
        private System.Windows.Forms.Button AddFlightFormBackBtn;
    }
}

