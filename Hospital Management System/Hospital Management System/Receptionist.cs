using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Receptionist : Form
    {
        public Receptionist()
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

        private void Receptionist_Load(object sender, EventArgs e)
        {
            textR_Name.Text = First_Page.Name_R;
            textR_ID.Text = First_Page.ID_R;
        }

        private void T_R_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Report SR = new Show_Report();
            SR.Show();
        }

        private void Take_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            Take_Payment TP = new Take_Payment();
            TP.Show();
        }

    }
}
