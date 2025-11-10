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
    public partial class AddStudentsForm : Form
    {

        public string className {  get; set; }
        public int classID { get; set; }

        public AddStudentsForm()
        {
            InitializeComponent();
        }

        private void AddStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.Students' . Możesz go przenieść lub usunąć.
            this.studentsTableAdapter.Fill(this.dataSet1.Students);
            studentsBindingSource.Filter = "ClassID = '"+classID.ToString()+"'";
            
            metroLabel_ClassName.Text = className;
            metroLabel_ClassID.Text = classID.ToString();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentsBindingSource.EndEdit();
            this.studentsTableAdapter.Update(dataSet1.Students);
        }
    }
}
