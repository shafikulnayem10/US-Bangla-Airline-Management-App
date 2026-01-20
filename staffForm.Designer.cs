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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelTotalSeats = new System.Windows.Forms.Label();
            this.labelAircraftNo = new System.Windows.Forms.Label();
            this.labelFlightStatus = new System.Windows.Forms.Label();
            this.FlightidTxtBox = new System.Windows.Forms.TextBox();
            this.DestinationTxtBox = new System.Windows.Forms.TextBox();
            this.TotalSeatsTxtBox = new System.Windows.Forms.TextBox();
            this.AircraftNoTxtBox = new System.Windows.Forms.TextBox();
            this.AddFlightFormBackBtn = new System.Windows.Forms.Button();
            this.flightstatustextBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.arrivaltextBox = new System.Windows.Forms.TextBox();
            this.departuretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departuretimetextBox = new System.Windows.Forms.TextBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(361, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 26);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Add New Flight";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDeparture
            // 
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(488, 64);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(70, 23);
            this.labelDeparture.TabIndex = 18;
            this.labelDeparture.Text = "FlightId:";
            this.labelDeparture.Click += new System.EventHandler(this.labelDeparture_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(461, 108);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(100, 23);
            this.labelDestination.TabIndex = 19;
            this.labelDestination.Text = "Destination:";
            this.labelDestination.Click += new System.EventHandler(this.labelDestination_Click);
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartureDate.Location = new System.Drawing.Point(43, 158);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(121, 22);
            this.labelDepartureDate.TabIndex = 20;
            this.labelDepartureDate.Text = "Departuretime:";
            this.labelDepartureDate.Click += new System.EventHandler(this.labelDepartureDate_Click);
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalDate.Location = new System.Drawing.Point(458, 155);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(100, 22);
            this.labelArrivalDate.TabIndex = 21;
            this.labelArrivalDate.Text = "Arrivaltime:";
            this.labelArrivalDate.Click += new System.EventHandler(this.labelArrivalDate_Click);
            // 
            // labelTotalSeats
            // 
            this.labelTotalSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSeats.Location = new System.Drawing.Point(64, 249);
            this.labelTotalSeats.Name = "labelTotalSeats";
            this.labelTotalSeats.Size = new System.Drawing.Size(100, 23);
            this.labelTotalSeats.TabIndex = 22;
            this.labelTotalSeats.Text = "Total Seats:";
            this.labelTotalSeats.Click += new System.EventHandler(this.labelTotalSeats_Click);
            // 
            // labelAircraftNo
            // 
            this.labelAircraftNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAircraftNo.Location = new System.Drawing.Point(469, 218);
            this.labelAircraftNo.Name = "labelAircraftNo";
            this.labelAircraftNo.Size = new System.Drawing.Size(92, 23);
            this.labelAircraftNo.TabIndex = 23;
            this.labelAircraftNo.Text = "Aircraft No:";
            this.labelAircraftNo.Click += new System.EventHandler(this.labelAircraftNo_Click);
            // 
            // labelFlightStatus
            // 
            this.labelFlightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightStatus.Location = new System.Drawing.Point(90, 206);
            this.labelFlightStatus.Name = "labelFlightStatus";
            this.labelFlightStatus.Size = new System.Drawing.Size(56, 19);
            this.labelFlightStatus.TabIndex = 24;
            this.labelFlightStatus.Text = "Flight Status:";
            this.labelFlightStatus.Click += new System.EventHandler(this.labelFlightStatus_Click);
            // 
            // FlightidTxtBox
            // 
            this.FlightidTxtBox.Location = new System.Drawing.Point(564, 61);
            this.FlightidTxtBox.Name = "FlightidTxtBox";
            this.FlightidTxtBox.Size = new System.Drawing.Size(250, 22);
            this.FlightidTxtBox.TabIndex = 25;
            this.FlightidTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormDepartureTxtBox_TextChanged);
            // 
            // DestinationTxtBox
            // 
            this.DestinationTxtBox.Location = new System.Drawing.Point(567, 109);
            this.DestinationTxtBox.Name = "DestinationTxtBox";
            this.DestinationTxtBox.Size = new System.Drawing.Size(250, 22);
            this.DestinationTxtBox.TabIndex = 26;
            this.DestinationTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormDestinationTxtBox_TextChanged);
            // 
            // TotalSeatsTxtBox
            // 
            this.TotalSeatsTxtBox.Location = new System.Drawing.Point(174, 250);
            this.TotalSeatsTxtBox.Name = "TotalSeatsTxtBox";
            this.TotalSeatsTxtBox.Size = new System.Drawing.Size(250, 22);
            this.TotalSeatsTxtBox.TabIndex = 29;
            this.TotalSeatsTxtBox.TextChanged += new System.EventHandler(this.AddFlightFormTotalSeatsTxtBox_TextChanged);
            // 
            // AircraftNoTxtBox
            // 
            this.AircraftNoTxtBox.Location = new System.Drawing.Point(575, 219);
            this.AircraftNoTxtBox.Name = "AircraftNoTxtBox";
            this.AircraftNoTxtBox.Size = new System.Drawing.Size(250, 22);
            this.AircraftNoTxtBox.TabIndex = 30;
            this.AircraftNoTxtBox.TextChanged += new System.EventHandler(this.AddFlightsFormAircraftNoTxtBox_TextChanged);
            // 
            // AddFlightFormBackBtn
            // 
            this.AddFlightFormBackBtn.BackColor = System.Drawing.Color.Gray;
            this.AddFlightFormBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightFormBackBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddFlightFormBackBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightFormBackBtn.Location = new System.Drawing.Point(501, 364);
            this.AddFlightFormBackBtn.Name = "AddFlightFormBackBtn";
            this.AddFlightFormBackBtn.Size = new System.Drawing.Size(150, 40);
            this.AddFlightFormBackBtn.TabIndex = 33;
            this.AddFlightFormBackBtn.Text = "Back";
            this.AddFlightFormBackBtn.UseVisualStyleBackColor = false;
            this.AddFlightFormBackBtn.Click += new System.EventHandler(this.AddFlightFormBackBtn_Click);
            // 
            // flightstatustextBox
            // 
            this.flightstatustextBox.Location = new System.Drawing.Point(170, 202);
            this.flightstatustextBox.Name = "flightstatustextBox";
            this.flightstatustextBox.Size = new System.Drawing.Size(254, 22);
            this.flightstatustextBox.TabIndex = 34;
            this.flightstatustextBox.TextChanged += new System.EventHandler(this.flightstatustextBox_TextChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(90, 71);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(54, 17);
            this.namelabel.TabIndex = 35;
            this.namelabel.Text = "Name:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(166, 66);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(250, 22);
            this.nametextBox.TabIndex = 36;
            // 
            // arrivaltextBox
            // 
            this.arrivaltextBox.Location = new System.Drawing.Point(564, 155);
            this.arrivaltextBox.Name = "arrivaltextBox";
            this.arrivaltextBox.Size = new System.Drawing.Size(250, 22);
            this.arrivaltextBox.TabIndex = 37;
            // 
            // departuretextBox
            // 
            this.departuretextBox.Location = new System.Drawing.Point(170, 109);
            this.departuretextBox.Name = "departuretextBox";
            this.departuretextBox.Size = new System.Drawing.Size(250, 22);
            this.departuretextBox.TabIndex = 38;
            this.departuretextBox.TextChanged += new System.EventHandler(this.departuretextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Departure:";
            // 
            // departuretimetextBox
            // 
            this.departuretimetextBox.Location = new System.Drawing.Point(170, 155);
            this.departuretimetextBox.Name = "departuretimetextBox";
            this.departuretimetextBox.Size = new System.Drawing.Size(250, 22);
            this.departuretimetextBox.TabIndex = 40;
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.confirmbutton.ForeColor = System.Drawing.Color.White;
            this.confirmbutton.Location = new System.Drawing.Point(297, 364);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(150, 40);
            this.confirmbutton.TabIndex = 41;
            this.confirmbutton.Text = "Confirm Flight";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Red;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exitbutton.Location = new System.Drawing.Point(12, 456);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(70, 29);
            this.Exitbutton.TabIndex = 42;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 507);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.departuretimetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departuretextBox);
            this.Controls.Add(this.arrivaltextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.flightstatustextBox);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDeparture);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDepartureDate);
            this.Controls.Add(this.labelArrivalDate);
            this.Controls.Add(this.labelTotalSeats);
            this.Controls.Add(this.labelAircraftNo);
            this.Controls.Add(this.labelFlightStatus);
            this.Controls.Add(this.FlightidTxtBox);
            this.Controls.Add(this.DestinationTxtBox);
            this.Controls.Add(this.TotalSeatsTxtBox);
            this.Controls.Add(this.AircraftNoTxtBox);
            this.Controls.Add(this.AddFlightFormBackBtn);
            this.DoubleBuffered = true;
            this.Name = "staffForm";
            this.Text = "Staff Form";
            this.Load += new System.EventHandler(this.staffForm_Load);
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
        private System.Windows.Forms.TextBox FlightidTxtBox;
        private System.Windows.Forms.TextBox DestinationTxtBox;
        private System.Windows.Forms.TextBox TotalSeatsTxtBox;
        private System.Windows.Forms.TextBox AircraftNoTxtBox;
        private System.Windows.Forms.Button AddFlightFormBackBtn;
        private System.Windows.Forms.TextBox flightstatustextBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox arrivaltextBox;
        private System.Windows.Forms.TextBox departuretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departuretimetextBox;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}