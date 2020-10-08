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
    public partial class Appoint : Form
    {
        public static int s=0;
        public static string DOC_Name, Amount=null,Amount1;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DataTable dtUsers1 = new DataTable();
        DataTable dtUsers2 = new DataTable();

        public Appoint()
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Doctor_Info d2 = new Show_Doctor_Info();
            d2.Show();
        }

        private void Appoint_Load(object sender, EventArgs e)
        {
            if (Show_Doctor_Info.a1 == 1)
            {
                string q = "Select * from Appointment where A_ID='" + 1 + "' and D_ID='" + "1-11" + "'";

                objDBAccess.readDatathroughAdapter(q, dtUsers);


                if (dtUsers.Rows.Count == 1)
                {
                    
                    T1.Text = dtUsers.Rows[0]["A_Time1"].ToString();
                    T2.Text = dtUsers.Rows[0]["A_Time2"].ToString();
                    T3.Text = dtUsers.Rows[0]["A_Time3"].ToString();
                    T4.Text = dtUsers.Rows[0]["A_Time4"].ToString();
                    T5.Text = dtUsers.Rows[0]["A_Time5"].ToString();
                    T6.Text = dtUsers.Rows[0]["A_Time6"].ToString();
                    T7.Text = dtUsers.Rows[0]["A_Time7"].ToString();
                    T8.Text = dtUsers.Rows[0]["A_Time8"].ToString();

                    string s1,s2,s3,s4,s5,s6,s7,s8;
                    s1 = dtUsers.Rows[0]["Appoint1"].ToString();
                    s2 = dtUsers.Rows[0]["Appoint2"].ToString();
                    s3 = dtUsers.Rows[0]["Appoint3"].ToString();
                    s4 = dtUsers.Rows[0]["Appoint4"].ToString();
                    s5 = dtUsers.Rows[0]["Appoint5"].ToString();
                    s6 = dtUsers.Rows[0]["Appoint6"].ToString();
                    s7 = dtUsers.Rows[0]["Appoint7"].ToString();
                    s8 = dtUsers.Rows[0]["Appoint8"].ToString();

                    L1.Text = dtUsers.Rows[0]["Appoint1"].ToString();
                    L2.Text = dtUsers.Rows[0]["Appoint2"].ToString();
                    L3.Text = dtUsers.Rows[0]["Appoint3"].ToString();
                    L4.Text = dtUsers.Rows[0]["Appoint4"].ToString();
                    L5.Text = dtUsers.Rows[0]["Appoint5"].ToString();
                    L6.Text = dtUsers.Rows[0]["Appoint6"].ToString();
                    L7.Text = dtUsers.Rows[0]["Appoint7"].ToString();
                    L8.Text = dtUsers.Rows[0]["Appoint8"].ToString();

                    if (Show_Doctor_Info.a1 == 1 && s1 == "Appointed")
                    {
                        Ok1.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s2 == "Appointed")
                    {
                        Ok2.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s3 == "Appointed")
                    {
                        Ok3.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s4 == "Appointed")
                    {
                        Ok4.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s5 == "Appointed")
                    {
                        Ok5.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s6 == "Appointed")
                    {
                        Ok6.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s7 == "Appointed")
                    {
                        Ok7.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 1 && s8 == "Appointed")
                    {
                        Ok8.Enabled = false;
                    }

                    
                    objDBAccess.closeConn();



                }
            }


            else if (Show_Doctor_Info.a1 == 2)
            {
                string q = "Select * from Appointment where A_ID='" + 2 + "' and D_ID='" + "1-12" + "'";

                objDBAccess.readDatathroughAdapter(q, dtUsers);


                if (dtUsers.Rows.Count == 1)
                {
                    T1.Text = dtUsers.Rows[0]["A_Time1"].ToString();
                    T2.Text = dtUsers.Rows[0]["A_Time2"].ToString();
                    T3.Text = dtUsers.Rows[0]["A_Time3"].ToString();
                    T4.Text = dtUsers.Rows[0]["A_Time4"].ToString();
                    T5.Text = dtUsers.Rows[0]["A_Time5"].ToString();
                    T6.Text = dtUsers.Rows[0]["A_Time6"].ToString();
                    T7.Text = dtUsers.Rows[0]["A_Time7"].ToString();
                    T8.Text = dtUsers.Rows[0]["A_Time8"].ToString();

                    string s1, s2, s3, s4, s5, s6, s7, s8;
                    s1 = dtUsers.Rows[0]["Appoint1"].ToString();
                    s2 = dtUsers.Rows[0]["Appoint2"].ToString();
                    s3 = dtUsers.Rows[0]["Appoint3"].ToString();
                    s4 = dtUsers.Rows[0]["Appoint4"].ToString();
                    s5 = dtUsers.Rows[0]["Appoint5"].ToString();
                    s6 = dtUsers.Rows[0]["Appoint6"].ToString();
                    s7 = dtUsers.Rows[0]["Appoint7"].ToString();
                    s8 = dtUsers.Rows[0]["Appoint8"].ToString();

                    L1.Text = dtUsers.Rows[0]["Appoint1"].ToString();
                    L2.Text = dtUsers.Rows[0]["Appoint2"].ToString();
                    L3.Text = dtUsers.Rows[0]["Appoint3"].ToString();
                    L4.Text = dtUsers.Rows[0]["Appoint4"].ToString();
                    L5.Text = dtUsers.Rows[0]["Appoint5"].ToString();
                    L6.Text = dtUsers.Rows[0]["Appoint6"].ToString();
                    L7.Text = dtUsers.Rows[0]["Appoint7"].ToString();
                    L8.Text = dtUsers.Rows[0]["Appoint8"].ToString();

                    if (Show_Doctor_Info.a1 == 2 && s1 == "Appointed")
                    {
                        Ok1.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s2 == "Appointed")
                    {
                        Ok2.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s3 == "Appointed")
                    {
                        Ok3.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s4 == "Appointed")
                    {
                        Ok4.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s5 == "Appointed")
                    {
                        Ok5.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s6 == "Appointed")
                    {
                        Ok6.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s7 == "Appointed")
                    {
                        Ok7.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 2 && s8 == "Appointed")
                    {
                        Ok8.Enabled = false;
                    }

                    objDBAccess.closeConn();



                }
            }

            else if (Show_Doctor_Info.a1 == 3)
            {
                string q = "Select * from Appointment where A_ID='" + 3 + "' and D_ID='" + "1-13" + "'";

                objDBAccess.readDatathroughAdapter(q, dtUsers);


                if (dtUsers.Rows.Count == 1)
                {
                    T1.Text = dtUsers.Rows[0]["A_Time1"].ToString();
                    T2.Text = dtUsers.Rows[0]["A_Time2"].ToString();
                    T3.Text = dtUsers.Rows[0]["A_Time3"].ToString();
                    T4.Text = dtUsers.Rows[0]["A_Time4"].ToString();
                    T5.Text = dtUsers.Rows[0]["A_Time5"].ToString();
                    T6.Text = dtUsers.Rows[0]["A_Time6"].ToString();
                    T7.Text = dtUsers.Rows[0]["A_Time7"].ToString();
                    T8.Text = dtUsers.Rows[0]["A_Time8"].ToString();

                    string s1, s2, s3, s4, s5, s6, s7, s8;
                    s1 = dtUsers.Rows[0]["Appoint1"].ToString();
                    s2 = dtUsers.Rows[0]["Appoint2"].ToString();
                    s3 = dtUsers.Rows[0]["Appoint3"].ToString();
                    s4 = dtUsers.Rows[0]["Appoint4"].ToString();
                    s5 = dtUsers.Rows[0]["Appoint5"].ToString();
                    s6 = dtUsers.Rows[0]["Appoint6"].ToString();
                    s7 = dtUsers.Rows[0]["Appoint7"].ToString();
                    s8 = dtUsers.Rows[0]["Appoint8"].ToString();

                    L1.Text = dtUsers.Rows[0]["Appoint1"].ToString();
                    L2.Text = dtUsers.Rows[0]["Appoint2"].ToString();
                    L3.Text = dtUsers.Rows[0]["Appoint3"].ToString();
                    L4.Text = dtUsers.Rows[0]["Appoint4"].ToString();
                    L5.Text = dtUsers.Rows[0]["Appoint5"].ToString();
                    L6.Text = dtUsers.Rows[0]["Appoint6"].ToString();
                    L7.Text = dtUsers.Rows[0]["Appoint7"].ToString();
                    L8.Text = dtUsers.Rows[0]["Appoint8"].ToString();

                    if (Show_Doctor_Info.a1 == 3 && s1 == "Appointed")
                    {
                        Ok1.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s2 == "Appointed")
                    {
                        Ok2.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s3 == "Appointed")
                    {
                        Ok3.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s4 == "Appointed")
                    {
                        Ok4.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s5 == "Appointed")
                    {
                        Ok5.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s6 == "Appointed")
                    {
                        Ok6.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s7 == "Appointed")
                    {
                        Ok7.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 3 && s8 == "Appointed")
                    {
                        Ok8.Enabled = false;
                    }

                    objDBAccess.closeConn();



                }
            }

            else if (Show_Doctor_Info.a1 == 4)
            {
                string q = "Select * from Appointment where A_ID='" + 4 + "' and D_ID='" + "1-14" + "'";

                objDBAccess.readDatathroughAdapter(q, dtUsers);


                if (dtUsers.Rows.Count == 1)
                {
                    T1.Text = dtUsers.Rows[0]["A_Time1"].ToString();
                    T2.Text = dtUsers.Rows[0]["A_Time2"].ToString();
                    T3.Text = dtUsers.Rows[0]["A_Time3"].ToString();
                    T4.Text = dtUsers.Rows[0]["A_Time4"].ToString();
                    T5.Text = dtUsers.Rows[0]["A_Time5"].ToString();
                    T6.Text = dtUsers.Rows[0]["A_Time6"].ToString();
                    T7.Text = dtUsers.Rows[0]["A_Time7"].ToString();
                    T8.Text = dtUsers.Rows[0]["A_Time8"].ToString();

                    string s1, s2, s3, s4, s5, s6, s7, s8;
                    s1 = dtUsers.Rows[0]["Appoint1"].ToString();
                    s2 = dtUsers.Rows[0]["Appoint2"].ToString();
                    s3 = dtUsers.Rows[0]["Appoint3"].ToString();
                    s4 = dtUsers.Rows[0]["Appoint4"].ToString();
                    s5 = dtUsers.Rows[0]["Appoint5"].ToString();
                    s6 = dtUsers.Rows[0]["Appoint6"].ToString();
                    s7 = dtUsers.Rows[0]["Appoint7"].ToString();
                    s8 = dtUsers.Rows[0]["Appoint8"].ToString();

                    L1.Text = dtUsers.Rows[0]["Appoint1"].ToString();
                    L2.Text = dtUsers.Rows[0]["Appoint2"].ToString();
                    L3.Text = dtUsers.Rows[0]["Appoint3"].ToString();
                    L4.Text = dtUsers.Rows[0]["Appoint4"].ToString();
                    L5.Text = dtUsers.Rows[0]["Appoint5"].ToString();
                    L6.Text = dtUsers.Rows[0]["Appoint6"].ToString();
                    L7.Text = dtUsers.Rows[0]["Appoint7"].ToString();
                    L8.Text = dtUsers.Rows[0]["Appoint8"].ToString();

                    if (Show_Doctor_Info.a1 == 4 && s1 == "Appointed")
                    {
                        Ok1.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s2 == "Appointed")
                    {
                        Ok2.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s3 == "Appointed")
                    {
                        Ok3.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s4 == "Appointed")
                    {
                        Ok4.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s5 == "Appointed")
                    {
                        Ok5.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s6 == "Appointed")
                    {
                        Ok6.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s7 == "Appointed")
                    {
                        Ok7.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 4 && s8 == "Appointed")
                    {
                        Ok8.Enabled = false;
                    }

                    objDBAccess.closeConn();



                }
            }


            else if (Show_Doctor_Info.a1 == 5)
            {
                string q = "Select * from Appointment where A_ID='" + 5 + "' and D_ID='" + "1-15" + "'";

                objDBAccess.readDatathroughAdapter(q, dtUsers);


                if (dtUsers.Rows.Count == 1)
                {
                    T1.Text = dtUsers.Rows[0]["A_Time1"].ToString();
                    T2.Text = dtUsers.Rows[0]["A_Time2"].ToString();
                    T3.Text = dtUsers.Rows[0]["A_Time3"].ToString();
                    T4.Text = dtUsers.Rows[0]["A_Time4"].ToString();
                    T5.Text = dtUsers.Rows[0]["A_Time5"].ToString();
                    T6.Text = dtUsers.Rows[0]["A_Time6"].ToString();
                    T7.Text = dtUsers.Rows[0]["A_Time7"].ToString();
                    T8.Text = dtUsers.Rows[0]["A_Time8"].ToString();

                    string s1, s2, s3, s4, s5, s6, s7, s8;
                    s1 = dtUsers.Rows[0]["Appoint1"].ToString();
                    s2 = dtUsers.Rows[0]["Appoint2"].ToString();
                    s3 = dtUsers.Rows[0]["Appoint3"].ToString();
                    s4 = dtUsers.Rows[0]["Appoint4"].ToString();
                    s5 = dtUsers.Rows[0]["Appoint5"].ToString();
                    s6 = dtUsers.Rows[0]["Appoint6"].ToString();
                    s7 = dtUsers.Rows[0]["Appoint7"].ToString();
                    s8 = dtUsers.Rows[0]["Appoint8"].ToString();

                    L1.Text = dtUsers.Rows[0]["Appoint1"].ToString();
                    L2.Text = dtUsers.Rows[0]["Appoint2"].ToString();
                    L3.Text = dtUsers.Rows[0]["Appoint3"].ToString();
                    L4.Text = dtUsers.Rows[0]["Appoint4"].ToString();
                    L5.Text = dtUsers.Rows[0]["Appoint5"].ToString();
                    L6.Text = dtUsers.Rows[0]["Appoint6"].ToString();
                    L7.Text = dtUsers.Rows[0]["Appoint7"].ToString();
                    L8.Text = dtUsers.Rows[0]["Appoint8"].ToString();

                    if (Show_Doctor_Info.a1 == 5 && s1 == "Appointed")
                    {
                        Ok1.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s2 == "Appointed")
                    {
                        Ok2.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s3 == "Appointed")
                    {
                        Ok3.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s4 == "Appointed")
                    {
                        Ok4.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s5 == "Appointed")
                    {
                        Ok5.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s6 == "Appointed")
                    {
                        Ok6.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s7 == "Appointed")
                    {
                        Ok7.Enabled = false;
                    }

                    if (Show_Doctor_Info.a1 == 5 && s8 == "Appointed")
                    {
                        Ok8.Enabled = false;
                    }

                    objDBAccess.closeConn();

                }
            }

            else
            {
                MessageBox.Show("Error");
            }


        }


        private void Ok1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                string str3 = "Appointed";
                L1.Text = str3;

                //-----------------------------------Update Appointment---------------------------------------

                string q2 = "Update Appointment set Appoint1='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint1", @str3);

                objDBAccess.executeQuery(updatecommand);

                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                 objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);

           
                 if (dtUsers1.Rows.Count == 1)
                 {
                     DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                     Amount = dtUsers1.Rows[0]["Payment"].ToString();

                     objDBAccess.closeConn();
                 }

                //--------------------------------------Update Patient Time & D_Name------------------------------------
                 string q3 = "Update Patient set Time='" + T1.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                ////-------------------------------------Update Bill-------------------------------------

                //string q5 = "Select * from Bill where P_ID='" + First_Page.ID2 + "' ";

                //objDBAccess.readDatathroughAdapter(q5, dtUsers2);

                //if (dtUsers2.Rows.Count == 1)
                //{
                //    Amount1 = dtUsers2.Rows[0]["Amount"].ToString();

                //    objDBAccess.closeConn();

                //}

                //int sum = Int32.Parse(Amount) + Int32.Parse(Amount1);


                //string q6 = "Update Bill set Amount='"+ sum.ToString() +"' where P_ID='" + First_Page.ID2 + "'";

                //SqlCommand updatecommand6 = new SqlCommand(q6);

                //objDBAccess.executeQuery(updatecommand6);

                
                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }

        private void Ok2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L2.Text = str3;

                string q2 = "Update Appointment set Appoint2='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint2", @str3);

                objDBAccess.executeQuery(updatecommand);

                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T2.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);


                
                

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();



            }
            
        }

        private void Ok3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L3.Text = str3;

                string q2 = "Update Appointment set Appoint3='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint3", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();
                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T3.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }

        private void Ok4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L4.Text = str3;

                string q2 = "Update Appointment set Appoint4='" + @str3 + "'where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint4", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T4.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }

        private void Ok5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L5.Text = str3;

                string q2 = "Update Appointment set Appoint5='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint1", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }



                string q3 = "Update Patient set Time='" + T5.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
           
        }

        private void Ok6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L6.Text = str3;

                string q2 = "Update Appointment set Appoint6='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint6", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T6.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }

        private void Ok7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L7.Text = str3;

                string q2 = "Update Appointment set Appoint7='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint7", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T7.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }

        private void Ok8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Take This Time ?", "Time", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string str3 = "Appointed";
                L8.Text = str3;

                string q2 = "Update Appointment set Appoint8='" + @str3 + "' where D_ID='" + Show_Doctor_Info.D_ID + "'";

                SqlCommand updatecommand = new SqlCommand(q2);

                updatecommand.Parameters.AddWithValue("@Appoint8", @str3);

                objDBAccess.executeQuery(updatecommand);


                //-----------------------------------Get Doctor Name-------------------------------------------

                string get_D_Name = "Select * from Doctor where D_ID='" + Show_Doctor_Info.D_ID + "'";

                objDBAccess.readDatathroughAdapter(get_D_Name, dtUsers1);


                if (dtUsers1.Rows.Count == 1)
                {
                    DOC_Name = dtUsers1.Rows[0]["D_Name"].ToString();

                    Amount = dtUsers1.Rows[0]["Payment"].ToString();

                    objDBAccess.closeConn();
                }

                string q3 = "Update Patient set Time='" + T8.Text + "', D_Name='" + DOC_Name + "', Amount='" + Amount + "' where P_ID='" + First_Page.ID2 + "'";

                SqlCommand updatecommand2 = new SqlCommand(q3);

                objDBAccess.executeQuery(updatecommand2);

                this.Hide();
                Appoint_Time AT = new Appoint_Time();
                AT.Show();

            }
            
        }



    }
}
