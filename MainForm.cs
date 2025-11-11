using AttendanceSystem.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        public bool loggedIn = false;
        public int UserID { get; set; }
        public string UserName { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                //Open Login Form
                LoginForm newLoginForm = new LoginForm();
                newLoginForm.ShowDialog();


                if (newLoginForm.loginFlag == true)
                {
                    //Run app normaly
                    UserID = newLoginForm.UserID;
                }
                else
                {
                    //Close the app
                    Close();
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.AttendanceRecords' . Możesz go przenieść lub usunąć.
            this.attendanceRecordsTableAdapter.Fill(this.dataSet1.AttendanceRecords);


            //Open Login Form
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.ShowDialog();


            if (newLoginForm.loginFlag == true)
            {
                //Run app normaly
                UserID = newLoginForm.UserID;
                UserName = newLoginForm.UserName;
                toolStripStatusLabel_UserName.Text = newLoginForm.UserName;

                // Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.Classes' . Możesz go przenieść lub usunąć.
                this.classesTableAdapter.Fill(this.dataSet1.Classes);

                classesBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";

            }
            else
            {
                //Close the app
                Close();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddClassForm newAddClassForm = new AddClassForm();
            newAddClassForm.UserID = this.UserID;
            newAddClassForm.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddStudentsForm addStudentsForm = new AddStudentsForm();
            addStudentsForm.classID = int.Parse(metroComboBox_Classes.SelectedValue.ToString());
            addStudentsForm.className = metroComboBox_Classes.Text;


            addStudentsForm.ShowDialog();

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //Check if records exists, if yes load them for edit and if not create
            //record for each student and load for edit.

            AttendanceRecordsTableAdapter ada = new AttendanceRecordsTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox_Classes.SelectedValue, dateTimePicker1.Text);
            DataTable dt_new = ada.GetDataBy((int)metroComboBox_Classes.SelectedValue,
                                                   dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                //We have records, so we can edit.
                dataGridView1.DataSource = dt_new;
                this.attendanceRecordsTableAdapter.Fill(this.dataSet1.AttendanceRecords);
            }
            else
            {
                //Create record for each student.
                //Get the class students list.
                StudentsTableAdapter students_ada = new StudentsTableAdapter();

                DataTable dt_Students = students_ada.GetDataByClassID((int)metroComboBox_Classes.SelectedValue);

                foreach (DataRow row in dt_Students.Rows)
                {
                    //Insert a new record for this student.
                    ada.InsertQuery((int)row[0], (int)metroComboBox_Classes.SelectedValue,
                                    dateTimePicker1.Text, "", row[1].ToString(),
                                    metroComboBox_Classes.Text);
                }

                dataGridView1.DataSource = dt_new;
                this.attendanceRecordsTableAdapter.Fill(this.dataSet1.AttendanceRecords);

            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            AttendanceRecordsTableAdapter ada = new AttendanceRecordsTableAdapter();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox_Classes.SelectedValue, dateTimePicker1.Text);
                }
            }

            DataTable dt_new = ada.GetDataBy((int)metroComboBox_Classes.SelectedValue,
                                                   dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AttendanceRecordsTableAdapter ada = new AttendanceRecordsTableAdapter();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery("", row.Cells[0].Value.ToString(), (int)metroComboBox_Classes.SelectedValue, dateTimePicker1.Text);
                }
            }

            DataTable dt_new = ada.GetDataBy((int)metroComboBox_Classes.SelectedValue,
                                                   dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

            metroListView1.Items.Clear();
            //Get students
            StudentsTableAdapter students_ada = new StudentsTableAdapter();
            DataTable dt_Students = students_ada.GetDataByClassID((int)metroComboBox_Classes.SelectedValue);

            //Get Reports
            AttendanceRecordsTableAdapter ada = new AttendanceRecordsTableAdapter();

            int? p = 0;
            int? A = 0;
            int? L = 0;
            int? E = 0;



            //loop through students and get the values
            foreach (DataRow row in dt_Students.Rows)
            {
                //Presence count

              //  int? B = ada.GetStatus(11, "Karol", "Present");

                p = ada.GetStatus((decimal)dateTimePicker2.Value.Month, row[1].ToString(), "Present");



                //Absence count
                A = ada.GetStatus((decimal)dateTimePicker2.Value.Month, row[1].ToString(), "Absent");



                //Late
                L = ada.GetStatus((decimal)dateTimePicker2.Value.Month, row[1].ToString(), "Late");


                //Excuses
                E = ada.GetStatus((decimal)dateTimePicker2.Value.Month, row[1].ToString(), "Excused");




                ListViewItem litem = new ListViewItem();
                 litem.Text = row[1].ToString();
                 litem.SubItems.Add(p.ToString());
                 litem.SubItems.Add(A.ToString());
                 litem.SubItems.Add(L.ToString());
                 litem.SubItems.Add(E.ToString());
                 metroListView1.Items.Add(litem);
            }


            //add to listview
        }
    }
}
