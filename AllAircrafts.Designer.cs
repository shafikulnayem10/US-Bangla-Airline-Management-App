
namespace US_Bangla_Airline_Management_App
{
    partial class AllAircrafts
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
            this.AllAircraftsFormDatatable = new System.Windows.Forms.DataGridView();
            this.AllAircraftsFormAddAircraftBtn = new System.Windows.Forms.Button();
            this.AllAircraftFormEditAircraftBtn = new System.Windows.Forms.Button();
            this.AllAircraftFormDeleteAircraftBtn = new System.Windows.Forms.Button();
            this.AllAircraftsFormBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllAircraftsFormDatatable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllAircraftsFormDatatable
            // 
            this.AllAircraftsFormDatatable.AllowDrop = true;
            this.AllAircraftsFormDatatable.AllowUserToOrderColumns = true;
            this.AllAircraftsFormDatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllAircraftsFormDatatable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllAircraftsFormDatatable.Location = new System.Drawing.Point(12, 55);
            this.AllAircraftsFormDatatable.Name = "AllAircraftsFormDatatable";
            this.AllAircraftsFormDatatable.ReadOnly = true;
            this.AllAircraftsFormDatatable.RowHeadersWidth = 51;
            this.AllAircraftsFormDatatable.RowTemplate.Height = 24;
            this.AllAircraftsFormDatatable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllAircraftsFormDatatable.Size = new System.Drawing.Size(776, 196);
            this.AllAircraftsFormDatatable.TabIndex = 0;
            // 
            // AllAircraftsFormAddAircraftBtn
            // 
            this.AllAircraftsFormAddAircraftBtn.Location = new System.Drawing.Point(49, 271);
            this.AllAircraftsFormAddAircraftBtn.Name = "AllAircraftsFormAddAircraftBtn";
            this.AllAircraftsFormAddAircraftBtn.Size = new System.Drawing.Size(114, 68);
            this.AllAircraftsFormAddAircraftBtn.TabIndex = 1;
            this.AllAircraftsFormAddAircraftBtn.Text = "Add Aircraft";
            this.AllAircraftsFormAddAircraftBtn.UseVisualStyleBackColor = true;
            this.AllAircraftsFormAddAircraftBtn.Click += new System.EventHandler(this.AllAircraftsFormAddAircraftBtn_Click);
            // 
            // AllAircraftFormEditAircraftBtn
            // 
            this.AllAircraftFormEditAircraftBtn.Location = new System.Drawing.Point(309, 280);
            this.AllAircraftFormEditAircraftBtn.Name = "AllAircraftFormEditAircraftBtn";
            this.AllAircraftFormEditAircraftBtn.Size = new System.Drawing.Size(114, 59);
            this.AllAircraftFormEditAircraftBtn.TabIndex = 2;
            this.AllAircraftFormEditAircraftBtn.Text = "Edit Aircraft";
            this.AllAircraftFormEditAircraftBtn.UseVisualStyleBackColor = true;
            this.AllAircraftFormEditAircraftBtn.Click += new System.EventHandler(this.AllAircraftFormEditAircraftBtn_Click);
            // 
            // AllAircraftFormDeleteAircraftBtn
            // 
            this.AllAircraftFormDeleteAircraftBtn.Location = new System.Drawing.Point(525, 280);
            this.AllAircraftFormDeleteAircraftBtn.Name = "AllAircraftFormDeleteAircraftBtn";
            this.AllAircraftFormDeleteAircraftBtn.Size = new System.Drawing.Size(153, 59);
            this.AllAircraftFormDeleteAircraftBtn.TabIndex = 3;
            this.AllAircraftFormDeleteAircraftBtn.Text = "Delete AIrcraft";
            this.AllAircraftFormDeleteAircraftBtn.UseVisualStyleBackColor = true;
            this.AllAircraftFormDeleteAircraftBtn.Click += new System.EventHandler(this.AllAircraftFormDeleteAircraftBtn_Click);
            // 
            // AllAircraftsFormBackBtn
            // 
            this.AllAircraftsFormBackBtn.Location = new System.Drawing.Point(266, 358);
            this.AllAircraftsFormBackBtn.Name = "AllAircraftsFormBackBtn";
            this.AllAircraftsFormBackBtn.Size = new System.Drawing.Size(138, 61);
            this.AllAircraftsFormBackBtn.TabIndex = 4;
            this.AllAircraftsFormBackBtn.Text = "Back";
            this.AllAircraftsFormBackBtn.UseVisualStyleBackColor = true;
            this.AllAircraftsFormBackBtn.Click += new System.EventHandler(this.AllAircraftsFormBackBtn_Click);
            // 
            // AllAircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllAircraftsFormBackBtn);
            this.Controls.Add(this.AllAircraftFormDeleteAircraftBtn);
            this.Controls.Add(this.AllAircraftFormEditAircraftBtn);
            this.Controls.Add(this.AllAircraftsFormAddAircraftBtn);
            this.Controls.Add(this.AllAircraftsFormDatatable);
            this.Name = "AllAircrafts";
            this.Text = "AllAircrafts";
            ((System.ComponentModel.ISupportInitialize)(this.AllAircraftsFormDatatable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllAircraftsFormDatatable;
        private System.Windows.Forms.Button AllAircraftsFormAddAircraftBtn;
        private System.Windows.Forms.Button AllAircraftFormEditAircraftBtn;
        private System.Windows.Forms.Button AllAircraftFormDeleteAircraftBtn;
        private System.Windows.Forms.Button AllAircraftsFormBackBtn;
    }
}