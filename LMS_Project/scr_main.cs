using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LMS_Project
{
    public partial class scr_main : MetroFramework.Forms.MetroForm
    {
        public scr_main(string uname)
        {
            InitializeComponent();
            this.ActiveControl = lbl_1;
            lbl_1.Focus();


            date.Text = System.DateTime.Now.ToString("dd MMM yyyy");
            time.Text = System.DateTime.Now.ToString("hh:mm tt");

            lbl_test_uname.Text = uname;

            get_name();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void metroPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("http://www.smib.lk");  
        }



        #region ContentTableStyle
        private void metroTile4_MouseEnter(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.LightGray;
            metroTile4.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
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

        private void metroTile9_MouseEnter(object sender, EventArgs e)
        {
            metroTile9.BackColor = Color.LightGray;
            metroTile9.ForeColor = Color.FromArgb(7, 79, 155);
        }

        private void metroTile9_MouseLeave(object sender, EventArgs e)
        {
            metroTile9.BackColor = Color.FromArgb(7, 79, 155);
            metroTile9.ForeColor = Color.White;
        }

        #endregion

        #region ContentTableNavigate
        private void metroTile4_Click(object sender, EventArgs e)
        {
            //new scr_mynewleave(lbl_test_id.Text);
            pnl_mynewleave _pnl_mynewleave = new pnl_mynewleave(this, lbl_test_id.Text);
            _pnl_mynewleave.swipe(true);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //new scr_myhistory(lbl_test_id.Text).Show();
            pnl_leave_history _pnl_leave_history = new pnl_leave_history(this, lbl_test_id.Text);
            _pnl_leave_history.swipe(true);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            //new scr_leave_hours(lbl_test_id.Text).Show();
            pnl_leave_availability _pnl_leave_availability = new pnl_leave_availability(this, lbl_test_id.Text);
            _pnl_leave_availability.swipe(true);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            //new scr_calendar().Show();
            pnl_calendar _pnl_calendar = new pnl_calendar(this);
            _pnl_calendar.swipe(true);
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            //new scr_employee_details(lbl_test_id.Text).Show();
            pnl_employee_details _pnl_employee_details = new pnl_employee_details(this, lbl_test_id.Text, true);
            _pnl_employee_details.swipe(true);
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            //new scr_helpdoc1().Show();
            pnl_helpdoc _pnl_helpdoc = new pnl_helpdoc(this);
            _pnl_helpdoc.swipe(true);
        }
        #endregion

        #region MainTilesNavigate

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //new scr_mynewleave(lbl_test_id.Text).Show();
            pnl_mynewleave _pnl_mynewleave = new pnl_mynewleave(this, lbl_test_id.Text);
            _pnl_mynewleave.swipe(true);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //new scr_myhistory(lbl_test_id.Text).Show();
            pnl_leave_history _pnl_leave_history = new pnl_leave_history(this, lbl_test_id.Text);
            _pnl_leave_history.swipe(true);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //new scr_helpdoc1().Show();
            pnl_helpdoc _pnl_helpdoc = new pnl_helpdoc(this);
            _pnl_helpdoc.swipe(true);
        }

        #endregion

        #region MainTilesText
        
        int count = 0;
        int color = 0;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer3 = new System.Windows.Forms.Timer();

        #region Timer1
        private void SetTimer1(int milliseconds)
        {
            color = 255;
            count = 340;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = milliseconds;
            timer1.Start();
        }

        private void timer1_Tick(Object o, EventArgs e)
        {
            lbl_1.Visible = true;
            lbl1_1.Visible = true;
            if (count > 250)
            {
                this.lbl1_1.Location = new System.Drawing.Point(count, 300);
                this.lbl_1.Location = new System.Drawing.Point(count, 340);
                this.lbl1_1.ForeColor = Color.FromArgb(color, color, color);
                this.lbl_1.ForeColor = Color.FromArgb(color, color, color);
                color = color - 2;
                count--;
            }
            else
                timer1.Stop();
        }
        #endregion

        #region Timer2
        private void SetTimer2(int milliseconds)
        {
            color = 255;
            count = 490;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = milliseconds;
            timer2.Start();
        }

        private void timer2_Tick(Object o, EventArgs e)
        {
            lbl_2.Visible = true;
            lbl2_2.Visible = true;
            if (count > 400)
            {
                this.lbl2_2.Location = new System.Drawing.Point(count, 300);
                this.lbl_2.Location = new System.Drawing.Point(count, 340);
                this.lbl2_2.ForeColor = Color.FromArgb(color, color, color);
                this.lbl_2.ForeColor = Color.FromArgb(color, color, color);
                color = color - 2;
                count--;
            }
            else
                timer2.Stop();
        }
        #endregion

        #region Timer3
        private void SetTimer3(int milliseconds)
        {
            color = 255;
            count = 640;
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = milliseconds;
            timer3.Start();
        }

        private void timer3_Tick(Object o, EventArgs e)
        {
            lbl_3.Visible = true;
            lbl3_3.Visible = true;
            if (count > 550)
            {
                this.lbl3_3.Location = new System.Drawing.Point(count, 300);
                this.lbl_3.Location = new System.Drawing.Point(count, 340);
                this.lbl3_3.ForeColor = Color.FromArgb(color, color, color);
                this.lbl_3.ForeColor = Color.FromArgb(color, color, color);
                color = color - 2;
                count--;
            }
            else
                timer3.Stop();
        }
        #endregion

        private void metroTile1_MouseHover_1(object sender, EventArgs e)
        {
            this.lbl1_1.Location = new System.Drawing.Point(300, 345);
            this.lbl1_1.ForeColor = Color.FromArgb(255, 255, 255);
            SetTimer1(5);
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            lbl_1.Visible = false;
            lbl1_1.Visible = false;
        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {
            this.lbl2_2.Location = new System.Drawing.Point(300, 345);
            this.lbl2_2.ForeColor = Color.FromArgb(255, 255, 255);
            SetTimer2(5);
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            lbl_2.Visible = false;
            lbl2_2.Visible = false;
        }

        private void metroTile3_MouseHover(object sender, EventArgs e)
        {
            this.lbl3_3.Location = new System.Drawing.Point(300, 345);
            this.lbl3_3.ForeColor = Color.FromArgb(255, 255, 255);
            SetTimer3(5);
        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            lbl_3.Visible = false;
            lbl3_3.Visible = false;
        }

        #endregion

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            scr_login _scr_login = new scr_login();
            _scr_login.Show();
        }

    }
}
