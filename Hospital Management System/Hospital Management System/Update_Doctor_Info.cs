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
    public partial class Update_Doctor_Info : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string Name1, Degree1, Email1, Password1, C_Password1, Phone1, D_ID;

        public Update_Doctor_Info()
        {
            InitializeComponent();
        }

        private void Name_Click(object sender, EventArgs e)
        {
            Name.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void Degree_Click(object sender, EventArgs e)
        {
            Degree.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            textEmail.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            textPhone.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            textPassword.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textConfirmP_Click(object sender, EventArgs e)
        {
            textConfirmP.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor D2 = new Doctor();
            D2.Show();
        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Confirm_Update.Enabled = true;
            }

            if (Accept.Checked == false)
            {
                Confirm_Update.Enabled = false;
            }
        }

        

        private void Update_Doctor_Info_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
            textConfirmP.PasswordChar = '*';

            Name.Text = First_Page.Name_D;
            Degree.Text = First_Page.Degg_D;
            textEmail.Text = First_Page.Email_D;
            textPhone.Text = First_Page.Phone_D;
            textPassword.Text = First_Page.Pass_D;
            textConfirmP.Text = First_Page.Pass_D;

        }

        private void For_password1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void For_password2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password2.Text == "Show")
            {
                textConfirmP.PasswordChar = '\0';
                For_password2.Text = "Hide";
            }
            else
            {
                textConfirmP.PasswordChar = '*';
                For_password2.Text = "Show";
            }
        }

        private void Confirm_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To  Update?", "Update", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                D_ID = First_Page.ID_D;
                //MessageBox.Show(D_ID);

                //if (Name.Text.Length != 0)
                //{
                //    Name1 = Name.Text;
                //}
                //else if (Degree.Text.Length != 0)
                //{
                //    Degree1 = Degree.Text;
                //}

                //else if (textEmail.Text.Length != 0)
                //{
                //    Email1 = textEmail.Text;
                //}

                //else if (textPhone.Text.Length != 0)
                //{
                //    Phone1 = textPhone.Text;
                //}

                //else if (textPassword.Text.Length != 0)
                //{
                //    Password1 = textPassword.Text;
                //}

                //else if (textConfirmP.Text.Length != 0)
                //{
                //    C_Password1 = textConfirmP.Text;
                //}

                Password1 = textPassword.Text;
                Name1 = Name.Text;
                Degree1 = Degree.Text;
                Email1 = textEmail.Text;
                Phone1 = textPhone.Text;

                if (Name.Text == "" || Name.Text == "Name")
                {
                    MessageBox.Show("Please Enter Your Name \nFirst Name and Last Name");
                }

                else if (Degree.Text == "" || Degree.Text == "Degree")
                {
                    MessageBox.Show("Please Enter Your Degree ");
                }

                else if (textPassword.Text == "" || textConfirmP.Text == "Password")
                {
                    MessageBox.Show("Please Enter Your Password");
                }

                else if (textConfirmP.Text == "" || textConfirmP.Text == "Confirm Password")
                {
                    MessageBox.Show("Please Enter Your Confirm Password");
                }

                else if (textPassword.Text != textConfirmP.Text)
                {
                    MessageBox.Show("Password Did Not Match \nPlease Enter Same Password");
                }

                else if (textPhone.Text == "" || textPhone.Text == "Phone Number")
                {
                    MessageBox.Show("Please Enter Your Phone Number");
                }

                else
                {
                    int i, ab = 0;

                    for (i = 0; i < Phone1.Length; i++)
                    {

                        if (Phone1[i] >= '0' && Phone1[i] <= '9')
                        {
                            ab = 1;
                        }
                        else
                        {
                            ab = 0; //Kono somoy jodi 0 theke choto or 9 theke boro digit pai tobe break
                            break;
                        }
                    }

                    if (ab == 1 && Phone1.Length == 11)
                    {
                        string q = "Update Doctor set Password='" + @Password1 + "' , D_Name='" + @Name1 + "' , Phone='" + @Phone1 + "' , E_Mail='" + @Email1 + "' , Degree='" + @Degree1 + "' where D_ID='" + @D_ID + "' ";
                        SqlCommand updatecommand = new SqlCommand(q);

                        updatecommand.Parameters.AddWithValue("@Password", @Password1);
                        updatecommand.Parameters.AddWithValue("@D_Name", @Name1);
                        updatecommand.Parameters.AddWithValue("@Phone", @Phone1);
                        updatecommand.Parameters.AddWithValue("@E_Mail", @Email1);
                        updatecommand.Parameters.AddWithValue("@Degree", @Degree1);

                        int row = objDBAccess.executeQuery(updatecommand);

                        if (row == 1)
                        {
                            MessageBox.Show("Update Complete \nPlease Re-Login");
                            this.Hide();

                            First_Page f11 = new First_Page();
                            f11.Show();

                        }

                    }

                    else
                    {
                        MessageBox.Show("Enter Correct Phone Number Which Contain 11 Digit");
                    }
                }
            }
        }

     
        
    }
}
