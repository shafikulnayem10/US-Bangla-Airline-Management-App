namespace US_Bangla_Airline_Management_App
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.BookingFormUserNameTxtBox = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.textDepartureDateTime = new System.Windows.Forms.Label();
            this.ArrivalDateTime = new System.Windows.Forms.Label();
            this.FlightStatus = new System.Windows.Forms.Label();
            this.AircraftNo = new System.Windows.Forms.Label();
            this.BookingFormNIDTxtBox = new System.Windows.Forms.TextBox();
            this.BookingFormUNTxtBox = new System.Windows.Forms.TextBox();
            this.BookingFormSeatNumberTxtBox = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.textDepartureDate = new System.Windows.Forms.TextBox();
            this.textArrivalDate = new System.Windows.Forms.TextBox();
            this.textFlightStatus = new System.Windows.Forms.TextBox();
            this.textAircraftNo = new System.Windows.Forms.TextBox();
            this.BookingFormBookFlightBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.back);
            this.mainPanel.Controls.Add(this.name);
            this.mainPanel.Controls.Add(this.BookingFormUserNameTxtBox);
            this.mainPanel.Controls.Add(this.phone);
            this.mainPanel.Controls.Add(this.Departure);
            this.mainPanel.Controls.Add(this.Destination);
            this.mainPanel.Controls.Add(this.textDepartureDateTime);
            this.mainPanel.Controls.Add(this.ArrivalDateTime);
            this.mainPanel.Controls.Add(this.FlightStatus);
            this.mainPanel.Controls.Add(this.AircraftNo);
            this.mainPanel.Controls.Add(this.BookingFormNIDTxtBox);
            this.mainPanel.Controls.Add(this.BookingFormUNTxtBox);
            this.mainPanel.Controls.Add(this.BookingFormSeatNumberTxtBox);
            this.mainPanel.Controls.Add(this.txtDeparture);
            this.mainPanel.Controls.Add(this.textDestination);
            this.mainPanel.Controls.Add(this.textDepartureDate);
            this.mainPanel.Controls.Add(this.textArrivalDate);
            this.mainPanel.Controls.Add(this.textFlightStatus);
            this.mainPanel.Controls.Add(this.textAircraftNo);
            this.mainPanel.Controls.Add(this.BookingFormBookFlightBtn);
            this.mainPanel.Location = new System.Drawing.Point(30, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(692, 513);
            this.mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(202, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightCoral;
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(456, 440);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 50);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 1;
            this.name.Text = "NID:";
            // 
            // BookingFormUserNameTxtBox
            // 
            this.BookingFormUserNameTxtBox.Location = new System.Drawing.Point(30, 120);
            this.BookingFormUserNameTxtBox.Name = "BookingFormUserNameTxtBox";
            this.BookingFormUserNameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.BookingFormUserNameTxtBox.TabIndex = 2;
            this.BookingFormUserNameTxtBox.Text = "User Name:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(30, 160);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 23);
            this.phone.TabIndex = 3;
            this.phone.Text = "Seat Number:";
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(30, 200);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(100, 23);
            this.Departure.TabIndex = 4;
            this.Departure.Text = "Departure:";
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(30, 240);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(100, 23);
            this.Destination.TabIndex = 5;
            this.Destination.Text = "Destination:";
            // 
            // textDepartureDateTime
            // 
            this.textDepartureDateTime.Location = new System.Drawing.Point(30, 280);
            this.textDepartureDateTime.Name = "textDepartureDateTime";
            this.textDepartureDateTime.Size = new System.Drawing.Size(100, 23);
            this.textDepartureDateTime.TabIndex = 6;
            this.textDepartureDateTime.Text = "Departure Time:";
            // 
            // ArrivalDateTime
            // 
            this.ArrivalDateTime.Location = new System.Drawing.Point(30, 320);
            this.ArrivalDateTime.Name = "ArrivalDateTime";
            this.ArrivalDateTime.Size = new System.Drawing.Size(100, 23);
            this.ArrivalDateTime.TabIndex = 7;
            this.ArrivalDateTime.Text = "Arrival Time:";
            // 
            // FlightStatus
            // 
            this.FlightStatus.Location = new System.Drawing.Point(30, 360);
            this.FlightStatus.Name = "FlightStatus";
            this.FlightStatus.Size = new System.Drawing.Size(100, 23);
            this.FlightStatus.TabIndex = 8;
            this.FlightStatus.Text = "Flight Status:";
            // 
            // AircraftNo
            // 
            this.AircraftNo.Location = new System.Drawing.Point(30, 400);
            this.AircraftNo.Name = "AircraftNo";
            this.AircraftNo.Size = new System.Drawing.Size(100, 23);
            this.AircraftNo.TabIndex = 9;
            this.AircraftNo.Text = "Aircraft No:";
            // 
            // BookingFormNIDTxtBox
            // 
            this.BookingFormNIDTxtBox.Location = new System.Drawing.Point(200, 80);
            this.BookingFormNIDTxtBox.Name = "BookingFormNIDTxtBox";
            this.BookingFormNIDTxtBox.Size = new System.Drawing.Size(200, 22);
            this.BookingFormNIDTxtBox.TabIndex = 10;
            // 
            // BookingFormUNTxtBox
            // 
            this.BookingFormUNTxtBox.Location = new System.Drawing.Point(200, 120);
            this.BookingFormUNTxtBox.Name = "BookingFormUNTxtBox";
            this.BookingFormUNTxtBox.Size = new System.Drawing.Size(200, 22);
            this.BookingFormUNTxtBox.TabIndex = 11;
            // 
            // BookingFormSeatNumberTxtBox
            // 
            this.BookingFormSeatNumberTxtBox.Location = new System.Drawing.Point(200, 160);
            this.BookingFormSeatNumberTxtBox.Name = "BookingFormSeatNumberTxtBox";
            this.BookingFormSeatNumberTxtBox.Size = new System.Drawing.Size(200, 22);
            this.BookingFormSeatNumberTxtBox.TabIndex = 12;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(200, 200);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(200, 22);
            this.txtDeparture.TabIndex = 13;
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(200, 240);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(200, 22);
            this.textDestination.TabIndex = 14;
            // 
            // textDepartureDate
            // 
            this.textDepartureDate.Location = new System.Drawing.Point(200, 280);
            this.textDepartureDate.Name = "textDepartureDate";
            this.textDepartureDate.Size = new System.Drawing.Size(200, 22);
            this.textDepartureDate.TabIndex = 15;
            // 
            // textArrivalDate
            // 
            this.textArrivalDate.Location = new System.Drawing.Point(200, 320);
            this.textArrivalDate.Name = "textArrivalDate";
            this.textArrivalDate.Size = new System.Drawing.Size(200, 22);
            this.textArrivalDate.TabIndex = 16;
            // 
            // textFlightStatus
            // 
            this.textFlightStatus.Location = new System.Drawing.Point(200, 360);
            this.textFlightStatus.Name = "textFlightStatus";
            this.textFlightStatus.Size = new System.Drawing.Size(200, 22);
            this.textFlightStatus.TabIndex = 17;
            // 
            // textAircraftNo
            // 
            this.textAircraftNo.Location = new System.Drawing.Point(200, 400);
            this.textAircraftNo.Name = "textAircraftNo";
            this.textAircraftNo.Size = new System.Drawing.Size(200, 22);
            this.textAircraftNo.TabIndex = 18;
            // 
            // BookingFormBookFlightBtn
            // 
            this.BookingFormBookFlightBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.BookingFormBookFlightBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookingFormBookFlightBtn.Location = new System.Drawing.Point(180, 440);
            this.BookingFormBookFlightBtn.Name = "BookingFormBookFlightBtn";
            this.BookingFormBookFlightBtn.Size = new System.Drawing.Size(145, 50);
            this.BookingFormBookFlightBtn.TabIndex = 19;
            this.BookingFormBookFlightBtn.Text = "Book Flight";
            this.BookingFormBookFlightBtn.UseVisualStyleBackColor = false;
            this.BookingFormBookFlightBtn.Click += new System.EventHandler(this.BookingFormBookFlightBtn_Click);
            // 
            // BookingForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 539);
            this.Controls.Add(this.mainPanel);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label BookingFormUserNameTxtBox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label Departure;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.Label textDepartureDateTime;
        private System.Windows.Forms.Label ArrivalDateTime;
        private System.Windows.Forms.Label FlightStatus;
        private System.Windows.Forms.Label AircraftNo;

        private System.Windows.Forms.TextBox BookingFormNIDTxtBox;
        private System.Windows.Forms.TextBox BookingFormUNTxtBox;
        private System.Windows.Forms.TextBox BookingFormSeatNumberTxtBox;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.TextBox textDepartureDate;
        private System.Windows.Forms.TextBox textArrivalDate;
        private System.Windows.Forms.TextBox textFlightStatus;
        private System.Windows.Forms.TextBox textAircraftNo;

        private System.Windows.Forms.Button BookingFormBookFlightBtn;
        private System.Windows.Forms.Button back;
    }
}
