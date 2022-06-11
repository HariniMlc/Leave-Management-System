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
    public partial class scr_employee_details : MetroFramework.Forms.MetroForm
    {
        public scr_employee_details(string empid)
        {
            InitializeComponent();
            lbl_emp_id.Text = empid;

            load_details();
        }

        private void load_details()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.name,
                                o.tel_no,
                                o.email,
                                o.department,
                                o.post,
                                o.manager,
                                o.gender
                            };

                foreach (var item in query)
                {
                    lbl_name.Text = item.name;
                    lbl_dep.Text = item.department;
                    lbl_post.Text = item.post;
                    lbl_mob_no.Text = item.tel_no;
                    lbl_email.Text = item.email;
                    lbl_mngr.Text = item.manager;
                    lbl_gender.Text = item.gender;
                }
            }
            
        }


        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
