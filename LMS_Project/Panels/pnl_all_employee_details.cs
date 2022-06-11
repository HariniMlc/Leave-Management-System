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
    public partial class pnl_all_employee_details : pnl_slider
    {
        string post;
        Form Owner;

        public pnl_all_employee_details(Form owner, string type) : base (owner)
        {
            InitializeComponent();
            post = type;
            populate_table(type);
            metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 79, 155);
            metroGrid1.EnableHeadersVisualStyles = false;
            Owner = owner;
        }

        private void populate_table(string post)
        {
            try
            {
                using (var db = new leave_managementEntities())
                {
                    var query = from x in db.employees
                                where x.post == post
                                orderby x.emp_id
                                select x;

                    metroGrid1.DataSource = query.ToList();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void scr_select_employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leave_managementDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.leave_managementDataSet1.employees);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //new scr_leave_hours(empid_lbl.Text).Show();
            //this.swipe(false);

            pnl_leave_availability _pnl_leave_availability = new pnl_leave_availability(Owner, empid_lbl.Text);
            _pnl_leave_availability.swipe(true);
        }

        private void metroGrid1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];
                empid_lbl.Text = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            error.Text = "";
            get_details();
        }

        private void get_details()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var Exists = a.employees.Any(x => x.emp_id == txt_empid.Text);

                if (Exists)
                {
                    var query = from o in a.employees
                                where o.emp_id == txt_empid.Text &&
                                o.post == post
                                select o;

                    metroGrid1.DataSource = query.ToList();
                }
                else
                    error.Text = "The employee Id doesn't exist";
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            populate_table(post);
        }
    }
}
