
namespace US_Bangla_Airline_Management_App
{
    partial class BookingList
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
            this.bookinglistGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookinglistGridView
            // 
            this.bookinglistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinglistGridView.Location = new System.Drawing.Point(12, 12);
            this.bookinglistGridView.Name = "bookinglistGridView";
            this.bookinglistGridView.RowHeadersWidth = 51;
            this.bookinglistGridView.RowTemplate.Height = 24;
            this.bookinglistGridView.Size = new System.Drawing.Size(962, 405);
            this.bookinglistGridView.TabIndex = 0;
            this.bookinglistGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookinglistGridView_CellContentClick);
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 507);
            this.Controls.Add(this.bookinglistGridView);
            this.Name = "BookingList";
            this.Text = "BookingList";
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookinglistGridView;
    }
}