namespace AttendanceSystem
{
    partial class AddClassForm
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
            this.metroTextBox_ClassName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTextBox_ClassName
            // 
            // 
            // 
            // 
            this.metroTextBox_ClassName.CustomButton.Image = null;
            this.metroTextBox_ClassName.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.metroTextBox_ClassName.CustomButton.Name = "";
            this.metroTextBox_ClassName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_ClassName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_ClassName.CustomButton.TabIndex = 1;
            this.metroTextBox_ClassName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_ClassName.CustomButton.UseSelectable = true;
            this.metroTextBox_ClassName.CustomButton.Visible = false;
            this.metroTextBox_ClassName.Lines = new string[0];
            this.metroTextBox_ClassName.Location = new System.Drawing.Point(97, 61);
            this.metroTextBox_ClassName.MaxLength = 32767;
            this.metroTextBox_ClassName.Name = "metroTextBox_ClassName";
            this.metroTextBox_ClassName.PasswordChar = '\0';
            this.metroTextBox_ClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_ClassName.SelectedText = "";
            this.metroTextBox_ClassName.SelectionLength = 0;
            this.metroTextBox_ClassName.SelectionStart = 0;
            this.metroTextBox_ClassName.ShortcutsEnabled = true;
            this.metroTextBox_ClassName.Size = new System.Drawing.Size(230, 23);
            this.metroTextBox_ClassName.TabIndex = 0;
            this.metroTextBox_ClassName.UseSelectable = true;
            this.metroTextBox_ClassName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_ClassName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(252, 90);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Accept";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(97, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Class name";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 210);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox_ClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_ClassName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}