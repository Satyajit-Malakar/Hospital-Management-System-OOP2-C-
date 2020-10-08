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
    public partial class Delete_Patient_Data : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Delete_Patient_Data()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, EventArgs e)
        {
            if (ID.Text == "Patient  ID")
            {
                ID.Clear();
                ID.ForeColor = Color.FromArgb(48, 184, 206);
            }
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Clear();
                textPassword.PasswordChar = '*';
                textPassword.ForeColor = Color.FromArgb(48, 184, 206);
            }
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page PP1 = new Patient_Page();
            PP1.Show();
        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Confirm_Delete.Enabled = true;
            }

            if (Accept.Checked == false)
            {
                Confirm_Delete.Enabled = false;
            }
        }

        private void Confirm_Delete_Click(object sender, EventArgs e)
        {

            if (ID.Text == "" || ID.Text == "Patient  ID")
            {
                MessageBox.Show("Please Enter Your ID");
            }

            else if (textPassword.Text == "" || textPassword.Text == "Password")
            {
                MessageBox.Show("Please Enter Your Password");
            }

            else if (ID.Text != First_Page.ID2)
            {
                MessageBox.Show("Please Enter Correct ID ");
            }

            else if (textPassword.Text != First_Page.Pass12)
            {
                MessageBox.Show("Please Enter Correct Password");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Are You Sure That You Want To Delete All Your Data Permanently?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string q = "Delete from Patient where P_ID='"+ First_Page.ID2 +"' and Password='"+ First_Page.Pass12 +"'" ;

                    SqlCommand delete = new SqlCommand(q);
                    int row = objDBAccess.executeQuery(delete);

                    if (row == 1)
                    {
                        MessageBox.Show("Deletation is Done \nThanks For Being With Us");
                        this.Close();
                        First_Page FP3 = new First_Page();
                        FP3.Show();
                    }
                }
 
            }
        }

        private void For_password1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password1.Text == "Show")
            {
                textPassword.PasswordChar = '\0';
                For_password1.Text = "Hide";
            }
            else
            {
                textPassword.PasswordChar = '*';
                For_password1.Text = "Show";
            }
        }

    }
}
