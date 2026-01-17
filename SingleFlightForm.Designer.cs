namespace US_Bangla_Airline_Management_App
{
    partial class SingleFlightForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.labelFlightID = new System.Windows.Forms.Label();
            this.SingleFlightFormFlightIDTxtBox = new System.Windows.Forms.TextBox();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.SingleFlightFormDepartureTxtBox = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.SingleFlightFormDestinationTxtBox = new System.Windows.Forms.TextBox();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.SingleFlightFormDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.SingleFlightFormArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelTotalSeats = new System.Windows.Forms.Label();
            this.SingleFlightFormTotalSeatsTxtBox = new System.Windows.Forms.TextBox();
            this.labelAircraftNo = new System.Windows.Forms.Label();
            this.SingleFlightFormAircraftNoTxtBox = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SingleFlightFormStatusCmbBox = new System.Windows.Forms.ComboBox();
            this.SingleFlightFormUpdateBtn = new System.Windows.Forms.Button();
            this.SingleFlightFormBackBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.labelFlightID);
            this.MainPanel.Controls.Add(this.SingleFlightFormFlightIDTxtBox);
            this.MainPanel.Controls.Add(this.labelDeparture);
            this.MainPanel.Controls.Add(this.SingleFlightFormDepartureTxtBox);
            this.MainPanel.Controls.Add(this.labelDestination);
            this.MainPanel.Controls.Add(this.SingleFlightFormDestinationTxtBox);
            this.MainPanel.Controls.Add(this.labelDepartureTime);
            this.MainPanel.Controls.Add(this.SingleFlightFormDepartureDateTime);
            this.MainPanel.Controls.Add(this.labelArrivalTime);
            this.MainPanel.Controls.Add(this.SingleFlightFormArrivalDateTime);
            this.MainPanel.Controls.Add(this.labelTotalSeats);
            this.MainPanel.Controls.Add(this.SingleFlightFormTotalSeatsTxtBox);
            this.MainPanel.Controls.Add(this.labelAircraftNo);
            this.MainPanel.Controls.Add(this.SingleFlightFormAircraftNoTxtBox);
            this.MainPanel.Controls.Add(this.labelStatus);
            this.MainPanel.Controls.Add(this.SingleFlightFormStatusCmbBox);
            this.MainPanel.Controls.Add(this.SingleFlightFormUpdateBtn);
            this.MainPanel.Controls.Add(this.SingleFlightFormBackBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1149, 516);
            this.MainPanel.TabIndex = 0;
            // 
            // labelFlightID
            // 
            this.labelFlightID.AutoSize = true;
            this.labelFlightID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFlightID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelFlightID.Location = new System.Drawing.Point(50, 30);
            this.labelFlightID.Name = "labelFlightID";
            this.labelFlightID.Size = new System.Drawing.Size(73, 20);
            this.labelFlightID.TabIndex = 0;
            this.labelFlightID.Text = "Flight ID:";
            // 
            // SingleFlightFormFlightIDTxtBox
            // 
            this.SingleFlightFormFlightIDTxtBox.BackColor = System.Drawing.Color.White;
            this.SingleFlightFormFlightIDTxtBox.Location = new System.Drawing.Point(200, 30);
            this.SingleFlightFormFlightIDTxtBox.Name = "SingleFlightFormFlightIDTxtBox";
            this.SingleFlightFormFlightIDTxtBox.Size = new System.Drawing.Size(160, 22);
            this.SingleFlightFormFlightIDTxtBox.TabIndex = 1;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDeparture.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDeparture.Location = new System.Drawing.Point(50, 70);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(84, 20);
            this.labelDeparture.TabIndex = 2;
            this.labelDeparture.Text = "Departure:";
            // 
            // SingleFlightFormDepartureTxtBox
            // 
            this.SingleFlightFormDepartureTxtBox.Location = new System.Drawing.Point(200, 70);
            this.SingleFlightFormDepartureTxtBox.Name = "SingleFlightFormDepartureTxtBox";
            this.SingleFlightFormDepartureTxtBox.Size = new System.Drawing.Size(160, 22);
            this.SingleFlightFormDepartureTxtBox.TabIndex = 3;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDestination.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelDestination.Location = new System.Drawing.Point(50, 110);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(94, 20);
            this.labelDestination.TabIndex = 4;
            this.labelDestination.Text = "Destination:";
            // 
            // SingleFlightFormDestinationTxtBox
            // 
            this.SingleFlightFormDestinationTxtBox.Location = new System.Drawing.Point(200, 110);
            this.SingleFlightFormDestinationTxtBox.Name = "SingleFlightFormDestinationTxtBox";
            this.SingleFlightFormDestinationTxtBox.Size = new System.Drawing.Size(160, 22);
            this.SingleFlightFormDestinationTxtBox.TabIndex = 5;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDepartureTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelDepartureTime.Location = new System.Drawing.Point(50, 150);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(123, 20);
            this.labelDepartureTime.TabIndex = 6;
            this.labelDepartureTime.Text = "Departure Time:";
            // 
            // SingleFlightFormDepartureDateTime
            // 
            this.SingleFlightFormDepartureDateTime.Location = new System.Drawing.Point(200, 150);
            this.SingleFlightFormDepartureDateTime.Name = "SingleFlightFormDepartureDateTime";
            this.SingleFlightFormDepartureDateTime.Size = new System.Drawing.Size(160, 22);
            this.SingleFlightFormDepartureDateTime.TabIndex = 7;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelArrivalTime.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelArrivalTime.Location = new System.Drawing.Point(50, 190);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(99, 20);
            this.labelArrivalTime.TabIndex = 8;
            this.labelArrivalTime.Text = "Arrival Time:";
            // 
            // SingleFlightFormArrivalDateTime
            // 
            this.SingleFlightFormArrivalDateTime.Location = new System.Drawing.Point(200, 190);
            this.SingleFlightFormArrivalDateTime.Name = "SingleFlightFormArrivalDateTime";
            this.SingleFlightFormArrivalDateTime.Size = new System.Drawing.Size(160, 22);
            this.SingleFlightFormArrivalDateTime.TabIndex = 9;
            // 
            // labelTotalSeats
            // 
            this.labelTotalSeats.AutoSize = true;
            this.labelTotalSeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalSeats.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTotalSeats.Location = new System.Drawing.Point(50, 230);
            this.labelTotalSeats.Name = "labelTotalSeats";
            this.labelTotalSeats.Size = new System.Drawing.Size(89, 20);
            this.labelTotalSeats.TabIndex = 10;
            this.labelTotalSeats.Text = "Total Seats:";
            // 
            // SingleFlightFormTotalSeatsTxtBox
            // 
            this.SingleFlightFormTotalSeatsTxtBox.Location = new System.Drawing.Point(200, 230);
            this.SingleFlightFormTotalSeatsTxtBox.Name = "SingleFlightFormTotalSeatsTxtBox";
            this.SingleFlightFormTotalSeatsTxtBox.Size = new System.Drawing.Size(120, 22);
            this.SingleFlightFormTotalSeatsTxtBox.TabIndex = 11;
            // 
            // labelAircraftNo
            // 
            this.labelAircraftNo.AutoSize = true;
            this.labelAircraftNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAircraftNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAircraftNo.Location = new System.Drawing.Point(50, 270);
            this.labelAircraftNo.Name = "labelAircraftNo";
            this.labelAircraftNo.Size = new System.Drawing.Size(92, 20);
            this.labelAircraftNo.TabIndex = 12;
            this.labelAircraftNo.Text = "Aircraft No:";
            // 
            // SingleFlightFormAircraftNoTxtBox
            // 
            this.SingleFlightFormAircraftNoTxtBox.Location = new System.Drawing.Point(200, 270);
            this.SingleFlightFormAircraftNoTxtBox.Name = "SingleFlightFormAircraftNoTxtBox";
            this.SingleFlightFormAircraftNoTxtBox.Size = new System.Drawing.Size(120, 22);
            this.SingleFlightFormAircraftNoTxtBox.TabIndex = 13;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.Purple;
            this.labelStatus.Location = new System.Drawing.Point(50, 310);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(101, 20);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Flight Status:";
            // 
            // SingleFlightFormStatusCmbBox
            // 
            this.SingleFlightFormStatusCmbBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.SingleFlightFormStatusCmbBox.Location = new System.Drawing.Point(200, 310);
            this.SingleFlightFormStatusCmbBox.Name = "SingleFlightFormStatusCmbBox";
            this.SingleFlightFormStatusCmbBox.Size = new System.Drawing.Size(120, 24);
            this.SingleFlightFormStatusCmbBox.TabIndex = 15;
            // 
            // SingleFlightFormUpdateBtn
            // 
            this.SingleFlightFormUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.SingleFlightFormUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleFlightFormUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.SingleFlightFormUpdateBtn.Location = new System.Drawing.Point(200, 360);
            this.SingleFlightFormUpdateBtn.Name = "SingleFlightFormUpdateBtn";
            this.SingleFlightFormUpdateBtn.Size = new System.Drawing.Size(120, 40);
            this.SingleFlightFormUpdateBtn.TabIndex = 16;
            this.SingleFlightFormUpdateBtn.Text = "Update";
            this.SingleFlightFormUpdateBtn.UseVisualStyleBackColor = false;
            this.SingleFlightFormUpdateBtn.Click += new System.EventHandler(this.SingleFlightFormUpdateBtn_Click_1);
            // 
            // SingleFlightFormBackBtn
            // 
            this.SingleFlightFormBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.SingleFlightFormBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleFlightFormBackBtn.ForeColor = System.Drawing.Color.White;
            this.SingleFlightFormBackBtn.Location = new System.Drawing.Point(360, 360);
            this.SingleFlightFormBackBtn.Name = "SingleFlightFormBackBtn";
            this.SingleFlightFormBackBtn.Size = new System.Drawing.Size(120, 40);
            this.SingleFlightFormBackBtn.TabIndex = 17;
            this.SingleFlightFormBackBtn.Text = "Back";
            this.SingleFlightFormBackBtn.UseVisualStyleBackColor = false;
            this.SingleFlightFormBackBtn.Click += new System.EventHandler(this.SingleFlightFormBackBtn_Click_1);
            // 
            // SingleFlightForm
            // 
            this.ClientSize = new System.Drawing.Size(1149, 516);
            this.Controls.Add(this.MainPanel);
            this.Name = "SingleFlightForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label labelFlightID;
        private System.Windows.Forms.TextBox SingleFlightFormFlightIDTxtBox;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.TextBox SingleFlightFormDepartureTxtBox;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox SingleFlightFormDestinationTxtBox;
        private System.Windows.Forms.Label labelDepartureTime;
        private System.Windows.Forms.DateTimePicker SingleFlightFormDepartureDateTime;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.DateTimePicker SingleFlightFormArrivalDateTime;
        private System.Windows.Forms.Label labelTotalSeats;
        private System.Windows.Forms.TextBox SingleFlightFormTotalSeatsTxtBox;
        private System.Windows.Forms.Label labelAircraftNo;
        private System.Windows.Forms.TextBox SingleFlightFormAircraftNoTxtBox;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox SingleFlightFormStatusCmbBox;
        private System.Windows.Forms.Button SingleFlightFormUpdateBtn;
        private System.Windows.Forms.Button SingleFlightFormBackBtn;
    }
}

