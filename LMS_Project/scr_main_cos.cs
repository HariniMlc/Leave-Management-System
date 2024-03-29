﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project
{
    public partial class scr_main_cos : MetroFramework.Forms.MetroForm
    {
        public scr_main_cos(string uname)
        {
            InitializeComponent();
            lbl_1.Visible = false;
            lbl_2.Visible = false;
            lbl_test_id.Visible = false;
            lbl_test_uname.Visible = false;

            date.Text = System.DateTime.Now.ToString("dd MMM yyyy");
            time.Text = System.DateTime.Now.ToString("hh:mm tt");

            lbl_test_uname.Text = uname;

            get_name();
        }


        private void get_name()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.emp_log
                            where o.user_name == lbl_test_uname.Text
                            select new
                            {
                                o.emp_id
                            };

                foreach (var item in query)
                {
                    lbl_test_id.Text = item.emp_id;
                }

                var query2 = from oo in a.employees
                             where oo.emp_id == lbl_test_id.Text
                             select new
                             {
                                 oo.name
                             };

                foreach (var item in query2)
                {
                    lbl_name.Text = item.name;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile4_MouseHover(object sender, EventArgs e)
        {
            lbl_1.Visible = true;
        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            lbl_1.Visible = false;
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            lbl_2.Visible = true;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            lbl_2.Visible = false;
        }

        private void metroTile3_MouseHover(object sender, EventArgs e)
        {
            lbl_2.Visible = true;
        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            lbl_2.Visible = false;
        }

        private void scr_main_cos_Load(object sender, EventArgs e)
        {
            

        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //new scr_helpdoc1().Show();
            pnl_helpdoc _pnl_helpdoc = new pnl_helpdoc(this);
            _pnl_helpdoc.swipe(true);
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            //new scr_helpdoc1().Show();
            pnl_helpdoc _pnl_helpdoc = new pnl_helpdoc(this);
            _pnl_helpdoc.swipe(true);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            //new scr_employee_details(lbl_test_id.Text).Show();
            pnl_employee_details _pnl_employee_details = new pnl_employee_details(this, lbl_test_id.Text, true);
            _pnl_employee_details.swipe(true);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //new scr_all_employee_details("manager").Show();
            pnl_all_employee_details _pnl_all_employee_details = new pnl_all_employee_details(this, "manager");
            _pnl_all_employee_details.swipe(true);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //new scr_authorize(lbl_name.Text,"manager", lbl_test_id.Text).Show();
            pnl_authorize _pnl_authorize = new pnl_authorize(this, lbl_name.Text, "manager", lbl_test_id.Text);
            _pnl_authorize.swipe(true);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           // scr_
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_MouseHover_1(object sender, EventArgs e)
        {
            lbl_2.Visible = true;
        }

        private void metroTile1_MouseHover_1(object sender, EventArgs e)
        {
            lbl_1.Visible = true;
        }

        private void metroTile1_MouseLeave_1(object sender, EventArgs e)
        {
            lbl_1.Visible = false;
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            lbl_2.Visible = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //new scr_authorize(lbl_name.Text, "manager", lbl_test_id.Text).Show();
            pnl_authorize _pnl_authorize = new pnl_authorize(this, lbl_name.Text, "manager", lbl_test_id.Text);
            _pnl_authorize.swipe(true);
        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.smib.lk"); 
        }

        private void metroTile4_MouseEnter(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.LightGray;
            metroTile4.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile4_MouseLeave_1(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.FromArgb(7, 79, 155);
            metroTile4.ForeColor = Color.White;
        }

        private void metroTile5_MouseEnter(object sender, EventArgs e)
        {
            metroTile5.BackColor = Color.LightGray;
            metroTile5.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile5_MouseLeave(object sender, EventArgs e)
        {
            metroTile5.BackColor = Color.FromArgb(7, 79, 155);
            metroTile5.ForeColor = Color.White;
        }

        private void metroTile7_MouseEnter(object sender, EventArgs e)
        {
            metroTile7.BackColor = Color.LightGray;
            metroTile7.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile7_MouseLeave(object sender, EventArgs e)
        {
            metroTile7.BackColor = Color.FromArgb(7, 79, 155);
            metroTile7.ForeColor = Color.White;
        }

        private void metroTile8_MouseEnter(object sender, EventArgs e)
        {
            metroTile8.BackColor = Color.LightGray;
            metroTile8.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile8_MouseLeave(object sender, EventArgs e)
        {
            metroTile8.BackColor = Color.FromArgb(7, 79, 155);
            metroTile8.ForeColor = Color.White;
        }

        private void metroTile6_Click_1(object sender, EventArgs e)
        {
            pnl_report _pnl_report = new pnl_report(this, lbl_test_id.Text);
            _pnl_report.swipe(true);
        }

        private void metroTile6_MouseEnter(object sender, EventArgs e)
        {
            metroTile6.BackColor = Color.LightGray;
            metroTile6.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile6_MouseLeave(object sender, EventArgs e)
        {
            metroTile6.BackColor = Color.FromArgb(7, 79, 155);
            metroTile6.ForeColor = Color.White;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            scr_login _scr_login = new scr_login();
            _scr_login.Show();
        }

    }
}
