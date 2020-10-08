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
    public partial class Doctor : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DataTable dtUsers2 = new DataTable();
        DataTable PtUsers = new DataTable(); 

        public static string Name, DOB, Blood_group, Gender,id, Amount;

        public static string str2, Date1;

        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            Doctor_ID.Text = First_Page.ID_D;
            Doctor_Name.Text = First_Page.Name_D;



            string ID = "53";
            string q0 = "Select * from Patient where P_ID='" + ID + "' ";

            objDBAccess.readDatathroughAdapter(q0, dtUsers2);

            Date1 = dtUsers2.Rows[0]["Date"].ToString();

            DateTime now = DateTime.Today;

            str2 = now.ToString("dd");

            if (Date1 != str2)
            {
                //-------------Date Update for ALL Patient & Update for Appointed to Not Appointed-------------------

                string str4 = "0";
                string str5 = "Nothing";
                string str3 = "Not Appointed";
                string q2 = "Update Appointment set Appoint1='" + @str3 + "', Appoint2='" + @str3 + "', Appoint3='" + @str3 + "', Appoint4='" + @str3 + "',Appoint5='" + @str3 + "', Appoint6='" + @str3 + "' , Appoint7='" + @str3 + "', Appoint8='" + @str3 + "' ";
                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint1", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint2", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint3", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint4", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint5", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint6", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint7", @str3);
                updatecommand.Parameters.AddWithValue("@Appoint8", @str3);

                objDBAccess.executeQuery(updatecommand);

                //----------------------------------------------------------------------------

                string q = "Update Patient set Date='" + @str2 + "', Time='" + str4 + "', D_Name='" + str5 + "' ,Amount='" + str4 + "' ";
                SqlCommand updatecommand1 = new SqlCommand(q);

                updatecommand1.Parameters.AddWithValue("@Date", @str2);
                updatecommand1.Parameters.AddWithValue("@Time", @str4);
                updatecommand1.Parameters.AddWithValue("@D_Name", @str5);
                updatecommand1.Parameters.AddWithValue("@Amount", @str4);

                objDBAccess.executeQuery(updatecommand1);

            }

        }

        private void Search_Click(object sender, EventArgs e)
        {

            string max = "SELECT * FROM Patient where P_ID =(Select Max(P_ID) from Patient)";

            objDBAccess.readDatathroughAdapter(max, PtUsers);


            if (PtUsers.Rows.Count == 1)
            {
                id = PtUsers.Rows[0]["P_ID"].ToString();

            }

            if (textP_ID.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Patient ID");
            }

            else if (Int32.Parse(textP_ID.Text) > Int32.Parse(id))
            {
                MessageBox.Show("Patient ID Out of Bound");
            }
            

            else
            {

                string P_ID = textP_ID.Text;

                string q = "Select * from Patient where P_ID='" + P_ID + "' ";

                objDBAccess.readDatathroughAdapter(q, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    Name = dtUsers.Rows[0]["P_Name"].ToString();
                    DOB = dtUsers.Rows[0]["P_DOB"].ToString();
                    Blood_group = dtUsers.Rows[0]["Blood_Group"].ToString();
                    Gender = dtUsers.Rows[0]["Gender"].ToString();
                    Amount = dtUsers.Rows[0]["Amount"].ToString();

                    

                    if (Amount != "0")
                    {
                        MessageBox.Show("Tell Patient To Pay First");

                        //---------------To Refresh The Page------------------------
                        this.Close();
                        Doctor D4 = new Doctor();
                        D4.Show();
                    }

                    else
                    {
                        this.Hide();
                        Doctor_See_Patient DP1 = new Doctor_See_Patient();
                        DP1.Show();
                    }

                    

                    objDBAccess.closeConn();
                }
                else
                {
                    MessageBox.Show("ID Does Not Exist");
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Update_Doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Doctor_Info D_U = new Update_Doctor_Info();
            D_U.Show();
        }

        private void Show_A_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_See_Appointment DSA = new Doctor_See_Appointment();
            DSA.Show();
        }


    }
}
