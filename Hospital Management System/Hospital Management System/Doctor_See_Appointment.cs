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
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Doctor_See_Appointment : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Doctor_See_Appointment()
        {
            InitializeComponent();
        }

        private void Doctor_See_Appointment_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void Load_Click(object sender, EventArgs e)
        {

            string q = "Select * from Patient where D_Name='" + First_Page.Name_D + "'  ";

            objDBAccess.readDatathroughAdapter(q, dtUsers);

            objDBAccess.closeConn();

            ReportDataSource rds = new ReportDataSource("DataSet1", dtUsers);
            reportViewer2.LocalReport.ReportPath = @"C:\Users\Satyajit\Desktop\Hospital Management System\Hospital Management System\Report_Appointment.rdlc";
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();

            if (dtUsers.Rows.Count == 0)
            {
                MessageBox.Show("You Have No Appointment");
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
            Doctor d3 = new Doctor();
            d3.Show();
        }
    }
}
