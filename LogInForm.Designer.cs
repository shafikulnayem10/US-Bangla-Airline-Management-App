
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
            this.button1 = new System.Windows.Forms.Button();
            this.acc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogInFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInFormHeaderLabel
            // 
            this.LogInFormHeaderLabel.AutoSize = true;
            this.LogInFormHeaderLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInFormHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormHeaderLabel.Location = new System.Drawing.Point(388, 21);
            this.LogInFormHeaderLabel.Name = "LogInFormHeaderLabel";
            this.LogInFormHeaderLabel.Size = new System.Drawing.Size(133, 45);
            this.LogInFormHeaderLabel.TabIndex = 1;
            this.LogInFormHeaderLabel.Text = "Log In";
            // 
            // LogInFormUserNameLabel
            // 
            this.LogInFormUserNameLabel.AutoSize = true;
            this.LogInFormUserNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormUserNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInFormUserNameLabel.Location = new System.Drawing.Point(301, 107);
            this.LogInFormUserNameLabel.Name = "LogInFormUserNameLabel";
            this.LogInFormUserNameLabel.Size = new System.Drawing.Size(104, 22);
            this.LogInFormUserNameLabel.TabIndex = 2;
            this.LogInFormUserNameLabel.Text = "User Name:";
            this.LogInFormUserNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInFormUserNameTextBox
            // 
            this.LogInFormUserNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.LogInFormUserNameTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogInFormUserNameTextBox.Location = new System.Drawing.Point(427, 107);
            this.LogInFormUserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInFormUserNameTextBox.Name = "LogInFormUserNameTextBox";
            this.LogInFormUserNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.LogInFormUserNameTextBox.TabIndex = 3;
            this.LogInFormUserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogInFormPassTxtBox
            // 
            this.LogInFormPassTxtBox.BackColor = System.Drawing.Color.Silver;
            this.LogInFormPassTxtBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogInFormPassTxtBox.Location = new System.Drawing.Point(427, 150);
            this.LogInFormPassTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInFormPassTxtBox.Multiline = true;
            this.LogInFormPassTxtBox.Name = "LogInFormPassTxtBox";
            this.LogInFormPassTxtBox.Size = new System.Drawing.Size(176, 22);
            this.LogInFormPassTxtBox.TabIndex = 5;
            // 
            // LogInFormPassLabel
            // 
            this.LogInFormPassLabel.AutoSize = true;
            this.LogInFormPassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormPassLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInFormPassLabel.Location = new System.Drawing.Point(301, 150);
            this.LogInFormPassLabel.Name = "LogInFormPassLabel";
            this.LogInFormPassLabel.Size = new System.Drawing.Size(94, 22);
            this.LogInFormPassLabel.TabIndex = 4;
            this.LogInFormPassLabel.Text = "Password:";
            this.LogInFormPassLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInFormCmb
            // 
            this.LogInFormCmb.BackColor = System.Drawing.Color.Silver;
            this.LogInFormCmb.ForeColor = System.Drawing.SystemColors.Info;
            this.LogInFormCmb.FormattingEnabled = true;
            this.LogInFormCmb.Items.AddRange(new object[] {
            "Admin",
            "Normal Customer",
            "Premium Customer",
            "Counter Staff"});
            this.LogInFormCmb.Location = new System.Drawing.Point(427, 199);
            this.LogInFormCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInFormCmb.Name = "LogInFormCmb";
            this.LogInFormCmb.Size = new System.Drawing.Size(176, 24);
            this.LogInFormCmb.TabIndex = 6;
            this.LogInFormCmb.Text = "Select";
            // 
            // LogInFormRoleLabel
            // 
            this.LogInFormRoleLabel.AutoSize = true;
            this.LogInFormRoleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInFormRoleLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInFormRoleLabel.Location = new System.Drawing.Point(331, 201);
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
            this.LogInButton.Location = new System.Drawing.Point(305, 259);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(298, 37);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInFormPictureBox
            // 
            this.LogInFormPictureBox.BackgroundImage = global::US_Bangla_Airline_Management_App.Properties.Resources.LogoPic;
            this.LogInFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInFormPictureBox.Location = new System.Drawing.Point(739, -2);
            this.LogInFormPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInFormPictureBox.Name = "LogInFormPictureBox";
            this.LogInFormPictureBox.Size = new System.Drawing.Size(364, 94);
            this.LogInFormPictureBox.TabIndex = 10;
            this.LogInFormPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(305, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.ForeColor = System.Drawing.Color.Gray;
            this.acc.Location = new System.Drawing.Point(380, 310);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(161, 17);
            this.acc.TabIndex = 12;
            this.acc.Text = "Don\'t Have An Account ?";
            this.acc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 489);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInFormPictureBox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogInFormRoleLabel);
            this.Controls.Add(this.LogInFormCmb);
            this.Controls.Add(this.LogInFormPassTxtBox);
            this.Controls.Add(this.LogInFormPassLabel);
            this.Controls.Add(this.LogInFormUserNameTextBox);
            this.Controls.Add(this.LogInFormUserNameLabel);
            this.Controls.Add(this.LogInFormHeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label acc;
    }
}