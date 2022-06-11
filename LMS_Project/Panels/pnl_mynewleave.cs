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
    public partial class pnl_mynewleave : pnl_slider
    {
        string type;
        int days = 0;

        public pnl_mynewleave(Form owner, string employee_id) : base(owner)
        {
            InitializeComponent();
            leave_id_lbl.Visible = true;
            emp_id_txt.Text = employee_id;
            work_years_lbl.Text = get_work_years();
            load_values();
            end_date.MinDate = DateTime.Now.Date;
            start_date.MinDate = DateTime.Now.Date;
            metroButton2.Enabled = false;
            leve_type_combo.SelectedIndex = 0;
            duration_lbl.Text = calculate_duration() + " days";
        }

        private string get_work_years()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == emp_id_txt.Text
                            select new
                            {
                                o.joined_date
                            };
                foreach (var item in query)
                {
                    lbl_joined_date.Text = item.joined_date.ToString("MM dd yyyy");
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

        private void load_values()
        {
            try
            {
                var context = new leave_managementEntities();

                var showPiece = context.leaves1
                .FirstOrDefault(p => p.leave_id == context.leaves1.Max(x => x.leave_id));

                leave_id_lbl.Text = (int.Parse(showPiece.leave_id) + 1).ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void metroPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            leve_type_combo.SelectedIndex = 0;
            reason_txt.Text = "";
            start_date.Text = "";
            end_date.Text = "";
            duration_lbl.Text = "0";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to send the request?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                duration_lbl.Text = calculate_duration() + " days";
                days = calculate_duration();
                //update_no_of_leaves();
                save_leave();
            }
        }

        //private void update_no_of_leaves()
        //{

        //    if (leve_type_combo.SelectedItem.ToString() == "Half Day")
        //    {
        //        using (leave_managementEntities context = new leave_managementEntities())
        //        {
        //            var a = context.emp_leave_availability.Find(emp_id_txt.Text);
        //            a.halfday = Convert.ToInt32(a.halfday + days);
        //            a.work_years = Convert.ToDouble(work_years_lbl.Text);
        //            context.SaveChanges();
        //        }
        //    }
        //    else if (leve_type_combo.SelectedItem.ToString() == "Short Leave")
        //    {
        //        using (leave_managementEntities context = new leave_managementEntities())
        //        {
        //            var a = context.emp_leave_availability.Find(emp_id_txt.Text);
        //            a.work_years = Convert.ToDouble(work_years_lbl.Text);
        //            a.short_day = Convert.ToInt32(a.short_day + days);
        //            context.SaveChanges();
        //        }
        //    }
        //    else if (leve_type_combo.SelectedItem.ToString() == "Maternity Leave")
        //    {
        //        using (leave_managementEntities context = new leave_managementEntities())
        //        {
        //            var a = context.emp_leave_availability.Find(emp_id_txt.Text);
        //            a.work_years = Convert.ToDouble(work_years_lbl.Text);
        //            a.maternity_leave = Convert.ToInt32(a.maternity_leave + days);
        //            context.SaveChanges();
        //        }
        //    }
        //    else if (leve_type_combo.SelectedItem.ToString() == "Study Leave")
        //    {
        //        using (leave_managementEntities context = new leave_managementEntities())
        //        {
        //            var a = context.emp_leave_availability.Find(emp_id_txt.Text);
        //            a.work_years = Convert.ToDouble(work_years_lbl.Text);
        //            a.study_leave = Convert.ToInt32(a.study_leave + days);
        //            context.SaveChanges();
        //        }
        //    }
        //    else if (leve_type_combo.SelectedItem.ToString() == "Sick Leave")
        //    {
        //        using (leave_managementEntities context = new leave_managementEntities())
        //        {
        //            var a = context.emp_leave_availability.Find(emp_id_txt.Text);
        //            a.work_years = Convert.ToDouble(work_years_lbl.Text);
        //            a.sick_leave = Convert.ToInt32(a.sick_leave + days);
        //            context.SaveChanges();
        //        }
        //    }
        //}

        private void save_leave()
        {
            if (leve_type_combo.SelectedItem.ToString() == "Casual Leave")
                type = "Casual Leave";
            else if (leve_type_combo.SelectedItem.ToString() == "Half Day")
                type = "Half Day";
            else if (leve_type_combo.SelectedItem.ToString() == "Short Leave")
                type = "Short Leave";
            else if (leve_type_combo.SelectedItem.ToString() == "Maternity Leave")
                type = "Maternity Leave";
            else if (leve_type_combo.SelectedItem.ToString() == "Study Leave")
                type = "Study Leave";
            else if (leve_type_combo.SelectedItem.ToString() == "Sick Leave")
                type = "Sick Leave";

            try
            {
                var context = new leave_managementEntities();

                var t = new leaves
                {
                    leave_id = leave_id_lbl.Text,
                    emp_id = emp_id_txt.Text,
                    type = type,
                    start_date = start_date.Value.Date,
                    end_date = end_date.Value.Date,
                    duration = days,
                    reason = reason_txt.Text,
                    status = "not authorized",
                    authorized_by = "None"
                };

                context.leaves1.Add(t);
                context.SaveChanges();

                MessageBox.Show("The request has been sent successfully", "Sent", MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private int calculate_duration()
        {
                DateTime date1 = start_date.Value.Date;
                DateTime date2 = end_date.Value.Date;


           if (date1 > date2)
                    MessageBox.Show("Incorrect last day " + date2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TimeSpan span = date2 - date1;
            int businessDays = span.Days + 1;
            int fullWeekCount = businessDays / 7;
            // find out if there are weekends during the time exceedng the full weeks
            if (businessDays > fullWeekCount*7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                int firstDayOfWeek = (int) date1.DayOfWeek;
                int lastDayOfWeek = (int) date2.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        businessDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        businessDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    businessDays -= 1;
            }

            // subtract the weekends during the full weeks in the interval
            businessDays -= fullWeekCount + fullWeekCount;

            // subtract the number of bank holidays during the time interval
            //foreach (DateTime bankHoliday in bankHolidays)
            //{
            //    DateTime bh = bankHoliday.Date;
            //    if (firstDay <= bh && bh <= lastDay)
            //        --businessDays;
            //}

            return businessDays;
        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            duration_lbl.Text = calculate_duration() +" days";
        }

        private void start_date_ValueChanged(object sender, EventArgs e)
        {
            end_date.Value = start_date.Value;
            duration_lbl.Text = calculate_duration() + " days";
        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
                DateTime date1 = start_date.Value.Date;
                DateTime date2 = end_date.Value.Date;

            if(reason_txt.Text != "" && date1 <= date2)
            {
                metroButton2.Enabled = true;
            }
        }
    }
}
