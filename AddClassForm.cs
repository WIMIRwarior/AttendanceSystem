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
    public partial class AddClassForm : Form
    {

        public int UserID { get; set; }

        public AddClassForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTableAdapter dt = new DataSet1TableAdapters.ClassesTableAdapter();
            dt.AddClass(metroTextBox_ClassName.Text, UserID);
            MessageBox.Show(UserID.ToString());
            Close();

        }
    }
}
