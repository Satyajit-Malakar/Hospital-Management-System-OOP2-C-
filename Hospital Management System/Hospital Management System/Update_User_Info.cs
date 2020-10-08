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
    public partial class Update_User_Info : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string B_G1, Gender1, Address1, Email1, Password1, C_Password1, Phone1, P_ID, Name1;


        public Update_User_Info()
        {
            InitializeComponent();
        }

        private void Update_User_Info_Load(object sender, EventArgs e)
        {
            textPassword2.PasswordChar = '*';
            textConfirmP2.PasswordChar = '*';

            Name2.Text = First_Page.Name;
            B_G2.Text = First_Page.Blood_group;
            Gender2.Text = First_Page.Gender;
            textAddress2.Text = First_Page.Address;
            textEmail2.Text = First_Page.Email;
            textPhone2.Text = First_Page.Phone;
            textPassword2.Text = First_Page.Pass12;
            textConfirmP2.Text = First_Page.Pass12;
        }

        private void Name2_Click(object sender, EventArgs e)
        {
            Name2.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textAddress_Click(object sender, EventArgs e)
        {
            textAddress2.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            textEmail2.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            textPhone2.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            textPassword2.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textConfirmP_Click(object sender, EventArgs e)
        {
            textConfirmP2.ForeColor = Color.FromArgb(48, 184, 206);
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

        private void For_password1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password1.Text == "Show")
            {
                textPassword2.PasswordChar = '\0';
                For_password1.Text = "Hide";
            }
            else
            {
                textPassword2.PasswordChar = '*';
                For_password1.Text = "Show";
            }
        }

        private void For_password2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password2.Text == "Show")
            {
                textConfirmP2.PasswordChar = '\0';
                For_password2.Text = "Hide";
            }
            else
            {
                textConfirmP2.PasswordChar = '*';
                For_password2.Text = "Show";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page p1 = new Patient_Page();
            p1.Show();
        }

        private void T_and_C_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Satyajit\Desktop\Hospital Management System\Terms-Condition.pdf");
        }
 
        private void Confirm_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To  Update?", "Update", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                P_ID = First_Page.ID2;

                //if (B_G2.Text.Length != 0)
                //{
                //    B_G1 = B_G2.Text;
                //}
                //else if (Gender2.Text.Length != 0)
                //{
                //    Gender1 = Gender2.Text;
                //}

                //else if (textAddress2.Text.Length != 0)
                //{
                //    Address1 = textAddress2.Text;
                //}

                //else if (textEmail2.Text.Length != 0)
                //{
                //    Email1 = textEmail2.Text;
                //}

                //else if (textPhone2.Text.Length != 0)
                //{
                //    Phone1 = textPhone2.Text;
                //}

                //else if (textPassword2.Text.Length != 0)
                //{
                //    Password1 = textPassword2.Text;
                //}

                //else if (textConfirmP2.Text.Length != 0)
                //{
                //    C_Password1 = textConfirmP2.Text;
                //}

                Password1 = textPassword2.Text;
                B_G1 = B_G2.Text;
                Name1 = Name2.Text;
                Gender1 = Gender2.Text;
                Address1 = textAddress2.Text;
                Email1 = textEmail2.Text;
                Phone1 = textPhone2.Text;

                if (Name2.Text == "" || Name2.Text == "Name")
                {
                    MessageBox.Show("Please Enter Your Name \nFirst Name and Last Name");
                }

                else if (textPassword2.Text == "" || textConfirmP2.Text == "Password")
                {
                    MessageBox.Show("Please Enter Your Password");
                }

                else if (textConfirmP2.Text == "" || textConfirmP2.Text == "Confirm Password")
                {
                    MessageBox.Show("Please Enter Your Confirm Password");
                }

                else if (textPassword2.Text != textConfirmP2.Text)
                {
                    MessageBox.Show("Password Did Not Match \nPlease Enter Same Password");
                }

                else if (textAddress2.Text == "" || textAddress2.Text == "Address")
                {
                    MessageBox.Show("Please Enter Your Address");
                }


                else if (textPhone2.Text == "" || textPhone2.Text == "Phone Number")
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
                        string q = "Update Patient set Password='" + @Password1 + "' , P_Name='" + @Name1 + "' , Phone='" + @Phone1 + "' , E_Mail='" + @Email1 + "' , Gender='" + @Gender1 + "' , Blood_Group='" + @B_G1 + "', Address='" + @Address1 + "' where P_ID='" + @P_ID + "' ";
                        SqlCommand updatecommand = new SqlCommand(q);

                        updatecommand.Parameters.AddWithValue("@Password", @Password1);
                        updatecommand.Parameters.AddWithValue("@P_Name", @Name1);
                        updatecommand.Parameters.AddWithValue("@Phone", @Phone1);
                        updatecommand.Parameters.AddWithValue("@E_Mail", @Email1);
                        updatecommand.Parameters.AddWithValue("@Gender", @Gender1);
                        updatecommand.Parameters.AddWithValue("@Blood_Group", @B_G1);
                        updatecommand.Parameters.AddWithValue("@Address", @Address1);

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
