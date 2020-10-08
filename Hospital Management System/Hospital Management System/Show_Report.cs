using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;


namespace Hospital_Management_System
{
    public partial class Show_Report : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Show_Report()
        {
            InitializeComponent();
        }

        private void Show_Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Patient_ID_Click(object sender, EventArgs e)
        {
            if (Patient_ID.Text == "P_ID")
            {
                Patient_ID.Clear();
                Patient_ID.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void Test_ID_Click(object sender, EventArgs e)
        {
            if (Test_ID.Text == "T_ID")
            {
                Test_ID.Clear();
                Test_ID.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string ID_P = Patient_ID.Text;
            string ID_T = Test_ID.Text;

            if (ID_P == " " || ID_P == "P_ID")
            {
                MessageBox.Show("Please Enter Patient ID");
            }

            else if (ID_T == " " || ID_T == "T_ID")
            {
                MessageBox.Show("Please Enter Test ID");
            }

            else
            {
                string q = "Select * from Report where P_ID='" + ID_P + "' and T_ID='" + ID_T + "' ";

                objDBAccess.readDatathroughAdapter(q, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    textBox1.Text = dtUsers.Rows[0]["T_Name"].ToString();

                    objDBAccess.closeConn();

                    ReportDataSource rds = new ReportDataSource("DataSet1", dtUsers);
                    reportViewer1.LocalReport.ReportPath = @"C:\Users\Satyajit\Desktop\Hospital Management System\Hospital Management System\Report_Viewer.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }

                else
                {
                    MessageBox.Show("Incorrect Patient or Test ID ");
                }
                
            }
            
        }

        private void Show_Report_Load_1(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Report SR = new Show_Report();
            SR.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press Refresh Button To Search For New Reports","Help");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (First_Page.ss == 1)
            {
                this.Close();
                Doctor_See_Patient DSP = new Doctor_See_Patient();
                DSP.Show();
            }

            else if (First_Page.ss == 2)
            {
                this.Close();
                Receptionist R2 = new Receptionist();
                R2.Show();
            }

            else if (First_Page.ss == 3)
            {
                this.Close();
                Patient_Page PP = new Patient_Page();
                PP.Show();
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (M.Text == "Maximize")
            {
                WindowState = FormWindowState.Maximized;
                M.Text = "Normal";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                M.Text = "Maximize";
            }
        }
        
    }
}
