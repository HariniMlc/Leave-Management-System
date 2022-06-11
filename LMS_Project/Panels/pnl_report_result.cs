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
    public partial class pnl_report_result : pnl_slider
    {
        public pnl_report_result(Form owner, DateTime start, DateTime end, string type, string status, string empid, string employees, string department) : base (owner)
        {
            InitializeComponent();
            metroTabControl1.SelectedTab = metroTabPage1;
            result_grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 79, 155);
            result_grid.EnableHeadersVisualStyles = false;

            populate_result_grid(start, end, type, status, empid, employees, department);
            create_chart();
        }

        private void populate_result_grid(DateTime start, DateTime end, string type, string status, string empid, string employees, string department)
        {
            try
            {
                using (var db = new leave_managementEntities())
                {
                    var query1 = from x in db.leaves1
                                 where (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    var query2 = from x in db.leaves1
                                 where x.type == type &&
                                 (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    var query3 = from x in db.leaves1
                                 where x.status == status &&
                                 (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    var query4 = from x in db.leaves1
                                 where x.emp_id == empid &&
                                 (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    var query5 = from x in db.leaves1
                                 where x.emp_id == empid &&
                                 x.type == type &&
                                 (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    var query6 = from x in db.leaves1
                                 where x.emp_id == empid &&
                                 x.status == status &&
                                 (x.start_date >= start && x.end_date <= end)
                                 orderby x.leave_id
                                 select x;

                    if (employees.Equals(department))
                    {
                        if (type.Equals("All") && status.Equals("All"))
                            result_grid.DataSource = query1.ToList();
                        else if (!type.Equals("All"))
                            result_grid.DataSource = query2.ToList();
                        else
                            result_grid.DataSource = query3.ToList();
                    }
                    else if (employees.Equals("Select"))
                    {
                        if (type.Equals("All") && status.Equals("All"))
                            result_grid.DataSource = query4.ToList();
                        else if (type.Equals("All"))
                            result_grid.DataSource = query5.ToList();
                        else
                            result_grid.DataSource = query6.ToList();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void create_chart()
        {
            int halfday = 0;
            int fullday = 0;
            int sick = 0;
            int mat = 0;
            int study = 0;

            if (result_grid.Rows.Count > 0)
            {
                for (int i = 0; i < result_grid.Rows.Count; ++i)
                {
                    if (result_grid.Rows[i].Cells[2].Value.Equals("Half Day"))
                        halfday += Convert.ToInt32(result_grid.Rows[i].Cells[5].Value);
                    else if (result_grid.Rows[i].Cells[2].Value.Equals("Full Day"))
                        fullday += Convert.ToInt32(result_grid.Rows[i].Cells[5].Value);
                    else if (result_grid.Rows[i].Cells[2].Value.Equals("Sick Leave"))
                        sick += Convert.ToInt32(result_grid.Rows[i].Cells[5].Value);
                    else if (result_grid.Rows[i].Cells[2].Value.Equals("Maternity Leave"))
                        mat += Convert.ToInt32(result_grid.Rows[i].Cells[5].Value);
                    else if (result_grid.Rows[i].Cells[2].Value.Equals("Study Leave"))
                        study += Convert.ToInt32(result_grid.Rows[i].Cells[5].Value);
                }

                this.chart1.Series["Taken Leaves"].Points.AddXY("Half day", halfday);
                this.chart1.Series["Taken Leaves"].Points.AddXY("Full day", fullday);
                this.chart1.Series["Taken Leaves"].Points.AddXY("Sick Leaves", sick);
                this.chart1.Series["Taken Leaves"].Points.AddXY("Maternity Leaves", mat);
                this.chart1.Series["Taken Leaves"].Points.AddXY("Study Leaves", study);
            }
            else
                MessageBox.Show("No records available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
