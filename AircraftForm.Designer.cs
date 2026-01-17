
namespace US_Bangla_Airline_Management_App
{
    partial class AircraftlistForm
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
            this.showall = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.aircraftGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showall
            // 
            this.showall.Location = new System.Drawing.Point(303, 331);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(75, 23);
            this.showall.TabIndex = 1;
            this.showall.Text = "Show all";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(107, 331);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(436, 331);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click_1);
            // 
            // aircraftGridView
            // 
            this.aircraftGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aircraftGridView.Location = new System.Drawing.Point(303, 23);
            this.aircraftGridView.Name = "aircraftGridView";
            this.aircraftGridView.RowHeadersWidth = 51;
            this.aircraftGridView.RowTemplate.Height = 24;
            this.aircraftGridView.Size = new System.Drawing.Size(375, 266);
            this.aircraftGridView.TabIndex = 4;
            this.aircraftGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aircraftGridView_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // AircraftlistForm
            // 
            this.ClientSize = new System.Drawing.Size(724, 490);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aircraftGridView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.showall);
            this.Name = "AircraftlistForm";
            ((System.ComponentModel.ISupportInitialize)(this.aircraftGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView aircraftGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}