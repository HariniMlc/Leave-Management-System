using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace LMS_Project
{
    public partial class scr_signin : MetroFramework.Forms.MetroForm
    {
        public scr_signin(string uname)
        {
            InitializeComponent();
           // error.Hide();
            
            emp_id_combo.Visible = false;
            //populate_combo();
            metroPanel2.Visible = false;
            metroButton1.Enabled = false;
            error.AutoSize = true;
        }

        //private void populate_combo()
        //{
        //    using (leave_managementEntities a = new leave_managementEntities())
        //    {
        //        var query = from o in a.employees
        //                    select o.emp_id;

        //        emp_id_combo.DataSource = query.ToList();
        //    }
        //}

        #region fetch

        #region hidden data
        private string get_work_years()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.joined_date
                            };
                foreach (var item in query)
                {
                    lbl_joined_date.Text = item.joined_date.ToString("MM/dd/yyyy");
                }

                DateTime date1 = DateTime.Parse(lbl_joined_date.Text);
                DateTime date2 = System.DateTime.Now.Date;

                TimeSpan difference = date1 - date2;
                int days = int.Parse(difference.ToString("dd"));
                double years = (double)days / 365;
                years = Math.Round(years, 1);
                return (years.ToString());
            }
        }

        private void get_leave_id()
        {
            var context = new leave_managementEntities();
            var showPiece = context.emp_log
                .FirstOrDefault(p => p.log_id == context.emp_log.Max(x => x.log_id));

            lbl_log_id.Text = (int.Parse(showPiece.log_id) + 1).ToString();
        }
        #endregion
 
        private bool get_details()
        {
            lbl_emp_id.Text = txt_empid.Text;

            using (leave_managementEntities a = new leave_managementEntities())
            {
                var Exists = a.employees.Any(x => x.emp_id == lbl_emp_id.Text);

                if (Exists)
                {
                    var query = from o in a.employees
                                where o.emp_id == lbl_emp_id.Text
                                select new
                                {
                                    o.name,
                                    o.department,
                                    o.post
                                };

                    foreach (var item in query)
                    {
                        txt_name.Text = item.name;
                        txt_department.Text = item.department;
                        txt_post.Text = item.post;
                    }
                    return true;
                }
                else
                    return false;             
            }
        }

        

        //private void get_status()
        //{
        //    var context = new leave_managementEntities();

        //    var query = from o in context.employees
        //                where o.emp_id == emp_id_combo.SelectedText
        //                select new
        //                {
        //                    o.post
        //                };

        //    foreach (var item in query)
        //    {
        //        txt_post.Text = item.post;
        //    }
        //}

        #endregion

        #region button click
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Insert();
            add_leave_availability_record();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (txt_empid.Text != "")
            {

                if(get_details() == true)
                {
                    get_leave_id();
                    //get_status();
                    lbl_work_years.Text = get_work_years();
                    validate_user();
                }
                else
                {
                    MessageBox.Show("The Employee Id doesn't exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_empid.Text = "";
                }
                    
            }
            else
            {
                MessageBox.Show("Enter your Employee ID","Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
        #endregion

        #region save new user
        private void add_leave_availability_record()
        {
            try
            {
                var context = new leave_managementEntities();

                var t = new emp_leave_availability
                {
                    emp_id = lbl_emp_id.Text,
                    halfday = 0,
                    short_day = 0,
                    sick_leave = 0,
                    maternity_leave = 0,
                    study_leave = 0,
                    work_years = Convert.ToDouble(lbl_work_years.Text)
                };

                context.emp_leave_availability.Add(t);
                context.SaveChanges();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Insert()
        {
            try
            {
                var context = new leave_managementEntities();

                var t = new emp_log
                {
                    log_id = lbl_log_id.Text,
                    emp_id = lbl_emp_id.Text,
                    user_name = txt_uname.Text,
                    password = txt_password.Text,
                    status = txt_post.Text
                };

                context.emp_log.Add(t);
                context.SaveChanges();


                MessageBox.Show("Successfully signed in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
               
        }

        #endregion

        #region validation
        private void validate_user()
        {
            var context = new leave_managementEntities();

            var query = from o in context.emp_log
                        where o.emp_id == lbl_emp_id.Text
                        select o;

            if (query.SingleOrDefault() != null)
            {
                MessageBox.Show("This user has an account!", "User exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear();

            }
            else
                metroPanel2.Visible = true;
        }

        #endregion

        private void clear()
        {
            lbl_log_id.Text = "";
            lbl_emp_id.Text = "";
            txt_uname.Text = "";
            txt_password.Text = "";
            txt_confirmpass.Text = "";
            txt_post.Text = "";
            txt_department.Text = "";
            txt_post.Text = "";
            txt_name.Text = "";
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var Exists = a.emp_log.Any(x => x.user_name == txt_uname.Text);

                if (Exists)
                {
                    error.Text = "The user name already exists";
                    error.Visible = true;
                    metroButton1.Enabled = false;
                    txt_password.Enabled = false;
                    txt_confirmpass.Enabled = false;
                }  
                else
                {
                    error.Text = "";
                    txt_password.Enabled = true;
                    txt_confirmpass.Enabled = true;
                    if (txt_confirmpass.Text != "" || txt_password.Text != "")
                    {
                        metroButton1.Enabled = true;
                    }
                }
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
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

        private void txt_confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_confirmpass.Text)
                error.Text = "The passwords doesn't match";
            else
            {
                error.Text = "";
                metroButton1.Enabled = true;
            }
                
        }
    }
}
