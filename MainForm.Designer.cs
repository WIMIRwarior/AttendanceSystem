namespace AttendanceSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_Attendance = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_Classes = new MetroFramework.Controls.MetroComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceSystem.DataSet1();
            this.metroTabPage_Reports = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.classesTableAdapter = new AttendanceSystem.DataSet1TableAdapters.ClassesTableAdapter();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AttendanceSystem.DataSet1();
            this.classesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRecordsTableAdapter = new AttendanceSystem.DataSet1TableAdapters.AttendanceRecordsTableAdapter();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_Attendance);
            this.metroTabControl1.Controls.Add(this.metroTabPage_Reports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(805, 416);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_Attendance
            // 
            this.metroTabPage_Attendance.Controls.Add(this.dateTimePicker1);
            this.metroTabPage_Attendance.Controls.Add(this.metroButton5);
            this.metroTabPage_Attendance.Controls.Add(this.metroButton4);
            this.metroTabPage_Attendance.Controls.Add(this.metroButton3);
            this.metroTabPage_Attendance.Controls.Add(this.metroButton2);
            this.metroTabPage_Attendance.Controls.Add(this.metroButton1);
            this.metroTabPage_Attendance.Controls.Add(this.dataGridView1);
            this.metroTabPage_Attendance.Controls.Add(this.metroLabel2);
            this.metroTabPage_Attendance.Controls.Add(this.metroLabel1);
            this.metroTabPage_Attendance.Controls.Add(this.metroComboBox_Classes);
            this.metroTabPage_Attendance.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Attendance.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Attendance.HorizontalScrollbarSize = 10;
            this.metroTabPage_Attendance.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Attendance.Name = "metroTabPage_Attendance";
            this.metroTabPage_Attendance.Size = new System.Drawing.Size(797, 374);
            this.metroTabPage_Attendance.TabIndex = 0;
            this.metroTabPage_Attendance.Text = "Attendance";
            this.metroTabPage_Attendance.VerticalScrollbarBarColor = true;
            this.metroTabPage_Attendance.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Attendance.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(266, 25);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 29);
            this.metroButton5.TabIndex = 11;
            this.metroButton5.Text = "Get Values";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(683, 25);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(83, 23);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "Add Class";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(683, 54);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(83, 23);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Add Students";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(266, 330);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(266, 301);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 280);
            this.dataGridView1.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(186, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Select Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select Class";
            // 
            // metroComboBox_Classes
            // 
            this.metroComboBox_Classes.DataSource = this.classesBindingSource;
            this.metroComboBox_Classes.DisplayMember = "ClassName";
            this.metroComboBox_Classes.FormattingEnabled = true;
            this.metroComboBox_Classes.ItemHeight = 23;
            this.metroComboBox_Classes.Location = new System.Drawing.Point(12, 37);
            this.metroComboBox_Classes.Name = "metroComboBox_Classes";
            this.metroComboBox_Classes.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_Classes.TabIndex = 2;
            this.metroComboBox_Classes.UseSelectable = true;
            this.metroComboBox_Classes.ValueMember = "ClassID";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage_Reports
            // 
            this.metroTabPage_Reports.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Reports.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Reports.HorizontalScrollbarSize = 10;
            this.metroTabPage_Reports.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Reports.Name = "metroTabPage_Reports";
            this.metroTabPage_Reports.Size = new System.Drawing.Size(752, 328);
            this.metroTabPage_Reports.TabIndex = 1;
            this.metroTabPage_Reports.Text = "Reports";
            this.metroTabPage_Reports.VerticalScrollbarBarColor = true;
            this.metroTabPage_Reports.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Reports.VerticalScrollbarSize = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_UserName});
            this.statusStrip1.Location = new System.Drawing.Point(20, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "User:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // toolStripStatusLabel_UserName
            // 
            this.toolStripStatusLabel_UserName.Name = "toolStripStatusLabel_UserName";
            this.toolStripStatusLabel_UserName.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel_UserName.Text = "UserName";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // classesBindingSource1
            // 
            this.classesBindingSource1.DataMember = "Classes";
            this.classesBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource2
            // 
            this.classesBindingSource2.DataMember = "Classes";
            this.classesBindingSource2.DataSource = this.dataSet11;
            // 
            // attendanceRecordsBindingSource
            // 
            this.attendanceRecordsBindingSource.DataMember = "AttendanceRecords";
            this.attendanceRecordsBindingSource.DataSource = this.dataSet1;
            // 
            // attendanceRecordsTableAdapter
            // 
            this.attendanceRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Attendance System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_Attendance.ResumeLayout(false);
            this.metroTabPage_Attendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Attendance;
        private MetroFramework.Controls.MetroComboBox metroComboBox_Classes;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Reports;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_UserName;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource classesBindingSource2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.BindingSource attendanceRecordsBindingSource;
        private DataSet1TableAdapters.AttendanceRecordsTableAdapter attendanceRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

