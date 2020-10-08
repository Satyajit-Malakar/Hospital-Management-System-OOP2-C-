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
    public partial class Patient_Page : Form
    {
        public static string str2, D_Name, Time;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
     

        public Patient_Page()
        {
            InitializeComponent();
        }

        private void Show_User_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_User_Info U1 = new Show_User_Info();
            U1.Show();
        }

        private void Show_Doctor_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Doctor_Info D1 = new Show_Doctor_Info();
            D1.Show();
        }

        private void Update_User_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_User_Info U2 = new Update_User_Info();
            U2.Show();
        }

        private void Show_Test_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Report SR = new Show_Report();
            SR.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Patient_Page_Load(object sender, EventArgs e)
        {
            Patient_Name.Text = First_Page.Name;
            Patient_ID.Text = First_Page.ID2;

            DateTime now = DateTime.Today;

            str2 = now.ToString("dd");

            

            if (First_Page.Date1 == "0")
            {
                //-------------Date Update for new patient-------------------
                string q = "Update Patient set Date='" + @str2 + "' ";
                SqlCommand updatecommand = new SqlCommand(q);

                updatecommand.Parameters.AddWithValue("@Date", @str2);
                

                objDBAccess.executeQuery(updatecommand);
 
            }
            else if (First_Page.Date1 != str2)
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

                string q = "Update Patient set Date='" + @str2 + "', Time='"+ str4 +"', D_Name='"+ str5 +"' ,Amount='"+ str4 +"' ";
                SqlCommand updatecommand1 = new SqlCommand(q);

                updatecommand1.Parameters.AddWithValue("@Date", @str2);
                updatecommand1.Parameters.AddWithValue("@Time", @str4);
                updatecommand1.Parameters.AddWithValue("@D_Name", @str5);
                updatecommand1.Parameters.AddWithValue("@Amount", @str4);


                objDBAccess.executeQuery(updatecommand1);

                MessageBox.Show("Server Busy \nPlease Re-Login");
                this.Close();
                First_Page FP = new First_Page();
                FP.Show();

                
 
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            First_Page f1 = new First_Page();
            f1.Show();
        }

        private void Patient_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Patient_Data DPD = new Delete_Patient_Data();
            DPD.Show();

            MessageBox.Show("Please Enter Your ID and Password Again");

        }

        private void Appointment_Time_Click(object sender, EventArgs e)
        {
            
            string q1 = "Select * from Patient where P_ID='" + First_Page.ID2 + "' ";

            objDBAccess.readDatathroughAdapter(q1, dtUsers);

            if (dtUsers.Rows.Count == 1)
            {
                D_Name = dtUsers.Rows[0]["D_Name"].ToString();
                Time = dtUsers.Rows[0]["Time"].ToString();

                objDBAccess.closeConn();
            }

            if (D_Name != "Nothing" && Time != "0")
            {
                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();
            }
            else
            {
                MessageBox.Show("You Have No Appointment");
            }

            

        }


       

       
    }
}
