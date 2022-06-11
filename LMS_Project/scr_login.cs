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
    public partial class scr_login : MetroFramework.Forms.MetroForm
    {
        public scr_login()
        {
            InitializeComponent();
            error_lbl.Hide();

            this.ActiveControl = uname_txt;
            uname_txt.Focus();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            validate_login();
        }

        private void validate_login()
        {
            try
            {
                using (leave_managementEntities t = new leave_managementEntities())
                {
                    var Exists = t.emp_log.Any(x => x.user_name == uname_txt.Text && x.password == password_txt.Text);

                if (Exists)
                {
                    var query = from o in t.emp_log
                                where o.user_name == uname_txt.Text && o.password == password_txt.Text
                                select o;

                    var query2 = from o in t.emp_log
                                 where o.user_name == uname_txt.Text && o.password == password_txt.Text
                                 select new
                                 {
                                     o.status
                                 };

                    foreach (var item in query)
                    {
                        lbl_1.Text = item.status;
                    }

                    //scr_loading _scr_loading = new scr_loading(lbl_1.Text);
                    scr_loading _scr_loading = new scr_loading();
                    _scr_loading.Show();

                }
                else
                    error_lbl.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void open_main_form()
        {
            if(lbl_1.Text != "employee post")
            {
                if (lbl_1.Text == "employee")
                    new scr_main(uname_txt.Text).Show();
                else if (lbl_1.Text == "manager")
                    new scr_main_manager(uname_txt.Text).Show();
                else if (lbl_1.Text == "CEO")
                    new scr_main_cos(uname_txt.Text).Show();

                this.Hide();
            }   
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            new scr_signin(uname_txt.Text).Show();
        }

        private void scr_login_Load(object sender, EventArgs e)
        {
            pnl_start _pnl_start = new pnl_start(this);
            _pnl_start.swipe(true);
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validate_login();
        }

        private void uname_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validate_login();
        }

        private void scr_login_Activated(object sender, EventArgs e)
        {
            open_main_form();
        }
    }
}
