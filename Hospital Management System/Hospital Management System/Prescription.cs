using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string m = "Printing!!!!!!";

            if (MessageBox.Show("Are You Sure To Print The Prescription ?", "Print", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(m);
            }
        }

        private void Doctor_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Page_Click(object sender, EventArgs e)
        {

        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            Patient_Name.Text = Doctor.Name;
            Patient_Age.Text = Doctor_See_Patient.AGE3.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor_See_Patient ds = new Doctor_See_Patient();
            ds.Show();
        }
    }
}
