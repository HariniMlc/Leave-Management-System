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
    public partial class scr_leave_hours : MetroFramework.Forms.MetroForm
    {
        public scr_leave_hours(string empid)
        {
            InitializeComponent();
            lbl_gender.Visible = false;
            lbl_joined_date.Visible = false;

            lbl_emp_id.Text = empid;
            get_gender();
            lbl_work_years.Text = get_work_years();
            get_total_leaves();
            get_available_leaves();
            if(lbl_gender.Text=="male")
            {
                lbl_mat.Text = "none";
                lbl_tot_mat.Text = "none";
            }
        }

        private void get_gender()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.gender
                            };

                foreach (var item in query)
                {
                    lbl_gender.Text = item.gender;
                }
            }
        }

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

        private void get_total_leaves()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                double years = Convert.ToDouble(lbl_work_years.Text);

                if(years <= 0.5)
                {
                    years = 0.5;
                }
                else if (years <= 1)
                {
                    years = 1;
                }
                else if (years <= 1.5)
                {
                    years = 1.5;
                }
                else if (years <= 2)
                {
                    years = 2;
                }
                else if (years <= 2.5)
                {
                    years = 2.5;
                }
                else if (years <= 3)
                {
                    years = 3;
                }
                else
                {
                    years = 5;
                }


                var query = from o in a.leave_types
                            where o.work_years == years
                            select new
                            {
                                o.half_day,
                                o.short_leave,
                                o.sick_leave,
                                o.maternity_leave,
                                o.study_leave
                            };
                foreach (var item in query)
                {
                    lbl_tot_halfday.Text = item.half_day.ToString();
                    lbl_tot_short.Text = item.short_leave.ToString();
                    lbl_tot_sick.Text = item.sick_leave.ToString();
                    lbl_tot_study.Text = item.study_leave.ToString();
                    lbl_tot_mat.Text = item.maternity_leave.ToString();
                }
            }
            
        }


        private void get_available_leaves()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.emp_leave_availability
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.halfday,
                                o.short_day,
                                o.sick_leave,
                                o.maternity_leave,
                                o.study_leave
                            };
                foreach (var item in query)
                {
                    lbl_halfday.Text = item.halfday.ToString();
                    lbl_short.Text = item.short_day.ToString();
                    lbl_sick.Text = item.sick_leave.ToString();
                    lbl_study.Text = item.study_leave.ToString();
                    lbl_mat.Text = item.maternity_leave.ToString();
                }

                DateTime date1 = DateTime.Parse(lbl_joined_date.Text);
                DateTime date2 = System.DateTime.Now.Date;

                TimeSpan difference = date1 - date2;
                int days = int.Parse(difference.ToString("dd"));
                double years = (double)days / 365;
                years = Math.Round(years, 1);
                lbl_work_years.Text = years.ToString();
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
