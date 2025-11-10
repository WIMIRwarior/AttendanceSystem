using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class LoginForm : Form
    {

        public bool loginFlag { get; set; }
        public int UserID { get; set; }
        public string UserName {  get; set; }


        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton_Login_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter usersAdapter = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = usersAdapter.GetDataByUserAndPassword(metroTextBox_User.Text,metroTextBox_Password.Text);
            
            if(dt.Rows.Count > 0)
            {
                //Valid Login
                loginFlag = true;
                MessageBox.Show("Login OK");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                UserName = dt.Rows[0]["UserName"].ToString();
            }
            else
            {
                //Invalid Login
                MessageBox.Show("Access denied!");
                loginFlag = false;
            }
 
            Close();
        }
    }
}
