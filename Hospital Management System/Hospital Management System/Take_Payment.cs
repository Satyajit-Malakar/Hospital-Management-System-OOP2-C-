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
    public partial class Take_Payment : Form
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DataTable dtUsers2 = new DataTable();
        DataTable PtUsers = new DataTable();
        DataTable BtUsers = new DataTable();

        public static string id, N_Amount, T_Amount; 

        public Take_Payment()
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
                    N_Amount = dtUsers.Rows[0]["Amount"].ToString();

                    Need_Pay.Text = dtUsers.Rows[0]["Amount"].ToString();
                    Patient_N.Text = dtUsers.Rows[0]["P_Name"].ToString();

                    Am_Paid.Text = N_Amount;

                    objDBAccess.closeConn();

                }

                string q2 = "Select * from Bill where P_ID='" + P_ID + "' ";

                objDBAccess.readDatathroughAdapter(q2, BtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    T_Amount = BtUsers.Rows[0]["Amount"].ToString();

                    Paid.Text = BtUsers.Rows[0]["Amount"].ToString();

                    objDBAccess.closeConn();

                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist r2 = new Receptionist();
            r2.Show();
        }

        private void OK_Click(object sender, EventArgs e)
        {

            if (Am_Paid.Text == "")
            {
                MessageBox.Show("Please Enter Patient ID and Press Search Button");
            }

            //-------------------------------------Update Bill-------------------------------------

            else
            {
                int sum = Int32.Parse(T_Amount) + Int32.Parse(N_Amount);

                string q6 = "Update Bill set Amount='" + sum.ToString() + "' where P_ID='" + textP_ID.Text + "'";

                SqlCommand updatecommand6 = new SqlCommand(q6);

                objDBAccess.executeQuery(updatecommand6);

                string q7 = "Update Patient set Amount='" + "0" + "' where P_ID='" + textP_ID.Text + "'";

                SqlCommand updatecommand7 = new SqlCommand(q7);

                objDBAccess.executeQuery(updatecommand7);



                this.Close();
                Receptionist r3 = new Receptionist();
                r3.Show();
            }
            
        }
    }
}
