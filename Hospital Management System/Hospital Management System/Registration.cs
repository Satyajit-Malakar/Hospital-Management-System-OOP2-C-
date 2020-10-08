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
    public partial class Registration : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        public static string ID;

        public static int EX;

        public Registration()
        {
            InitializeComponent();
        }


        private void textFN_MouseClick(object sender, MouseEventArgs e)
        {
            if (textFN.Text == "First Name")
            {
                textFN.Clear();
                textFN.ForeColor = Color.FromArgb(48, 184, 206);
            }  
        }

        private void textLN_Click(object sender, EventArgs e)
        {
            if (textLN.Text == "Last Name")
            {
                textLN.Clear();
                textLN.ForeColor = Color.FromArgb(48, 184, 206);
            }       
        }

        private void textAddress_Click(object sender, EventArgs e)
        {
            if (textAddress.Text == "Address")
            {
                textAddress.Clear();
                textAddress.ForeColor = Color.FromArgb(48, 184, 206);
            }
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Clear();
                textEmail.ForeColor = Color.FromArgb(48, 184, 206);
            }    
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            if (textPhone.Text == "Phone Number")
            {
                textPhone.Clear();
                textPhone.ForeColor = Color.FromArgb(48, 184, 206);
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

        private void textConfirmP_Click(object sender, EventArgs e)
        {
            if (textConfirmP.Text == "Confirm Password")
            {
                textConfirmP.Clear();
                textConfirmP.PasswordChar = '*';
                textConfirmP.ForeColor = Color.FromArgb(48, 184, 206);
            }          
        }

        private void For_password1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textPassword.Text != "Password")
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

        private void For_password2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textConfirmP.Text != "Confirm Password")
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
        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Confirm_Reg.Enabled = true;
            }

            if (Accept.Checked == false)
            {
                Confirm_Reg.Enabled = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            First_Page f1 = new First_Page();
            f1.Show();
        }

        private void Confirm_Reg_Click(object sender, EventArgs e)
        {


            string Name = textFN.Text+" "+textLN.Text;
            string DOB = "";
            DOB = Day.Text + "-" + Month.Text + "-" + Year.Text;
            string B_G = Blood_Group.Text;
            string Address = textAddress.Text;
            string Gender = Gender1.Text;
            string Email = textEmail.Text;
            string Phone = textPhone.Text;
            string Password = textPassword.Text;
            string C_Password = textConfirmP.Text;


            string R_ID = "11-11";

            DateTime now = DateTime.Today;
            string Date_P = now.ToString("dd");

            string Time_P = "0";

            string Doctor_Name = "Nothing";


             int j, FN = 0, LN = 0, ab = 0;

            //------------------------For First Name---------------------

             for (j = 0; j < textFN.Text.Length; j++)
             {

                 if ((textFN.Text[j] >= 'A' && textFN.Text[j] <= 'Z') || (textFN.Text[j] >= 'a' && textFN.Text[j] <= 'z'))
                 {

                     FN = 1;

                 }
                 else
                 {
                     FN = 0; 
                     break;
                 }
             }

             //------------------------For Last Name---------------------


             for (j = 0; j < textLN.Text.Length; j++)
             {

                 if ((textLN.Text[j] >= 'A' && textLN.Text[j] <= 'Z') || (textLN.Text[j] >= 'a' && textLN.Text[j] <= 'z'))
                 {

                     LN = 1;

                 }
                 else
                 {
                     LN = 0; 
                     break;
                 }
             }

            //--------------------For Phone Numbe----------------------

             for (j = 0; j < Phone.Length; j++)
             {

                 if (Phone[j] >= '0' && Phone[j] <= '9')
                 {

                     ab = 1;

                 }
                 else
                 {
                     ab = 0; //Kono somoy jodi 0 theke choto or 9 theke boro digit pai tobe break
                     break;
                 }
             }

            //----------------------------------------------------------------------

            if(EX==1)
            {
                MessageBox.Show("You Have Already Registered");
            }

            else if ((textFN.Text == "" || textFN.Text == "First Name" ) || ( FN !=1 ))
            {
                MessageBox.Show("Please Enter Your First Name Which is Valid");
            }

            else if ((textLN.Text == "" || textLN.Text == "Last Name") || ( LN !=1 ))
            {
                MessageBox.Show("Please Enter Your Last Name Which is Valid");
            }

            else if (DOB.Length != 10)
            {
                MessageBox.Show("Please Enter All The Data for Date of Birth");
            }

            else if (B_G == "")
            {
                MessageBox.Show("Please Enter Your Blood Group");
            }

            else if (Gender == "")
            {
                MessageBox.Show("Please Enter Your Gender");
            }

            else if (Address == "" || Address == "Address")
            {
                MessageBox.Show("Please Enter Your Address");
            }

            //else if (Email == "" || Email == "Email")
            //{
            //    MessageBox.Show("Please Enter Your Email");
            //}

            else if (Phone == "" || Phone == "Phone Number")
            {
                MessageBox.Show("Please Enter Your Phone Number");
            }

            else if (!(ab == 1 && Phone.Length == 11))
            {
                MessageBox.Show("Enter Correct Phone Number Which Contain 11 Digit");
            }

            else if (Password == "" || Password == "Password")
            {
                MessageBox.Show("Please Enter Your Password");
            }

            else if (C_Password == "" || C_Password == "Confirm Password")
            {
                MessageBox.Show("Please Enter Your Confirm Password");
            }

            else if (Password != C_Password)
            {
                MessageBox.Show("Password Did Not Match \nPlease Enter Same Password");
            }

            else
            {
                    EX = 1;

                    SqlCommand insertcommand = new SqlCommand("insert into Patient(Password, P_Name, P_DOB, Phone, E_Mail, Gender,Blood_Group, R_ID, Address, Date, Time, D_Name) values(@Password, @Name, @DOB, @Phone, @Email, @Gender, @B_G, @R_ID, @Address, @Date_P, @Time_P, @Doctor_Name) ");

                    insertcommand.Parameters.AddWithValue("@Password", Password);
                    insertcommand.Parameters.AddWithValue("@Name", Name);
                    insertcommand.Parameters.AddWithValue("@DOB", DOB);
                    insertcommand.Parameters.AddWithValue("@Phone", Phone);
                    insertcommand.Parameters.AddWithValue("@Email", Email);
                    insertcommand.Parameters.AddWithValue("@Gender", Gender);
                    insertcommand.Parameters.AddWithValue("@B_G", B_G);
                    insertcommand.Parameters.AddWithValue("@R_ID", R_ID);
                    insertcommand.Parameters.AddWithValue("@Address", Address);
                    insertcommand.Parameters.AddWithValue("@Date_P", Date_P);
                    insertcommand.Parameters.AddWithValue("@Time_P", Time_P);
                    insertcommand.Parameters.AddWithValue("@Doctor_Name", Doctor_Name);

                    

                    int row = objDBAccess.executeQuery(insertcommand);


                    if (row == 1)
                    {
                        string q = "select * from Patient where E_Mail='" + Email + "' and Phone='" + Phone + "' and Password='" + Password + "'";
                        objDBAccess.readDatathroughAdapter(q, dtUsers);
                        if (dtUsers.Rows.Count == 1)
                        {
                            ID = dtUsers.Rows[0]["P_ID"].ToString();


                            string s = "0";
                            SqlCommand insert = new SqlCommand("insert into Bill(P_ID, Amount) values(@ID, @s) ");

                            insert.Parameters.AddWithValue("@ID", ID);
                            insert.Parameters.AddWithValue("@s", s);

                            objDBAccess.executeQuery(insert);

                            objDBAccess.closeConn();

                            MessageBox.Show("Your Registration is Done \n" + "Your ID is: " + ID );

                            //this.Close();
                            //First_Page f = new First_Page();
                            //f.Show();
                        }
                    }
                }
                
        }

        private void TandC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Satyajit\Desktop\Hospital Management System\Terms-Condition.pdf");
        }

        private void Registration_Load(object sender, EventArgs e)
        {

            //--------------------------------Insert New Year In Combo Box ----------------------

            DateTime now = DateTime.Today;

            string str2 = now.ToString("yyyy");
            int Year2 = Int32.Parse(str2);

            int i, Year1 = 1899;
            int Gap = Year2 - Year1;

            if (Gap != 0)
            {
                for (i = 0; i < Gap; i++)
                {
                    Year1 = Year1 + 1;
                    Year.Items.Add(Year1);
                }
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter First Name and Last Name Without Space \nYou Must Confirm Your Password \nYou Must Fill Everything but you may skip E-mail ", "Help");
        }


    }
}
