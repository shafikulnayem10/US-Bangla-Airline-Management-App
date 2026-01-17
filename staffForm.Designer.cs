
namespace US_Bangla_Airline_Management_App
{
    partial class staffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(360, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 37);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Add New Flight";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDeparture
            // 
            this.labelDeparture.Location = new System.Drawing.Point(180, 100);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(100, 23);
            this.labelDeparture.TabIndex = 18;
            this.labelDeparture.Text = "Departure:";
            this.labelDeparture.Click += new System.EventHandler(this.labelDeparture_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.Location = new System.Drawing.Point(180, 140);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(100, 23);
            this.labelDestination.TabIndex = 19;
            this.labelDestination.Text = "Destination:";
            this.labelDestination.Click += new System.EventHandler(this.labelDestination_Click);
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.Location = new System.Drawing.Point(180, 180);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(100, 23);
            this.labelDepartureDate.TabIndex = 20;
            this.labelDepartureDate.Text = "Departure Date:";
            this.labelDepartureDate.Click += new System.EventHandler(this.labelDepartureDate_Click);
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.Location = new System.Drawing.Point(180, 220);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(100, 23);
            this.labelArrivalDate.TabIndex = 21;
            this.labelArrivalDate.Text = "Arrival Date:";
            this.labelArrivalDate.Click += new System.EventHandler(this.labelArrivalDate_Click);
            // 
            // labelTotalSeats
            // 
            this.labelTotalSeats.Location = new System.Drawing.Point(180, 260);
            this.labelTotalSeats.Name = "labelTotalSeats";
            this.labelTotalSeats.Size = new System.Drawing.Size(100, 23);
            this.labelTotalSeats.TabIndex = 22;
            this.labelTotalSeats.Text = "Total Seats:";
            this.labelTotalSeats.Click += new System.EventHandler(this.labelTotalSeats_Click);
            // 
            // labelAircraftNo
            // 
            this.labelAircraftNo.Location = new System.Drawing.Point(180, 300);
            this.labelAircraftNo.Name = "labelAircraftNo";
            this.labelAircraftNo.Size = new System.Drawing.Size(100, 23);
            this.labelAircraftNo.TabIndex = 23;
            this.labelAircraftNo.Text = "Aircraft No:";
            this.labelAircraftNo.Click += new System.EventHandler(this.labelAircraftNo_Click);
            // 
            // labelFlightStatus
            // 
            this.labelFlightStatus.Location = new System.Drawing.Point(180, 340);
            this.labelFlightStatus.Name = "labelFlightStatus";
            this.labelFlightStatus.Size = new System.Drawing.Size(100, 23);
            this.labelFlightStatus.TabIndex = 24;
            this.labelFlightStatus.Text = "Flight Status:";
            this.labelFlightStatus.Click += new System.EventHandler(this.labelFlightStatus_Click);
            // 
            // AddFlightFormDepartureTxtBox
            // 
            this.AddFlightFormDepartureTxtBox.Location = new System.Drawing.Point(330, 100);
            this.AddFlightFormDepartureTxtBox.Name = "AddFlightFormDepartureTxtBox";
            this.AddFlightFormDepartureTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDepartureTxtBox.TabIndex = 25;
            this.AddFlightFormDepartureTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormDepartureTxtBox_TextChanged);
            // 
            // AddFlightFormDestinationTxtBox
            // 
            this.AddFlightFormDestinationTxtBox.Location = new System.Drawing.Point(330, 140);
            this.AddFlightFormDestinationTxtBox.Name = "AddFlightFormDestinationTxtBox";
            this.AddFlightFormDestinationTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDestinationTxtBox.TabIndex = 26;
            this.AddFlightFormDestinationTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormDestinationTxtBox_TextChanged);
            // 
            // AddFlightFormDepartureDateTime
            // 
            this.AddFlightFormDepartureDateTime.Location = new System.Drawing.Point(330, 180);
            this.AddFlightFormDepartureDateTime.Name = "AddFlightFormDepartureDateTime";
            this.AddFlightFormDepartureDateTime.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormDepartureDateTime.TabIndex = 27;
            this.AddFlightFormDepartureDateTime.ValueChanged += new System.EventHandler(this.AddFlightFormDepartureDateTime_ValueChanged);
            // 
            // AddFlightFormArrivalDateTime
            // 
            this.AddFlightFormArrivalDateTime.Location = new System.Drawing.Point(330, 220);
            this.AddFlightFormArrivalDateTime.Name = "AddFlightFormArrivalDateTime";
            this.AddFlightFormArrivalDateTime.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormArrivalDateTime.TabIndex = 28;
            this.AddFlightFormArrivalDateTime.ValueChanged += new System.EventHandler(this.AddFlightFormArrivalDateTime_ValueChanged);
            // 
            // AddFlightFormTotalSeatsTxtBox
            // 
            this.AddFlightFormTotalSeatsTxtBox.Location = new System.Drawing.Point(330, 260);
            this.AddFlightFormTotalSeatsTxtBox.Name = "AddFlightFormTotalSeatsTxtBox";
            this.AddFlightFormTotalSeatsTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightFormTotalSeatsTxtBox.TabIndex = 29;
            this.AddFlightFormTotalSeatsTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormTotalSeatsTxtBox_TextChanged);
            // 
            // AddFlightsFormAircraftNoTxtBox
            // 
            this.AddFlightsFormAircraftNoTxtBox.Location = new System.Drawing.Point(330, 300);
            this.AddFlightsFormAircraftNoTxtBox.Name = "AddFlightsFormAircraftNoTxtBox";
            this.AddFlightsFormAircraftNoTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AddFlightsFormAircraftNoTxtBox.TabIndex = 30;
            this.AddFlightsFormAircraftNoTxtBox.TextChanged += new System.EventHandler(this.AddFlightsFormAircraftNoTxtBox_TextChanged);
            // 
            // AddFlightFormFlightStatusCmbBox
            // 
            this.AddFlightFormFlightStatusCmbBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddFlightFormFlightStatusCmbBox.Location = new System.Drawing.Point(330, 340);
            this.AddFlightFormFlightStatusCmbBox.Name = "AddFlightFormFlightStatusCmbBox";
            this.AddFlightFormFlightStatusCmbBox.Size = new System.Drawing.Size(250, 24);
            this.AddFlightFormFlightStatusCmbBox.TabIndex = 31;
            this.AddFlightFormFlightStatusCmbBox.SelectedIndexChanged += new System.EventHandler(this.AddFlightFormFlightStatusCmbBox_SelectedIndexChanged);
            // 
            // AddFlightFormAddBtn
            // 
            this.AddFlightFormAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddFlightFormAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightFormAddBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddFlightFormAddBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightFormAddBtn.Location = new System.Drawing.Point(260, 399);
            this.AddFlightFormAddBtn.Name = "AddFlightFormAddBtn";
            this.AddFlightFormAddBtn.Size = new System.Drawing.Size(150, 40);
            this.AddFlightFormAddBtn.TabIndex = 32;
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
            this.AddFlightFormBackBtn.Location = new System.Drawing.Point(464, 399);
            this.AddFlightFormBackBtn.Name = "AddFlightFormBackBtn";
            this.AddFlightFormBackBtn.Size = new System.Drawing.Size(150, 40);
            this.AddFlightFormBackBtn.TabIndex = 33;
            this.AddFlightFormBackBtn.Text = "Back";
            this.AddFlightFormBackBtn.UseVisualStyleBackColor = false;
            this.AddFlightFormBackBtn.Click += new System.EventHandler(this.AddFlightFormBackBtn_Click);
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDeparture);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDepartureDate);
            this.Controls.Add(this.labelArrivalDate);
            this.Controls.Add(this.labelTotalSeats);
            this.Controls.Add(this.labelAircraftNo);
            this.Controls.Add(this.labelFlightStatus);
            this.Controls.Add(this.AddFlightFormDepartureTxtBox);
            this.Controls.Add(this.AddFlightFormDestinationTxtBox);
            this.Controls.Add(this.AddFlightFormDepartureDateTime);
            this.Controls.Add(this.AddFlightFormArrivalDateTime);
            this.Controls.Add(this.AddFlightFormTotalSeatsTxtBox);
            this.Controls.Add(this.AddFlightsFormAircraftNoTxtBox);
            this.Controls.Add(this.AddFlightFormFlightStatusCmbBox);
            this.Controls.Add(this.AddFlightFormAddBtn);
            this.Controls.Add(this.AddFlightFormBackBtn);
            this.Name = "staffForm";
            this.Text = "Staff Form";
            this.ResumeLayout(false);
            this.PerformLayout();

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