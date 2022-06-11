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
    public partial class scr_myhistory : MetroFramework.Forms.MetroForm
    {
        public scr_myhistory(string emp)
        {
            InitializeComponent();
            emp_id_txt.Visible = false;
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


    }
}
