using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project
{
    public partial class pnl_helpdoc : pnl_slider
    {
        public pnl_helpdoc(Form owner) : base(owner)
        {
            InitializeComponent();
            help_1.Visible = false;
            help_2.Visible = false;
            help_3.Visible = false;
            help_4.Visible = false;
            help_5.Visible = false;
            help_6.Visible = false;
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.smib.lk");
        }

        private void metroLabel12_MouseHover(object sender, EventArgs e)
        {
            metroLabel12.ForeColor = Color.Blue;
        }

        private void metroLabel12_MouseLeave(object sender, EventArgs e)
        {
            metroLabel12.ForeColor = Color.Black;
        }

        private void metroLabel5_MouseHover(object sender, EventArgs e)
        {
            metroLabel5.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel6_MouseHover(object sender, EventArgs e)
        {
            metroLabel6.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel3_MouseHover(object sender, EventArgs e)
        {
            metroLabel3.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel2_MouseHover(object sender, EventArgs e)
        {
            metroLabel2.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel7_MouseHover(object sender, EventArgs e)
        {
            metroLabel7.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel4_MouseHover(object sender, EventArgs e)
        {
            metroLabel4.ForeColor = Color.DeepSkyBlue;
        }

        private void metroLabel5_MouseLeave(object sender, EventArgs e)
        {
            metroLabel5.ForeColor = Color.White;
        }

        private void metroLabel6_MouseLeave(object sender, EventArgs e)
        {
            metroLabel6.ForeColor = Color.White;
        }

        private void metroLabel3_MouseLeave(object sender, EventArgs e)
        {
            metroLabel3.ForeColor = Color.White;
        }

        private void metroLabel2_MouseLeave(object sender, EventArgs e)
        {
            metroLabel2.ForeColor = Color.White;
        }

        private void metroLabel7_MouseLeave(object sender, EventArgs e)
        {
            metroLabel7.ForeColor = Color.White;
        }

        private void metroLabel4_MouseLeave(object sender, EventArgs e)
        {
            metroLabel4.ForeColor = Color.White;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            help_1.Visible = true;
            help_1.BringToFront();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            help_2.Visible = true;
            help_2.BringToFront();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            help_3.Visible = true;
            help_3.BringToFront();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            help_4.Visible = true;
            help_4.BringToFront();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            help_5.Visible = true;
            help_5.BringToFront();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            help_6.Visible = true;
            help_6.BringToFront();
        }
    }
}
