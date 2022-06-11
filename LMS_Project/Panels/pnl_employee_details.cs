using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LMS_Project
{
    public partial class pnl_employee_details : pnl_slider
    {
        public pnl_employee_details(Form owner, string empid, bool a)  : base(owner)
        {
            InitializeComponent();
            edit_log_det_panel.Visible = false;
            lbl_emp_id.Text = empid;
            metroButton2.Enabled = false;

            if(a == false)
            {
                edit_log_det_panel.Visible = false;
                log_det_panel.Visible = false;
                metroLabel14.Visible = false;
            }

            load_details();
        }

        private void load_details()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.name,
                                o.tel_no,
                                o.email,
                                o.department,
                                o.post,
                                o.manager,
                                o.gender
                            };

                foreach (var item in query)
                {
                    lbl_name.Text = item.name;
                    lbl_dep.Text = item.department;
                    lbl_post.Text = item.post;
                    lbl_mob_no.Text = item.tel_no;
                    lbl_email.Text = item.email;
                    lbl_mngr.Text = item.manager;
                    lbl_gender.Text = item.gender;
                }

                var query2 = from oo in a.emp_log
                             where oo.emp_id == lbl_emp_id.Text
                             select new
                             {
                                 oo.user_name,
                                 oo.password
                             };

                foreach (var item in query2)
                {
                    lbl_user_name.Text = item.user_name;
                    txt_uname.Text = item.user_name;
                    lbl_password.Text = item.password;
                }


            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            edit_log_det_panel.Visible = true;
            log_det_panel.Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            edit_log_det_panel.Visible = false;
            log_det_panel.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (lbl_password.Text == old_password.Text)
            {
                if (txt_password.Text == txt_confirm.Text)
                {
                    save_data();
                }
                else
                    MessageBox.Show("Passwords doesn't match", "error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("The old password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void save_data()
        {
            using (leave_managementEntities context = new leave_managementEntities())
            {
                try
                {
                    var a = context.emp_log.Find(lbl_emp_id.Text);

                    a.user_name = txt_uname.Text;
                    a.password = txt_password.Text;

                    context.SaveChanges();

                    MessageBox.Show("The new password is set", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            var input = txt_password.Text;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasNumber.IsMatch(input))
                error.Text = "Password should contain At least one Digit";
            else if (!hasUpperChar.IsMatch(input))
                error.Text = "Password should contain At least one upper case letter";
            else if (!hasSymbols.IsMatch(input))
                error.Text = "Password should contain At least one special character";
            else if (!hasLowerChar.IsMatch(input))
                error.Text = "Password should contain At least one lower case letter";
            else if (!hasMiniMaxChars.IsMatch(input))
                error.Text = "Password should be 8 - 15 characters long";
            else
                error.Text = "";    
        }

        private void txt_confirm_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_confirm.Text)
                error.Text = "The passwords doesn't match";
            else
            {
                error.Text = "";
                metroButton2.Enabled = true;
            }
        }
    }
}
