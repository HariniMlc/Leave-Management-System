using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace LMS_Project
{
    public partial class pnl_report : pnl_slider
    {
        Form Owner;
        DateTime start;
        DateTime end;

        public pnl_report(Form owner, string empid) : base (owner)
        {
            InitializeComponent();
            lbl_empid.Text = empid;
            get_department();
            populate_employee_cmb();
            populate_duration_cmb();
            populate_leavetype_cmb();
            populate_status_cmb();

            Owner = owner;

            IList<int> years = Enumerable.Range(1910, DateTime.Now.Year - 1910 + 1).ToList();
             year_picker.DataSource = years;

            

        }

        private void get_department()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_empid.Text
                            select new
                            {
                                o.department
                            };
                foreach (var item in query)
                {
                    lbl_department.Text = item.department;
                }
            }
        }

        private void populate_employee_cmb()
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add(lbl_department.Text);
            list.Add("Select");
            employee_cmb.DataSource = list;
        }

        private void populate_duration_cmb()
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("Annual");
            list.Add("Custom");
            duration_cmb.DataSource = list;
        }

        private void populate_leavetype_cmb()
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("All");
            list.Add("Sick Leave");
            list.Add("Maternity");
            list.Add("Short Leave");
            list.Add("Half day");
            list.Add("Study Leave");
            leavetype_cmb.DataSource = list;
        }

        private void populate_status_cmb()
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("All");
            list.Add("Rejected");
            list.Add("Authorized");
            list.Add("Not Authorized");
            status_cmb.DataSource = list;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (duration_cmb.Text.Equals("Annual"))
            {
                int y = Convert.ToInt32(year_picker.SelectedItem);
                start = new DateTime(y , 1, 1);
                end = new DateTime(y , 12, 31);
            }
            else
            {
                start = start_date.Value.Date;
                end = end_date.Value.Date;
            }   

            pnl_report_result results = new pnl_report_result(Owner,
                                                                start,
                                                                end,
                                                                lbl_leave_type.Text,
                                                                lbl_status.Text,
                                                                txt_empid.Text,
                                                                lbl_employees.Text,
                                                                lbl_department.Text
                                                                );
            results.swipe(true);

        }

        private void employee_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employee_cmb.Text.Equals("Select"))
                metroPanel4.Visible = true;
            else
                metroPanel4.Visible = false;

            lbl_employees.Text = employee_cmb.Text;
        }

        private void duration_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (duration_cmb.Text.Equals("Custom"))
            {
                custom_pnl.Visible = true;
                annual_panel.Visible = false;
            }
            else
            {
                custom_pnl.Visible = false;
                annual_panel.Visible = true;
            }   
        }

        private void leavetype_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_leave_type.Text = leavetype_cmb.Text;
        }

        private void status_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_status.Text = status_cmb.Text;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where (o.emp_id == txt_empid.Text) 
                            && (o.department == lbl_department.Text)
                            select new
                            {
                                o.name,
                            };

                foreach (var item in query)
                {
                    txt_name.Text = item.name;
                }
            }
            if(txt_name.Text == "")
            {
                MessageBox.Show("Invalid employee id.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
