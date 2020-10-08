using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Appoint_Time : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Appoint_Time()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page PP2 = new Patient_Page();
            PP2.Show();
        }

        private void Appoint_Time_Load(object sender, EventArgs e)
        {
            string q1 = "Select * from Patient where P_ID='" + First_Page.ID2 + "' ";

            objDBAccess.readDatathroughAdapter(q1, dtUsers);

            if (dtUsers.Rows.Count == 1)
            {
                textD_Name.Text = dtUsers.Rows[0]["D_Name"].ToString();
                textTime.Text = dtUsers.Rows[0]["Time"].ToString();
                Amount_P.Text = dtUsers.Rows[0]["Amount"].ToString();

                DateTime now = DateTime.Today;

                string str2 = now.ToString("dd"+"-"+"MM"+"-"+"yyyy");
                textDate.Text = str2;

                objDBAccess.closeConn();

            }

        }
    }
}
