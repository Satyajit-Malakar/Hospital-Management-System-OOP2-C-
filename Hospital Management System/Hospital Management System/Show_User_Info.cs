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
    public partial class Show_User_Info : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Show_User_Info()
        {
            InitializeComponent();
        }


        private void bttn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page p1 = new Patient_Page();
            p1.Show();
        }


        //private void For_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    if (For_password.Text == "Show")
        //    {
        //        textPassword.PasswordChar = '\0';
        //        For_password.Text = "Hide";
        //    }
        //    else
        //    {
        //        textPassword.PasswordChar = '*';
        //        For_password.Text = "Show";
        //    }
        //}

        private void Show_User_Info_Load(object sender, EventArgs e)
        {
            textN.Text = First_Page.Name;
            textDOB.Text = First_Page.DOB;
            textB_G.Text = First_Page.Blood_group;
            textGender.Text = First_Page.Gender;
            textPhone.Text = First_Page.Phone;
            textEmail.Text = First_Page.Email;
            textAddress.Text = First_Page.Address;

           
        }



     
    }
}
