using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospital_Management_System
{
    public partial class First_Page : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string Name, DOB, Blood_group, Gender, Address, Phone, Email, ID2, Pass12, Date1, Time1;
        public static DateTime dob;

        public static string ID_D, Name_D, Pass_D, Degg_D, Email_D, Phone_D ;

        public static string ID_R, Name_R;

        public static int ss = 0;

        public First_Page()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (User_ID.Text == "User ID")
            {
                User_ID.Clear();
                User_ID.ForeColor = Color.FromArgb(48, 184, 206);
            }  
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Clear();
                Pass.PasswordChar = '*';
                Pass.ForeColor = Color.FromArgb(48, 184, 206);
            }    
        }

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Reg(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.Show();
        }

        private void SignIN_Click(object sender, EventArgs e)
        {
            if (User_ID.Text == "" || User_ID.Text == "User ID")
            {
                MessageBox.Show("Please Enter Your ID");
            }
            else if (Pass.Text == "" || Pass.Text == "Password")
            {
                MessageBox.Show("Please Enter Your Password");
            }


            else
            {
                string ID = User_ID.Text;
                string Password = Pass.Text;

                if (ID.Length == 4 && ID[1] == '-')
                {
                    ss = 1;

                    ////-------------------------------------Doctor Login--------------------------------------------

                    string q = "Select * from Doctor where D_ID='" + ID + "' and Password='" + Password + "' ";

                    objDBAccess.readDatathroughAdapter(q, dtUsers);

                    if (dtUsers.Rows.Count == 1)
                    {
                        ID_D = dtUsers.Rows[0]["D_ID"].ToString();
                        Name_D = dtUsers.Rows[0]["D_Name"].ToString();
                        Degg_D = dtUsers.Rows[0]["Degree"].ToString();
                        Phone_D = dtUsers.Rows[0]["Phone"].ToString();
                        Pass_D = dtUsers.Rows[0]["Password"].ToString();
                        Email_D = dtUsers.Rows[0]["E_Mail"].ToString();

                        objDBAccess.closeConn();

                        this.Hide();
                        Doctor D1 = new Doctor();
                        D1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Craiteria");
                    }
                }


                else if (ID.Length == 5 && ID[2] == '-')
                {
                    ss = 2;

                    //--------------------------------Receptionist Login----------------------------------

                    string q = "Select * from Receptionist where R_ID='" + ID + "' and Password='" + Password + "' ";

                    objDBAccess.readDatathroughAdapter(q, dtUsers);

                    if (dtUsers.Rows.Count == 1)
                    {
                        ID_R = dtUsers.Rows[0]["R_ID"].ToString();
                        Name_R = dtUsers.Rows[0]["R_Name"].ToString();

                        objDBAccess.closeConn();

                        this.Hide();
                        Receptionist R1 = new Receptionist();
                        R1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Craiteria");
                    }

                    //---------------------------------------------------------------------------------

                }

                else
                {
                    ss = 3;

                    //--------------------------------Patient Login----------------------------------
                    string q = "Select * from Patient where P_ID='" + ID + "' and Password='" + Password + "' ";

                    objDBAccess.readDatathroughAdapter(q, dtUsers);

                    if (dtUsers.Rows.Count == 1)
                    {
                        ID2 = dtUsers.Rows[0]["P_ID"].ToString();
                        Name = dtUsers.Rows[0]["P_Name"].ToString();
                        DOB = dtUsers.Rows[0]["P_DOB"].ToString();
                        Blood_group = dtUsers.Rows[0]["Blood_Group"].ToString();
                        Gender = dtUsers.Rows[0]["Gender"].ToString();
                        Address = dtUsers.Rows[0]["Address"].ToString();
                        Phone = dtUsers.Rows[0]["Phone"].ToString();
                        Email = dtUsers.Rows[0]["E_Mail"].ToString();

                        Pass12 = dtUsers.Rows[0]["Password"].ToString();

                        Date1 = dtUsers.Rows[0]["Date"].ToString();
                        Time1 = dtUsers.Rows[0]["Time"].ToString();

                        objDBAccess.closeConn();

                        this.Hide();
                        Patient_Page p1 = new Patient_Page();
                        p1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Criteria");
                    }

                    //---------------------------------------------------------------------------------

                }


            }
        }

        private void For_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Pass.Text != "Password")
            {
                if (For_password.Text == "Show")
                {
                    Pass.PasswordChar = '\0';
                    For_password.Text = "Hide";
                }
                else
                {
                    Pass.PasswordChar = '*';
                    For_password.Text = "Show";
                }
            }
        }

        private void First_Page_Load(object sender, EventArgs e)
        {

        }


       
       
    }
}
