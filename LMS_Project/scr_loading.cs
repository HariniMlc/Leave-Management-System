using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project
{
    public partial class scr_loading : MetroFramework.Forms.MetroForm
    {
        int progress = 0;

        public scr_loading()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress > +100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
            }
            metroProgressBar1.Value = progress;
        }

        private void scr_loading_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
        }

    }
}
