namespace AttendanceSystem
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBox_User = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_User = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_Password = new MetroFramework.Controls.MetroLabel();
            this.metroButton_Login = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceSystem.Properties.Resources.key_turning;
            this.pictureBox1.Location = new System.Drawing.Point(39, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBox_User
            // 
            this.metroTextBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.metroTextBox_User.CustomButton.Image = null;
            this.metroTextBox_User.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.metroTextBox_User.CustomButton.Name = "";
            this.metroTextBox_User.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_User.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_User.CustomButton.TabIndex = 1;
            this.metroTextBox_User.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_User.CustomButton.UseSelectable = true;
            this.metroTextBox_User.CustomButton.Visible = false;
            this.metroTextBox_User.Lines = new string[0];
            this.metroTextBox_User.Location = new System.Drawing.Point(39, 175);
            this.metroTextBox_User.MaxLength = 32767;
            this.metroTextBox_User.Name = "metroTextBox_User";
            this.metroTextBox_User.PasswordChar = '\0';
            this.metroTextBox_User.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_User.SelectedText = "";
            this.metroTextBox_User.SelectionLength = 0;
            this.metroTextBox_User.SelectionStart = 0;
            this.metroTextBox_User.ShortcutsEnabled = true;
            this.metroTextBox_User.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_User.TabIndex = 1;
            this.metroTextBox_User.UseCustomBackColor = true;
            this.metroTextBox_User.UseSelectable = true;
            this.metroTextBox_User.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_User.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_User.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroTextBox_Password
            // 
            this.metroTextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.metroTextBox_Password.CustomButton.Image = null;
            this.metroTextBox_Password.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.metroTextBox_Password.CustomButton.Name = "";
            this.metroTextBox_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Password.CustomButton.TabIndex = 1;
            this.metroTextBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Password.CustomButton.UseSelectable = true;
            this.metroTextBox_Password.CustomButton.Visible = false;
            this.metroTextBox_Password.Lines = new string[0];
            this.metroTextBox_Password.Location = new System.Drawing.Point(39, 234);
            this.metroTextBox_Password.MaxLength = 32767;
            this.metroTextBox_Password.Name = "metroTextBox_Password";
            this.metroTextBox_Password.PasswordChar = '*';
            this.metroTextBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Password.SelectedText = "";
            this.metroTextBox_Password.SelectionLength = 0;
            this.metroTextBox_Password.SelectionStart = 0;
            this.metroTextBox_Password.ShortcutsEnabled = true;
            this.metroTextBox_Password.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_Password.TabIndex = 2;
            this.metroTextBox_Password.UseCustomBackColor = true;
            this.metroTextBox_Password.UseSelectable = true;
            this.metroTextBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel_User
            // 
            this.metroLabel_User.AutoSize = true;
            this.metroLabel_User.Location = new System.Drawing.Point(39, 150);
            this.metroLabel_User.Name = "metroLabel_User";
            this.metroLabel_User.Size = new System.Drawing.Size(35, 19);
            this.metroLabel_User.TabIndex = 3;
            this.metroLabel_User.Text = "User";
            // 
            // metroLabel_Password
            // 
            this.metroLabel_Password.AutoSize = true;
            this.metroLabel_Password.Location = new System.Drawing.Point(39, 212);
            this.metroLabel_Password.Name = "metroLabel_Password";
            this.metroLabel_Password.Size = new System.Drawing.Size(63, 19);
            this.metroLabel_Password.TabIndex = 4;
            this.metroLabel_Password.Text = "Password";
            // 
            // metroButton_Login
            // 
            this.metroButton_Login.Location = new System.Drawing.Point(144, 270);
            this.metroButton_Login.Name = "metroButton_Login";
            this.metroButton_Login.Size = new System.Drawing.Size(75, 23);
            this.metroButton_Login.TabIndex = 5;
            this.metroButton_Login.Text = "Login";
            this.metroButton_Login.UseSelectable = true;
            this.metroButton_Login.Click += new System.EventHandler(this.metroButton_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 305);
            this.Controls.Add(this.metroButton_Login);
            this.Controls.Add(this.metroLabel_Password);
            this.Controls.Add(this.metroLabel_User);
            this.Controls.Add(this.metroTextBox_Password);
            this.Controls.Add(this.metroTextBox_User);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_User;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Password;
        private MetroFramework.Controls.MetroLabel metroLabel_User;
        private MetroFramework.Controls.MetroLabel metroLabel_Password;
        private MetroFramework.Controls.MetroButton metroButton_Login;
    }
}