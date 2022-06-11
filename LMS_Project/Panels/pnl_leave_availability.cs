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
    public partial class pnl_leave_availability : pnl_slider
    {
        public pnl_leave_availability(Form owner, string empid) : base(owner)
        {
            InitializeComponent();

            lbl_emp_id.Text = empid;
            get_gender();
            lbl_work_years.Text = get_work_years();
            get_total_leaves();
            get_available_leaves();
            if (lbl_gender.Text == "male")
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

                if (years <= 0.5)
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
                                o.study_leave,
                                o.casual_leave
                            };
                foreach (var item in query)
                {
                    lbl_tot_casual.Text = item.casual_leave.ToString();
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
                var Exists = a.leaves1.Any(x => x.emp_id == lbl_emp_id.Text);

                if (Exists)
                {
                    var query = from o in a.emp_leave_availability
                                where o.emp_id == lbl_emp_id.Text
                                select new
                                {
                                    o.halfday,
                                    o.short_day,
                                    o.sick_leave,
                                    o.maternity_leave,
                                    o.study_leave,
                                    o.casual_leave
                                };
                    foreach (var item in query)
                    {
                        lbl_casual.Text = item.casual_leave.ToString();
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

                    create_chart();
                }
                else
                {
                    MessageBox.Show("No records available", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.swipe(false);
                }
                    
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void create_chart()
        {
            this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel2.Text, int.Parse(lbl_casual.Text));
            this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel6.Text, int.Parse(lbl_halfday.Text));
            this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel7.Text, int.Parse(lbl_short.Text));
            this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel3.Text, int.Parse(lbl_sick.Text));
            if (lbl_mat.Text == "none")
                this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel4.Text, 0);
            else
                this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel4.Text, int.Parse(lbl_mat.Text));
            this.chart1.Series["Taken Leaves"].Points.AddXY(metroLabel8.Text, int.Parse(lbl_study.Text));

            this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel2.Text, int.Parse(lbl_tot_casual.Text));
            this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel6.Text, int.Parse(lbl_tot_halfday.Text));
            this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel7.Text, int.Parse(lbl_tot_short.Text));
            this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel3.Text, int.Parse(lbl_tot_sick.Text));
            if (lbl_mat.Text == "none")
                this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel4.Text, 0);
            else
                this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel4.Text, int.Parse(lbl_tot_mat.Text));
            this.chart1.Series["Total Leaves"].Points.AddXY(metroLabel8.Text, int.Parse(lbl_tot_study.Text));
        }

    }
}
