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
    public partial class Doctor_See_Patient : Form
    {
        string s = Doctor.DOB;
        public static int AGE3;

        public Doctor_See_Patient()
        {
            InitializeComponent();
        }

        private void textFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test_Information_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Report SR = new Show_Report();
            SR.Show();
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
            Doctor D1 = new Doctor();
            D1.Show();
        }

        private void Prescription_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescription Pr = new Prescription();
            Pr.Show();
        }

        private void Doctor_See_Patient_Load(object sender, EventArgs e)
        {
            char[] age = new char[4];
            age[0] = s[6];
            age[1] = s[7];
            age[2] = s[8];
            age[3] = s[9];

            string str = new string(age);
            int AGE = Int32.Parse(str);

            DateTime now = DateTime.Today;

            string str2=now.ToString("yyyy");
            int AGE2 = Int32.Parse(str2);

            AGE3 = AGE2 - AGE;

            textPatient.Text = Doctor.Name;
            textB_G.Text = Doctor.Blood_group;
            textAge.Text = AGE3.ToString();
            textGender.Text = Doctor.Gender;
        }
    }
}
