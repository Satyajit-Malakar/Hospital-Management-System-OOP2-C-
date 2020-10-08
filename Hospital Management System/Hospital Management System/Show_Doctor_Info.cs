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
    public partial class Show_Doctor_Info : Form
    {
        public static int a1=0;
        public static string D_ID = null,D_Name;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DataTable dtUsers2 = new DataTable();
        DataTable dtUsers3 = new DataTable();
        DataTable dtUsers4 = new DataTable();
        DataTable dtUsers5 = new DataTable();
        DataTable dtUsers6 = new DataTable();

        public Show_Doctor_Info()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Appoint1_Click(object sender, EventArgs e)
        {
            if (D_Name != "Nothing")
            {
                MessageBox.Show("You have already got an appointment \nYou can not take any more appointment for today");
            }

            else
            {
                a1 = 1;
                D_ID = "1-11";
                this.Hide();
                Appoint A1 = new Appoint();
                A1.Show();
            }
        }

        private void Appoint2_Click(object sender, EventArgs e)
        {
            if (D_Name != "Nothing")
            {
                MessageBox.Show("You have already got an appointment \nYou can not take any more appointment for today");
            }
            else
            {
                a1 = 2;
                D_ID = "1-12";
                this.Hide();
                Appoint A2 = new Appoint();
                A2.Show();
            }
        }

        private void Appoint3_Click(object sender, EventArgs e)
        {
            if (D_Name != "Nothing")
            {
                MessageBox.Show("You have already got an appointment \nYou can not take any more appointment for today");
            }
            else
            {
                a1 = 3;
                D_ID = "1-13";
                this.Hide();
                Appoint A3 = new Appoint();
                A3.Show();
            }
        }

        private void Appoint4_Click(object sender, EventArgs e)
        {
            if (D_Name != "Nothing")
            {
                MessageBox.Show("You have already got an appointment \nYou can not take any more appointment for today");
            }
            else
            {
                a1 = 4;
                D_ID = "1-14";
                this.Hide();
                Appoint A4 = new Appoint();
                A4.Show();
            }
        }

        private void Appoint5_Click(object sender, EventArgs e)
        {
            if (D_Name != "Nothing")
            {
                MessageBox.Show("You have already got an appointment \nYou can not take any more appointment for today");
            }
            else
            {
                a1 = 5;
                D_ID = "1-15";
                this.Hide();
                Appoint A5 = new Appoint();
                A5.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page p2 = new Patient_Page();
            p2.Show();
        }

        private void Show_Doctor_Info_Load(object sender, EventArgs e)
        {

            //----------------------------------D1----------------------------------
            string q1 = "Select * from Doctor where D_ID='" + "1-11" + "' ";

            objDBAccess.readDatathroughAdapter(q1, dtUsers);

            if (dtUsers.Rows.Count == 1)
            {
                textD1.Text = dtUsers.Rows[0]["D_Name"].ToString();
                textDeg1.Text = dtUsers.Rows[0]["Degree"].ToString();
                Am1.Text = dtUsers.Rows[0]["Payment"].ToString();
                D_T1.Text = dtUsers.Rows[0]["D_Time"].ToString();

                objDBAccess.closeConn();

            }

            //----------------------------------D2----------------------------------
            string q2 = "Select * from Doctor where D_ID='" + "1-12" + "' ";

            objDBAccess.readDatathroughAdapter(q2, dtUsers2);

            if (dtUsers.Rows.Count == 1)
            {
                textD2.Text = dtUsers2.Rows[0]["D_Name"].ToString();
                textDeg2.Text = dtUsers2.Rows[0]["Degree"].ToString();
                Am2.Text = dtUsers2.Rows[0]["Payment"].ToString();
                D_T2.Text = dtUsers2.Rows[0]["D_Time"].ToString();

                objDBAccess.closeConn();

            }

            //----------------------------------D3----------------------------------
            string q3 = "Select * from Doctor where D_ID='" + "1-13" + "' ";

            objDBAccess.readDatathroughAdapter(q3, dtUsers3);

            if (dtUsers3.Rows.Count == 1)
            {
                textD3.Text = dtUsers3.Rows[0]["D_Name"].ToString();
                textDeg3.Text = dtUsers3.Rows[0]["Degree"].ToString();
                Am3.Text = dtUsers3.Rows[0]["Payment"].ToString();
                D_T3.Text = dtUsers3.Rows[0]["D_Time"].ToString();

                objDBAccess.closeConn();

            }

            //----------------------------------D4----------------------------------
            string q4 = "Select * from Doctor where D_ID='" + "1-14" + "' ";

            objDBAccess.readDatathroughAdapter(q4, dtUsers4);

            if (dtUsers4.Rows.Count == 1)
            {
                textD4.Text = dtUsers4.Rows[0]["D_Name"].ToString();
                textDeg4.Text = dtUsers4.Rows[0]["Degree"].ToString();
                Am4.Text = dtUsers4.Rows[0]["Payment"].ToString();
                D_T4.Text = dtUsers4.Rows[0]["D_Time"].ToString();

                objDBAccess.closeConn();

            }

            //----------------------------------D5----------------------------------
            string q5 = "Select * from Doctor where D_ID='" + "1-15" + "' ";

            objDBAccess.readDatathroughAdapter(q5, dtUsers5);

            if (dtUsers5.Rows.Count == 1)
            {
                textD5.Text = dtUsers5.Rows[0]["D_Name"].ToString();
                textDeg5.Text = dtUsers5.Rows[0]["Degree"].ToString();
                Am5.Text = dtUsers5.Rows[0]["Payment"].ToString();
                D_T5.Text = dtUsers5.Rows[0]["D_Time"].ToString();

                objDBAccess.closeConn();

            }

            //-----------------------------Get D_Name From Patient---------------------
            string q6 = "Select * from Patient where P_ID='" + First_Page.ID2 + "' ";

            objDBAccess.readDatathroughAdapter(q6, dtUsers6);

            if (dtUsers6.Rows.Count == 1)
            {
                D_Name = dtUsers6.Rows[0]["D_Name"].ToString();

                objDBAccess.closeConn();
            }
        }
    }
}
