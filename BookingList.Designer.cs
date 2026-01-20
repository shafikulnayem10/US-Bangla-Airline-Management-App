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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingList));
            this.bookinglistGridView = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.BookingListFormBackBtn = new System.Windows.Forms.Button();
            this.BookingListFormDeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookinglistGridView
            // 
            this.bookinglistGridView.AllowUserToAddRows = false;
            this.bookinglistGridView.AllowUserToDeleteRows = false;
            this.bookinglistGridView.AllowUserToResizeColumns = false;
            this.bookinglistGridView.AllowUserToResizeRows = false;
            this.bookinglistGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookinglistGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookinglistGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.bookinglistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinglistGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.bookinglistGridView.Location = new System.Drawing.Point(59, 174);
            this.bookinglistGridView.Name = "bookinglistGridView";
            this.bookinglistGridView.ReadOnly = true;
            this.bookinglistGridView.RowHeadersWidth = 51;
            this.bookinglistGridView.RowTemplate.Height = 24;
            this.bookinglistGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookinglistGridView.Size = new System.Drawing.Size(741, 196);
            this.bookinglistGridView.TabIndex = 0;
            this.bookinglistGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookinglistGridView_CellContentClick_1);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbtn.Location = new System.Drawing.Point(206, 82);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(173, 28);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search By User Name :";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(385, 84);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(220, 25);
            this.searchtextBox.TabIndex = 2;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // BookingListFormBackBtn
            // 
            this.BookingListFormBackBtn.BackColor = System.Drawing.Color.SeaShell;
            this.BookingListFormBackBtn.Location = new System.Drawing.Point(283, 407);
            this.BookingListFormBackBtn.Name = "BookingListFormBackBtn";
            this.BookingListFormBackBtn.Size = new System.Drawing.Size(110, 37);
            this.BookingListFormBackBtn.TabIndex = 3;
            this.BookingListFormBackBtn.Text = "Back";
            this.BookingListFormBackBtn.UseVisualStyleBackColor = false;
            this.BookingListFormBackBtn.Click += new System.EventHandler(this.BookingListFormBackBtn_Click);
            // 
            // BookingListFormDeleteBtn
            // 
            this.BookingListFormDeleteBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BookingListFormDeleteBtn.Location = new System.Drawing.Point(430, 407);
            this.BookingListFormDeleteBtn.Name = "BookingListFormDeleteBtn";
            this.BookingListFormDeleteBtn.Size = new System.Drawing.Size(135, 37);
            this.BookingListFormDeleteBtn.TabIndex = 4;
            this.BookingListFormDeleteBtn.Text = "Delete Booking";
            this.BookingListFormDeleteBtn.UseVisualStyleBackColor = false;
            this.BookingListFormDeleteBtn.Click += new System.EventHandler(this.BookingListFormDeleteBtn_Click);
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.BookingListFormDeleteBtn);
            this.Controls.Add(this.BookingListFormBackBtn);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.bookinglistGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookingList";
            this.Text = "Booking List";
            this.Load += new System.EventHandler(this.BookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookinglistGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookinglistGridView;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button BookingListFormBackBtn;
        private System.Windows.Forms.Button BookingListFormDeleteBtn;
    }
}
