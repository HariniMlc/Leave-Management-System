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
    public partial class scr_all_employee_details : MetroFramework.Forms.MetroForm
    {
        public scr_all_employee_details(string type)
        {
            InitializeComponent();
            populate_table(type);
            empid_lbl.Visible = false;
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new scr_leave_hours(empid_lbl.Text).Show();
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
    }
}
