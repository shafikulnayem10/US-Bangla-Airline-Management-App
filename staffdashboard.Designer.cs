
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
            this.label1 = new System.Windows.Forms.Label();
            this.staffbookingGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staffbookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingFlight
            // 
            this.bookingFlight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bookingFlight.Location = new System.Drawing.Point(582, 200);
            this.bookingFlight.Name = "bookingFlight";
            this.bookingFlight.Size = new System.Drawing.Size(157, 45);
            this.bookingFlight.TabIndex = 1;
            this.bookingFlight.Text = "Book  Flight";
            this.bookingFlight.UseVisualStyleBackColor = false;
            this.bookingFlight.Click += new System.EventHandler(this.bookingFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Flight";
            // 
            // staffbookingGridView
            // 
            this.staffbookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffbookingGridView.Location = new System.Drawing.Point(44, 58);
            this.staffbookingGridView.Name = "staffbookingGridView";
            this.staffbookingGridView.RowHeadersWidth = 51;
            this.staffbookingGridView.RowTemplate.Height = 24;
            this.staffbookingGridView.Size = new System.Drawing.Size(506, 356);
            this.staffbookingGridView.TabIndex = 3;
            this.staffbookingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffbookingGridView_CellContentClick);
            // 
            // staffdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffbookingGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingFlight);
            this.Name = "staffdashboard";
            this.Text = "Staff Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.staffbookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bookingFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView staffbookingGridView;
    }
}