namespace US_Bangla_Airline_Management_App
{
    partial class LogInForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.acc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInFormPassTxtBox = new System.Windows.Forms.TextBox();
            this.LogInFormPassLabel = new System.Windows.Forms.Label();
            this.LogInFormUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LogInFormUserNameLabel = new System.Windows.Forms.Label();
            this.LogInFormHeaderLabel = new System.Windows.Forms.Label();
            this.LogInFormPictureBox = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogInFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Linen;
            this.panelMain.Controls.Add(this.acc);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.LogInButton);
            this.panelMain.Controls.Add(this.LogInFormPassTxtBox);
            this.panelMain.Controls.Add(this.LogInFormPassLabel);
            this.panelMain.Controls.Add(this.LogInFormUserNameTextBox);
            this.panelMain.Controls.Add(this.LogInFormUserNameLabel);
            this.panelMain.Controls.Add(this.LogInFormHeaderLabel);
            this.panelMain.Location = new System.Drawing.Point(120, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(432, 361);
            this.panelMain.TabIndex = 0;
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acc.ForeColor = System.Drawing.Color.Gray;
            this.acc.Location = new System.Drawing.Point(110, 280);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(174, 20);
            this.acc.TabIndex = 12;
            this.acc.Text = "Don\'t Have An Account ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.button1.Location = new System.Drawing.Point(102, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(40, 235);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(340, 40);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInFormPassTxtBox
            // 
            this.LogInFormPassTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.LogInFormPassTxtBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LogInFormPassTxtBox.Location = new System.Drawing.Point(40, 188);
            this.LogInFormPassTxtBox.Name = "LogInFormPassTxtBox";
            this.LogInFormPassTxtBox.Size = new System.Drawing.Size(340, 32);
            this.LogInFormPassTxtBox.TabIndex = 5;
            this.LogInFormPassTxtBox.UseSystemPasswordChar = true;
            // 
            // LogInFormPassLabel
            // 
            this.LogInFormPassLabel.AutoSize = true;
            this.LogInFormPassLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LogInFormPassLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInFormPassLabel.Location = new System.Drawing.Point(40, 160);
            this.LogInFormPassLabel.Name = "LogInFormPassLabel";
            this.LogInFormPassLabel.Size = new System.Drawing.Size(97, 25);
            this.LogInFormPassLabel.TabIndex = 4;
            this.LogInFormPassLabel.Text = "Password";
            // 
            // LogInFormUserNameTextBox
            // 
            this.LogInFormUserNameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.LogInFormUserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LogInFormUserNameTextBox.Location = new System.Drawing.Point(40, 118);
            this.LogInFormUserNameTextBox.Name = "LogInFormUserNameTextBox";
            this.LogInFormUserNameTextBox.Size = new System.Drawing.Size(340, 32);
            this.LogInFormUserNameTextBox.TabIndex = 3;
            // 
            // LogInFormUserNameLabel
            // 
            this.LogInFormUserNameLabel.AutoSize = true;
            this.LogInFormUserNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LogInFormUserNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInFormUserNameLabel.Location = new System.Drawing.Point(40, 90);
            this.LogInFormUserNameLabel.Name = "LogInFormUserNameLabel";
            this.LogInFormUserNameLabel.Size = new System.Drawing.Size(109, 25);
            this.LogInFormUserNameLabel.TabIndex = 2;
            this.LogInFormUserNameLabel.Text = "User Name";
            // 
            // LogInFormHeaderLabel
            // 
            this.LogInFormHeaderLabel.AutoSize = true;
            this.LogInFormHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LogInFormHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LogInFormHeaderLabel.Location = new System.Drawing.Point(140, 20);
            this.LogInFormHeaderLabel.Name = "LogInFormHeaderLabel";
            this.LogInFormHeaderLabel.Size = new System.Drawing.Size(140, 54);
            this.LogInFormHeaderLabel.TabIndex = 1;
            this.LogInFormHeaderLabel.Text = "Log In";
            // 
            // LogInFormPictureBox
            // 
            this.LogInFormPictureBox.BackgroundImage = global::US_Bangla_Airline_Management_App.Properties.Resources.LogoPic;
            this.LogInFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInFormPictureBox.Location = new System.Drawing.Point(600, 30);
            this.LogInFormPictureBox.Name = "LogInFormPictureBox";
            this.LogInFormPictureBox.Size = new System.Drawing.Size(420, 140);
            this.LogInFormPictureBox.TabIndex = 10;
            this.LogInFormPictureBox.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 489);
            this.Controls.Add(this.LogInFormPictureBox);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogInFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label LogInFormHeaderLabel;
        private System.Windows.Forms.Label LogInFormUserNameLabel;
        private System.Windows.Forms.TextBox LogInFormUserNameTextBox;
        private System.Windows.Forms.TextBox LogInFormPassTxtBox;
        private System.Windows.Forms.Label LogInFormPassLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.PictureBox LogInFormPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label acc;
    }
}
