
namespace US_Bangla_Airline_Management_App
{
    partial class LogInForm
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
            this.LogInFormHeaderLabel = new System.Windows.Forms.Label();
            this.LogInFormUserNameLabel = new System.Windows.Forms.Label();
            this.LogInFormUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LogInFormPassTxtBox = new System.Windows.Forms.TextBox();
            this.LogInFormPassLabel = new System.Windows.Forms.Label();
            this.LogInFormCmb = new System.Windows.Forms.ComboBox();
            this.LogInFormRoleLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogInFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInFormHeaderLabel
            // 
            this.LogInFormHeaderLabel.AutoSize = true;
            this.LogInFormHeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogInFormHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormHeaderLabel.Location = new System.Drawing.Point(418, 23);
            this.LogInFormHeaderLabel.Name = "LogInFormHeaderLabel";
            this.LogInFormHeaderLabel.Size = new System.Drawing.Size(132, 46);
            this.LogInFormHeaderLabel.TabIndex = 1;
            this.LogInFormHeaderLabel.Text = "Log In";
            // 
            // LogInFormUserNameLabel
            // 
            this.LogInFormUserNameLabel.AutoSize = true;
            this.LogInFormUserNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormUserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogInFormUserNameLabel.Location = new System.Drawing.Point(301, 107);
            this.LogInFormUserNameLabel.Name = "LogInFormUserNameLabel";
            this.LogInFormUserNameLabel.Size = new System.Drawing.Size(104, 22);
            this.LogInFormUserNameLabel.TabIndex = 2;
            this.LogInFormUserNameLabel.Text = "User Name:";
            this.LogInFormUserNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInFormUserNameTextBox
            // 
            this.LogInFormUserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogInFormUserNameTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogInFormUserNameTextBox.Location = new System.Drawing.Point(426, 107);
            this.LogInFormUserNameTextBox.Name = "LogInFormUserNameTextBox";
            this.LogInFormUserNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.LogInFormUserNameTextBox.TabIndex = 3;
            this.LogInFormUserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogInFormPassTxtBox
            // 
            this.LogInFormPassTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogInFormPassTxtBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogInFormPassTxtBox.Location = new System.Drawing.Point(426, 150);
            this.LogInFormPassTxtBox.Multiline = true;
            this.LogInFormPassTxtBox.Name = "LogInFormPassTxtBox";
            this.LogInFormPassTxtBox.Size = new System.Drawing.Size(176, 22);
            this.LogInFormPassTxtBox.TabIndex = 5;
            // 
            // LogInFormPassLabel
            // 
            this.LogInFormPassLabel.AutoSize = true;
            this.LogInFormPassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogInFormPassLabel.Location = new System.Drawing.Point(301, 150);
            this.LogInFormPassLabel.Name = "LogInFormPassLabel";
            this.LogInFormPassLabel.Size = new System.Drawing.Size(94, 22);
            this.LogInFormPassLabel.TabIndex = 4;
            this.LogInFormPassLabel.Text = "Password:";
            this.LogInFormPassLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInFormCmb
            // 
            this.LogInFormCmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogInFormCmb.ForeColor = System.Drawing.SystemColors.Info;
            this.LogInFormCmb.FormattingEnabled = true;
            this.LogInFormCmb.Items.AddRange(new object[] {
            "Admin",
            "Normal Customer",
            "Premium Customer",
            "Counter Staff"});
            this.LogInFormCmb.Location = new System.Drawing.Point(426, 199);
            this.LogInFormCmb.Name = "LogInFormCmb";
            this.LogInFormCmb.Size = new System.Drawing.Size(176, 24);
            this.LogInFormCmb.TabIndex = 6;
            this.LogInFormCmb.Text = "Select";
            // 
            // LogInFormRoleLabel
            // 
            this.LogInFormRoleLabel.AutoSize = true;
            this.LogInFormRoleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogInFormRoleLabel.Location = new System.Drawing.Point(330, 201);
            this.LogInFormRoleLabel.Name = "LogInFormRoleLabel";
            this.LogInFormRoleLabel.Size = new System.Drawing.Size(54, 22);
            this.LogInFormRoleLabel.TabIndex = 7;
            this.LogInFormRoleLabel.Text = "Role:";
            this.LogInFormRoleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LogInButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogInButton.Location = new System.Drawing.Point(426, 254);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(124, 33);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            // 
            // LogInFormPictureBox
            // 
            this.LogInFormPictureBox.BackgroundImage = global::US_Bangla_Airline_Management_App.Properties.Resources.LogoPic;
            this.LogInFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInFormPictureBox.Location = new System.Drawing.Point(738, -2);
            this.LogInFormPictureBox.Name = "LogInFormPictureBox";
            this.LogInFormPictureBox.Size = new System.Drawing.Size(364, 93);
            this.LogInFormPictureBox.TabIndex = 10;
            this.LogInFormPictureBox.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::US_Bangla_Airline_Management_App.Properties.Resources.LogInFormBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 489);
            this.Controls.Add(this.LogInFormPictureBox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogInFormRoleLabel);
            this.Controls.Add(this.LogInFormCmb);
            this.Controls.Add(this.LogInFormPassTxtBox);
            this.Controls.Add(this.LogInFormPassLabel);
            this.Controls.Add(this.LogInFormUserNameTextBox);
            this.Controls.Add(this.LogInFormUserNameLabel);
            this.Controls.Add(this.LogInFormHeaderLabel);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogInFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LogInFormHeaderLabel;
        private System.Windows.Forms.Label LogInFormUserNameLabel;
        private System.Windows.Forms.TextBox LogInFormUserNameTextBox;
        private System.Windows.Forms.TextBox LogInFormPassTxtBox;
        private System.Windows.Forms.Label LogInFormPassLabel;
        private System.Windows.Forms.ComboBox LogInFormCmb;
        private System.Windows.Forms.Label LogInFormRoleLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.PictureBox LogInFormPictureBox;
    }
}