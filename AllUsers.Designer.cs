
namespace US_Bangla_Airline_Management_App
{
    partial class AllUsers
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
            this.AllUsersTable = new System.Windows.Forms.DataGridView();
            this.SelectUserBtn = new System.Windows.Forms.Button();
            this.AllUsersFormDeleteUserBtn = new System.Windows.Forms.Button();
            this.AllUsersBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsersTable
            // 
            this.AllUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllUsersTable.Location = new System.Drawing.Point(3, 6);
            this.AllUsersTable.MultiSelect = false;
            this.AllUsersTable.Name = "AllUsersTable";
            this.AllUsersTable.ReadOnly = true;
            this.AllUsersTable.RowHeadersWidth = 51;
            this.AllUsersTable.RowTemplate.Height = 24;
            this.AllUsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllUsersTable.Size = new System.Drawing.Size(798, 307);
            this.AllUsersTable.TabIndex = 0;
            // 
            // SelectUserBtn
            // 
            this.SelectUserBtn.Location = new System.Drawing.Point(46, 332);
            this.SelectUserBtn.Name = "SelectUserBtn";
            this.SelectUserBtn.Size = new System.Drawing.Size(195, 72);
            this.SelectUserBtn.TabIndex = 1;
            this.SelectUserBtn.Text = "Edit User";
            this.SelectUserBtn.UseVisualStyleBackColor = true;
            this.SelectUserBtn.Click += new System.EventHandler(this.SelectUserBtn_Click);
            // 
            // AllUsersFormDeleteUserBtn
            // 
            this.AllUsersFormDeleteUserBtn.Location = new System.Drawing.Point(305, 332);
            this.AllUsersFormDeleteUserBtn.Name = "AllUsersFormDeleteUserBtn";
            this.AllUsersFormDeleteUserBtn.Size = new System.Drawing.Size(218, 72);
            this.AllUsersFormDeleteUserBtn.TabIndex = 2;
            this.AllUsersFormDeleteUserBtn.Text = "Delete User";
            this.AllUsersFormDeleteUserBtn.UseVisualStyleBackColor = true;
            this.AllUsersFormDeleteUserBtn.Click += new System.EventHandler(this.AllUsersFormDeleteUserBtn_Click);
            // 
            // AllUsersBackBtn
            // 
            this.AllUsersBackBtn.Location = new System.Drawing.Point(570, 332);
            this.AllUsersBackBtn.Name = "AllUsersBackBtn";
            this.AllUsersBackBtn.Size = new System.Drawing.Size(218, 72);
            this.AllUsersBackBtn.TabIndex = 3;
            this.AllUsersBackBtn.Text = "Back";
            this.AllUsersBackBtn.UseVisualStyleBackColor = true;
            this.AllUsersBackBtn.Click += new System.EventHandler(this.AllUsersBackBtn_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllUsersBackBtn);
            this.Controls.Add(this.AllUsersFormDeleteUserBtn);
            this.Controls.Add(this.SelectUserBtn);
            this.Controls.Add(this.AllUsersTable);
            this.Name = "AllUsers";
            this.Text = "AllUsers";
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUsersTable;
        private System.Windows.Forms.Button SelectUserBtn;
        private System.Windows.Forms.Button AllUsersFormDeleteUserBtn;
        private System.Windows.Forms.Button AllUsersBackBtn;
    }
}