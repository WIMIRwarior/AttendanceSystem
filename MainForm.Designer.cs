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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceSystem.DataSet1();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_Classes = new MetroFramework.Controls.MetroComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage_Reports = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.classesTableAdapter = new AttendanceSystem.DataSet1TableAdapters.ClassesTableAdapter();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AttendanceSystem.DataSet1();
            this.classesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRecordsTableAdapter = new AttendanceSystem.DataSet1TableAdapters.AttendanceRecordsTableAdapter();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.metroTabPage_Reports.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_Attendance);
            this.metroTabControl1.Controls.Add(this.metroTabPage_Reports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker1.TabIndex = 12;
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
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(266, 301);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            // attendanceRecordsBindingSource
            // 
            this.attendanceRecordsBindingSource.DataMember = "AttendanceRecords";
            this.attendanceRecordsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // metroTabPage_Reports
            // 
            this.metroTabPage_Reports.Controls.Add(this.dateTimePicker2);
            this.metroTabPage_Reports.Controls.Add(this.metroButton6);
            this.metroTabPage_Reports.Controls.Add(this.metroLabel3);
            this.metroTabPage_Reports.Controls.Add(this.metroLabel4);
            this.metroTabPage_Reports.Controls.Add(this.metroComboBox1);
            this.metroTabPage_Reports.Controls.Add(this.metroListView1);
            this.metroTabPage_Reports.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Reports.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Reports.HorizontalScrollbarSize = 10;
            this.metroTabPage_Reports.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Reports.Name = "metroTabPage_Reports";
            this.metroTabPage_Reports.Size = new System.Drawing.Size(797, 374);
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
            // attendanceRecordsTableAdapter
            // 
            this.attendanceRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(3, 57);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(619, 287);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Present";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absent";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Late";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 124;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(257, 10);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 29);
            this.metroButton6.TabIndex = 16;
            this.metroButton6.Text = "Get Values";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(177, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Select Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Select Class";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.classesBindingSource;
            this.metroComboBox1.DisplayMember = "ClassName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 22);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "ClassID";
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
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.metroTabPage_Reports.ResumeLayout(false);
            this.metroTabPage_Reports.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource2)).EndInit();
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
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

