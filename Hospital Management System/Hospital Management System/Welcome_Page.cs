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
    public partial class Welcome_Page : Form
    {
        private int time;

        public Welcome_Page()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 20)
            {
                text1.Text = "Let's Begin....";
            }

            else if (time == 30)
            {
                this.Hide();
                First_Page f2 = new First_Page();
                f2.Show();
                timer1.Stop();
            }

        }

    }
}
