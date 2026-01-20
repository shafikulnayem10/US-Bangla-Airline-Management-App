
namespace US_Bangla_Airline_Management_App
{
    partial class staffbookinglist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffbookinglist));
            this.staffBookingListFormDeleteBtn = new System.Windows.Forms.Button();
            this.staffBookingListFormBackBtn = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.staffbookinglistGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staffbookinglistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBookingListFormDeleteBtn
            // 
            this.staffBookingListFormDeleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.staffBookingListFormDeleteBtn.Location = new System.Drawing.Point(679, 295);
            this.staffBookingListFormDeleteBtn.Name = "staffBookingListFormDeleteBtn";
            this.staffBookingListFormDeleteBtn.Size = new System.Drawing.Size(92, 29);
            this.staffBookingListFormDeleteBtn.TabIndex = 9;
            this.staffBookingListFormDeleteBtn.Text = "Delete ";
            this.staffBookingListFormDeleteBtn.UseVisualStyleBackColor = false;
            this.staffBookingListFormDeleteBtn.Click += new System.EventHandler(this.staffBookingListFormDeleteBtn_Click);
            // 
            // staffBookingListFormBackBtn
            // 
            this.staffBookingListFormBackBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.staffBookingListFormBackBtn.Location = new System.Drawing.Point(30, 295);
            this.staffBookingListFormBackBtn.Name = "staffBookingListFormBackBtn";
            this.staffBookingListFormBackBtn.Size = new System.Drawing.Size(105, 29);
            this.staffBookingListFormBackBtn.TabIndex = 8;
            this.staffBookingListFormBackBtn.Text = "Back";
            this.staffBookingListFormBackBtn.UseVisualStyleBackColor = false;
            this.staffBookingListFormBackBtn.Click += new System.EventHandler(this.BookingListFormBackBtn_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(551, 48);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(220, 22);
            this.searchtextBox.TabIndex = 7;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchbtn.Location = new System.Drawing.Point(611, 12);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(160, 30);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Search ";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // staffbookinglistGridView
            // 
            this.staffbookinglistGridView.AllowUserToAddRows = false;
            this.staffbookinglistGridView.AllowUserToDeleteRows = false;
            this.staffbookinglistGridView.AllowUserToResizeColumns = false;
            this.staffbookinglistGridView.AllowUserToResizeRows = false;
            this.staffbookinglistGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffbookinglistGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffbookinglistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffbookinglistGridView.Location = new System.Drawing.Point(30, 76);
            this.staffbookinglistGridView.Name = "staffbookinglistGridView";
            this.staffbookinglistGridView.ReadOnly = true;
            this.staffbookinglistGridView.RowHeadersWidth = 51;
            this.staffbookinglistGridView.RowTemplate.Height = 24;
            this.staffbookinglistGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffbookinglistGridView.Size = new System.Drawing.Size(741, 184);
            this.staffbookinglistGridView.TabIndex = 5;
            this.staffbookinglistGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffbookinglistGridView_CellContentClick);
            // 
            // staffbookinglist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffBookingListFormDeleteBtn);
            this.Controls.Add(this.staffBookingListFormBackBtn);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.staffbookinglistGridView);
            this.Name = "staffbookinglist";
            this.Text = "staffbookinglist";
            this.Load += new System.EventHandler(this.staffbookinglist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffbookinglistGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button staffBookingListFormDeleteBtn;
        private System.Windows.Forms.Button staffBookingListFormBackBtn;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView staffbookinglistGridView;
    }
}