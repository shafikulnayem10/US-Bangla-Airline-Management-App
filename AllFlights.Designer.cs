
namespace US_Bangla_Airline_Management_App
{
    partial class AllFlights
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
            this.AllFlightsFormFlightDataTable = new System.Windows.Forms.DataGridView();
            this.AllFlightsFormAddFlightBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormEditFlightBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormDeleteBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllFlightsFormFlightDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllFlightsFormFlightDataTable
            // 
            this.AllFlightsFormFlightDataTable.AllowUserToAddRows = false;
            this.AllFlightsFormFlightDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllFlightsFormFlightDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllFlightsFormFlightDataTable.Location = new System.Drawing.Point(12, 12);
            this.AllFlightsFormFlightDataTable.MultiSelect = false;
            this.AllFlightsFormFlightDataTable.Name = "AllFlightsFormFlightDataTable";
            this.AllFlightsFormFlightDataTable.ReadOnly = true;
            this.AllFlightsFormFlightDataTable.RowHeadersWidth = 51;
            this.AllFlightsFormFlightDataTable.RowTemplate.Height = 24;
            this.AllFlightsFormFlightDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllFlightsFormFlightDataTable.Size = new System.Drawing.Size(776, 237);
            this.AllFlightsFormFlightDataTable.TabIndex = 0;
            // 
            // AllFlightsFormAddFlightBtn
            // 
            this.AllFlightsFormAddFlightBtn.Location = new System.Drawing.Point(71, 304);
            this.AllFlightsFormAddFlightBtn.Name = "AllFlightsFormAddFlightBtn";
            this.AllFlightsFormAddFlightBtn.Size = new System.Drawing.Size(127, 49);
            this.AllFlightsFormAddFlightBtn.TabIndex = 1;
            this.AllFlightsFormAddFlightBtn.Text = "Add Flight";
            this.AllFlightsFormAddFlightBtn.UseVisualStyleBackColor = true;
            this.AllFlightsFormAddFlightBtn.Click += new System.EventHandler(this.AllFlightsFormAddFlightBtn_Click);
            // 
            // AllFlightsFormEditFlightBtn
            // 
            this.AllFlightsFormEditFlightBtn.Location = new System.Drawing.Point(328, 295);
            this.AllFlightsFormEditFlightBtn.Name = "AllFlightsFormEditFlightBtn";
            this.AllFlightsFormEditFlightBtn.Size = new System.Drawing.Size(125, 58);
            this.AllFlightsFormEditFlightBtn.TabIndex = 2;
            this.AllFlightsFormEditFlightBtn.Text = "Edit Flight";
            this.AllFlightsFormEditFlightBtn.UseVisualStyleBackColor = true;
            this.AllFlightsFormEditFlightBtn.Click += new System.EventHandler(this.AllFlightsFormEditFlightBtn_Click);
            // 
            // AllFlightsFormDeleteBtn
            // 
            this.AllFlightsFormDeleteBtn.Location = new System.Drawing.Point(610, 295);
            this.AllFlightsFormDeleteBtn.Name = "AllFlightsFormDeleteBtn";
            this.AllFlightsFormDeleteBtn.Size = new System.Drawing.Size(138, 58);
            this.AllFlightsFormDeleteBtn.TabIndex = 3;
            this.AllFlightsFormDeleteBtn.Text = "Delete";
            this.AllFlightsFormDeleteBtn.UseVisualStyleBackColor = true;
            this.AllFlightsFormDeleteBtn.Click += new System.EventHandler(this.AllFlightsFormDeleteBtn_Click);
            // 
            // AllFlightsFormBackBtn
            // 
            this.AllFlightsFormBackBtn.Location = new System.Drawing.Point(266, 377);
            this.AllFlightsFormBackBtn.Name = "AllFlightsFormBackBtn";
            this.AllFlightsFormBackBtn.Size = new System.Drawing.Size(218, 51);
            this.AllFlightsFormBackBtn.TabIndex = 4;
            this.AllFlightsFormBackBtn.Text = "Back";
            this.AllFlightsFormBackBtn.UseVisualStyleBackColor = true;
            this.AllFlightsFormBackBtn.Click += new System.EventHandler(this.AllFlightsFormBackBtn_Click);
            // 
            // AllFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllFlightsFormBackBtn);
            this.Controls.Add(this.AllFlightsFormDeleteBtn);
            this.Controls.Add(this.AllFlightsFormEditFlightBtn);
            this.Controls.Add(this.AllFlightsFormAddFlightBtn);
            this.Controls.Add(this.AllFlightsFormFlightDataTable);
            this.Name = "AllFlights";
            this.Text = "AllFlights";
            ((System.ComponentModel.ISupportInitialize)(this.AllFlightsFormFlightDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllFlightsFormFlightDataTable;
        private System.Windows.Forms.Button AllFlightsFormAddFlightBtn;
        private System.Windows.Forms.Button AllFlightsFormEditFlightBtn;
        private System.Windows.Forms.Button AllFlightsFormDeleteBtn;
        private System.Windows.Forms.Button AllFlightsFormBackBtn;
    }
}