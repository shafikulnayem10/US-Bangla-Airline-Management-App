
namespace US_Bangla_Airline_Management_App
{
    partial class staffdashboard
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
            this.bookingFlight = new System.Windows.Forms.Button();
            this.Availabeflightlabel = new System.Windows.Forms.Label();
            this.staffbookingGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.StaffDashboardFormProfileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffbookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingFlight
            // 
            this.bookingFlight.BackColor = System.Drawing.Color.PaleGreen;
            this.bookingFlight.Location = new System.Drawing.Point(606, 331);
            this.bookingFlight.Name = "bookingFlight";
            this.bookingFlight.Size = new System.Drawing.Size(157, 45);
            this.bookingFlight.TabIndex = 1;
            this.bookingFlight.Text = "Book  Flight";
            this.bookingFlight.UseVisualStyleBackColor = false;
            this.bookingFlight.Click += new System.EventHandler(this.bookingFlight_Click);
            // 
            // Availabeflightlabel
            // 
            this.Availabeflightlabel.AutoSize = true;
            this.Availabeflightlabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Availabeflightlabel.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availabeflightlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Availabeflightlabel.Location = new System.Drawing.Point(304, 24);
            this.Availabeflightlabel.Name = "Availabeflightlabel";
            this.Availabeflightlabel.Size = new System.Drawing.Size(153, 22);
            this.Availabeflightlabel.TabIndex = 2;
            this.Availabeflightlabel.Text = "Available Flights";
            // 
            // staffbookingGridView
            // 
            this.staffbookingGridView.AllowUserToAddRows = false;
            this.staffbookingGridView.AllowUserToDeleteRows = false;
            this.staffbookingGridView.AllowUserToResizeColumns = false;
            this.staffbookingGridView.AllowUserToResizeRows = false;
            this.staffbookingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffbookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffbookingGridView.Location = new System.Drawing.Point(52, 67);
            this.staffbookingGridView.Name = "staffbookingGridView";
            this.staffbookingGridView.ReadOnly = true;
            this.staffbookingGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.staffbookingGridView.RowTemplate.Height = 24;
            this.staffbookingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffbookingGridView.Size = new System.Drawing.Size(736, 232);
            this.staffbookingGridView.TabIndex = 3;
            this.staffbookingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffbookingGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by id";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(52, 354);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(143, 22);
            this.searchtextBox.TabIndex = 5;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // StaffDashboardFormProfileBtn
            // 
            this.StaffDashboardFormProfileBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.StaffDashboardFormProfileBtn.Location = new System.Drawing.Point(576, 12);
            this.StaffDashboardFormProfileBtn.Name = "StaffDashboardFormProfileBtn";
            this.StaffDashboardFormProfileBtn.Size = new System.Drawing.Size(157, 45);
            this.StaffDashboardFormProfileBtn.TabIndex = 6;
            this.StaffDashboardFormProfileBtn.Text = "Profile";
            this.StaffDashboardFormProfileBtn.UseVisualStyleBackColor = false;
            this.StaffDashboardFormProfileBtn.Click += new System.EventHandler(this.StaffDashboardFormProfileBtn_Click);
            // 
            // staffdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffDashboardFormProfileBtn);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffbookingGridView);
            this.Controls.Add(this.Availabeflightlabel);
            this.Controls.Add(this.bookingFlight);
            this.DoubleBuffered = true;
            this.Name = "staffdashboard";
            this.Text = "Staff Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.staffbookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bookingFlight;
        private System.Windows.Forms.Label Availabeflightlabel;
        private System.Windows.Forms.DataGridView staffbookingGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button StaffDashboardFormProfileBtn;
    }
}