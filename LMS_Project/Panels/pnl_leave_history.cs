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
    public partial class pnl_leave_history : pnl_slider
    {
        public pnl_leave_history(Form owner, string emp) : base(owner)
        {
            InitializeComponent();
            metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 79, 155);
            metroGrid1.EnableHeadersVisualStyles = false;
            emp_id_txt.Visible = false;
            lbl_leave_id.Visible = false;
            emp_id_txt.Text = emp;
            populate_history();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scr_myhistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leave_managementDataSet.leaves' table. You can move, or remove it, as needed.
            // this.leavesTableAdapter.Fill(this.leave_managementDataSet.leaves);

        }

        private void metroPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void populate_history()
        {
            try
            {
                using (var db = new leave_managementEntities())
                {
                    var query = from x in db.leaves1
                                where x.emp_id == emp_id_txt.Text
                                orderby x.leave_id
                                select x;

                    metroGrid1.DataSource = query.ToList();

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void metroPanel2_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_leave_id.Text = "";
            try
            {
                using (var db = new leave_managementEntities())
                {
                    var query = from x in db.leaves1
                                where x.emp_id == emp_id_txt.Text &&
                                (x.start_date >= start_date.Value.Date && x.end_date <= end_date.Value.Date)
                                orderby x.leave_id
                                select x;
                    
                    metroGrid1.DataSource = query.ToList();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {          
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the request?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new leave_managementEntities())
                {
                    var query = (from x in db.leaves1
                                 where x.leave_id == lbl_leave_id.Text
                                 select x).FirstOrDefault();
                    db.leaves1.Remove(query);
                    db.SaveChanges();

                    populate_history();

                }
            }
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[7].RowIndex;
                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];
                lbl_leave_id.Text = Convert.ToString(selectedRow.Cells[0].Value);

                string status = Convert.ToString(selectedRow.Cells[6].Value);

                if (status.Equals("authorized"))
                {
                    btn_del.Enabled = false;
                }
                else
                    btn_del.Enabled = true;
            }     
        }
    }
}
