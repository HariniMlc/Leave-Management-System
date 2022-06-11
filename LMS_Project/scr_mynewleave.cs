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
    public partial class scr_mynewleave : MetroFramework.Forms.MetroForm
    {
        string type;

        public scr_mynewleave(string employee_id)
        {
            InitializeComponent();
            leave_id_lbl.Visible = true;
            work_years_lbl.Visible = false;
            lbl_joined_date.Visible = false;
            emp_id_txt.Text = employee_id;
            work_years_lbl.Text = get_work_years();
            load_values();
            end_date.MinDate = DateTime.Now.Date;
            start_date.MinDate = DateTime.Now.Date;
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

                leave_id_lbl.Text = (int.Parse(showPiece.leave_id)+1).ToString();
            }
            catch(Exception exp)
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
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            emp_id_txt.Text = "";
            leve_type_combo.SelectedText = "<select>";
            //status_lbl.Text = "";
            reason_txt.Text = "";
            start_date.Text = "";
            end_date.Text = "";
            duration_lbl.Text = "0";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            calculate_duration();
            update_no_of_leaves();
            save_leave();  
        }

        private void update_no_of_leaves()
        {
            int days = int.Parse(duration_lbl.Text);

            if (leve_type_combo.SelectedItem.ToString() == "Half Day")
            {
                using (leave_managementEntities context = new leave_managementEntities())
                {
                    var a = context.emp_leave_availability.Find(emp_id_txt.Text);
                    a.halfday = Convert.ToInt32(a.halfday + days);
                    a.work_years = Convert.ToDouble(work_years_lbl.Text);
                    context.SaveChanges();
                }
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Short Leave")
            {
                using (leave_managementEntities context = new leave_managementEntities())
                {
                    var a = context.emp_leave_availability.Find(emp_id_txt.Text);
                    a.work_years = Convert.ToDouble(work_years_lbl.Text);
                    a.short_day = Convert.ToInt32(a.short_day + days);
                    context.SaveChanges();
                }
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Maternity Leave")
            {
                using (leave_managementEntities context = new leave_managementEntities())
                {
                    var a = context.emp_leave_availability.Find(emp_id_txt.Text);
                    a.work_years = Convert.ToDouble(work_years_lbl.Text);
                    a.maternity_leave = Convert.ToInt32(a.maternity_leave + days);
                    context.SaveChanges();
                }
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Study Leave")
            {
                using (leave_managementEntities context = new leave_managementEntities())
                {
                    var a = context.emp_leave_availability.Find(emp_id_txt.Text);
                    a.work_years = Convert.ToDouble(work_years_lbl.Text);
                    a.study_leave = Convert.ToInt32(a.study_leave + days);
                    context.SaveChanges();
                }
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Sick Leave")
            {
                using (leave_managementEntities context = new leave_managementEntities())
                {
                    var a = context.emp_leave_availability.Find(emp_id_txt.Text);
                    a.work_years = Convert.ToDouble(work_years_lbl.Text);
                    a.sick_leave = Convert.ToInt32(a.sick_leave + days);
                    context.SaveChanges();
                }
            }  
        }

        private void save_leave()
        {
            if (leve_type_combo.SelectedItem.ToString() == "Half Day")
            {
                type = "Half Day";
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Short Leave")
            {
                type = "Short Leave";
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Maternity Leave")
            {
                type = "Maternity Leave";
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Study Leave")
            {
                type = "Study Leave";
            }
            else if (leve_type_combo.SelectedItem.ToString() == "Sick Leave")
            {
                type = "Sick Leave";
            }  
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
                    duration = int.Parse(duration_lbl.Text),
                    reason = reason_txt.Text,
                    status = "not authorized",
                    authorized_by = "None"
                };

                context.leaves1.Add(t);
                context.SaveChanges();

                MessageBox.Show("Request Sent!");
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void calculate_duration()
        {
            //if (leve_type_combo.SelectedItem.ToString()!= "")
            if (leve_type_combo.SelectedIndex != 0)
            {
                DateTime date1 = end_date.Value.Date;
                DateTime date2 = start_date.Value.Date;

                TimeSpan difference = date1 - date2;
                int days = int.Parse(difference.ToString("dd"));
                duration_lbl.Text = days.ToString();   
            }
            else
            {
                MessageBox.Show("select leave type");
            }
        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
                calculate_duration();
        }
    }
}
