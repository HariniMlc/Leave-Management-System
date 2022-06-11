using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Collections.Specialized;
using System.Web.UI.WebControls;
using System.IO;

namespace LMS_Project
{
    public partial class pnl_authorize : pnl_slider
    {
        Form Owner;

        public pnl_authorize(Form owner, string name, string type, string sender_empid) : base(owner)
        {
            InitializeComponent();
            metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 79, 155);
            metroGrid1.EnableHeadersVisualStyles = false;
              lbl_emp_id.Visible = false;
              lbl_leave_id.Visible = false;
              lbl_name.Visible = false;
              lbl_post.Visible = false;
              lbl_email.Visible = false;
              lbl_sender_email.Visible = false;
              sender_emp_id.Visible = false;
              Owner = owner;
              

            sender_emp_id.Text = sender_empid;


            lbl_post.Text = type;
            get_sender();

            if (lbl_post.Text == "employee")
            {
                populate_employees(type);
            }
            else if (lbl_post.Text == "manager")
            {
                populate_employees(type);
            }

            lbl_name.Text = name;
            get_email();
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

        private void get_sender()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == sender_emp_id.Text
                            select new
                            {
                                o.email
                                //o.email_password
                            };

                foreach (var item in query)
                {
                    lbl_sender_email.Text = item.email;
                   // email_password_lbl.Text = item.email_password;
                }
            }
        }

        private void populate_employees(string post)
        {
            try
            {
                using (var db = new leave_managementEntities())
                {
                    var query = from x in db.leaves1
                                where x.status == "not authorized" && x.employee.post == post
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

        private void scr_authorize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leave_managementDataSet.leaves' table. You can move, or remove it, as needed.
            //this.leavesTableAdapter.Fill(this.leave_managementDataSet.leaves);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve this request?", "Approve", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                authorize_row();
                update_no_of_leaves();
                send_email(lbl_email.Text, true);
            }                  
        }

        private void get_email()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.email,
                                o.email_password
                            };

                foreach (var item in query)
                {
                    lbl_email.Text = item.email;
                    email_password_lbl.Text = item.email_password;
                }
            }
        }

        private void send_email(string email, bool a)
        {
            try
            {
                //email = "harini.mallawaarachchi@gmail.com";
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("harini.mallawaarachchi@gmail.com", "asymptotic");
                //client.Credentials = new NetworkCredential("skoditu@gmail.com", "hd162092");
                client.Credentials = new NetworkCredential(lbl_sender_email.Text, email_password_lbl.Text);
                MailMessage msg = new MailMessage();
                //msg.To.Add("skodi95@gmail.com");
                msg.To.Add(email);
                //msg.From = new MailAddress("harini.mallawaarachchi@gmail.com");
                //msg.From = new MailAddress("skoditu@gmail.com");
                msg.From = new MailAddress(lbl_sender_email.Text);
                msg.IsBodyHtml = true;
                //msg.Body = CreateEmailBody();

                //if (a == true)
                //{
                //    msg.Subject = "Approved";
                //    msg.Body = "<div class=\"header\"><pre><h1 align =\"center\" style=\"color:darkblue;\" ><img src=\"C:\\Users\\toshiba\\Desktop\\logo.jpg\"><b> <i>Leave Request</i> </b> </h1>			</pre><hr></div><div class=\"body\"><div class=\"body-head\"><h3> Your leave request has been approved. </h3></div><div class=\"body-body\"><p>	Details:<br/>&nbsp&nbsp&nbsp&nbsp Name:@@emp_name@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Type:@@leave_type@@<br/>&nbsp&nbsp&nbsp&nbsp No of Days:@@calculated_days@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Reference No:@@leave_no@@<br/>		</p></div><hr><pre>Regards,<br/>Manager</pre>	</div>	";
                //}
                //else if (a == false)
                //{
                //    msg.Subject = "Rejected";
                //    msg.Body = "<div class=\"header\"><pre><h1 align =\"center\" style=\"color:darkblue;\" ><img src=\"C:\\Users\\toshiba\\Desktop\\logo.jpg\"><b> <i>Leave Request</i> </b> </h1>			</pre><hr></div><div class=\"body\"><div class=\"body-head\"><h3> Your leave request has been rejected. </h3></div><div class=\"body-body\"><p>	Details:<br/>&nbsp&nbsp&nbsp&nbsp Name:@@emp_name@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Type:@@leave_type@@<br/>&nbsp&nbsp&nbsp&nbsp No of Days:@@calculated_days@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Reference No:@@leave_no@@<br/>		</p></div><hr><pre>Regards,<br/>Manager</pre>	</div>	";
                //}

                if (a == true)
                {
                    msg.Subject = "Approved";
                    msg.Body = CreateEmailBody(a);
                }
                else if (a == false)
                {
                    msg.Subject = "Rejected";
                    msg.Body = CreateEmailBody(a);
                }
                
                client.Send(msg);

                MessageBox.Show("The email is sent to the employee", "Email Sent",MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
            }
            catch (SmtpException exp)
            {
                MessageBox.Show(exp.Message,"error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CreateEmailBody(bool a)
        {
            string body = string.Empty;


            if(a == true)
                body = "<div class=\"header\"><pre><h1 align =\"center\" style=\"color:darkblue;\" ><img src=\"C:\\Users\\harmlk\\Documents\\LMS_Project\\LMS_Project\\pictures of LMS\\logo.jpg\"><b> <i>Leave Request</i> </b> </h1>			</pre><hr></div><div class=\"body\"><div class=\"body-head\">Hi {name}, </br><h3> Your leave request has been approved. </h3></div><div class=\"body-body\"><p>	Details:<br/>  Leave Type:{leave type}<br/> From Date: {from}<br/> To Date: {to}<br/> Leave Reference No: {leaveid}<br/>		</p></div><hr><pre>Regards,<br/>Manager</br>{manager}</pre>	</div>	";
            else
                body = "<div class=\"header\"><pre><h1 align =\"center\" style=\"color:darkblue;\" ><img src=\"C:\\Users\\harmlk\\Documents\\LMS_Project\\LMS_Project\\pictures of LMS\\logo.jpg\"><b> <i>Leave Request</i> </b> </h1>			</pre><hr></div><div class=\"body\"><div class=\"body-head\">Hi {name}, </br><h3> Your leave request has been Rejected. </h3></div><div class=\"body-body\"><p>	Details:<br/>  Leave Type:{leave type}<br/> From Date: {from}<br/> To Date: {to}<br/> Leave Reference No: {leaveid}<br/>		</p></div><hr><pre>Regards,<br/>Manager</br>{manager}</pre>	</div>	";


            body = body.Replace("{name}", lbl_emp_name.Text);
            body = body.Replace("{leave type}", lbl_leave_type.Text);
            body = body.Replace("{from}", lbl_from.Text);
            body = body.Replace("{to}", lbl_to.Text);
            body = body.Replace("{leaveid}", lbl_leave_id.Text);
            body = body.Replace("{manager}", lbl_name.Text);

            return body;

        }

        private void update_no_of_leaves()
        {
            work_years_lbl.Text = get_work_years();

            string leave_type = null;
            int duration = 0;

            using (leave_managementEntities context = new leave_managementEntities())
            {
                //var a = context.leaves1.Find(lbl_leave_id.Text);
                //leave_type = a.type;
                //duration = Convert.ToInt32(a.duration);

                var query = from o in context.leaves1
                            where o.leave_id == lbl_leave_id.Text
                            select new
                            {
                                o.duration,
                                o.type
                            };

                foreach (var item in query)
                {
                    duration = Convert.ToInt32(item.duration);
                    leave_type = item.type;
                }

                var a = context.emp_leave_availability.Find(lbl_emp_id.Text);

                switch (leave_type)
                {
                    case "Half Day":
                        a.halfday = Convert.ToInt32(a.halfday + duration);
                        a.work_years = Convert.ToDouble(work_years_lbl.Text);
                        context.SaveChanges();
                        break;
                    case "Short Leave":
                        a.short_day = Convert.ToInt32(a.halfday + duration);
                        a.work_years = Convert.ToDouble(work_years_lbl.Text);
                        context.SaveChanges();
                        break;
                    case "Maternity Leave":
                        a.maternity_leave = Convert.ToInt32(a.halfday + duration);
                        a.work_years = Convert.ToDouble(work_years_lbl.Text);
                        context.SaveChanges();
                        break;
                    case "Study Leave":
                        a.study_leave = Convert.ToInt32(a.halfday + duration);
                        a.work_years = Convert.ToDouble(work_years_lbl.Text);
                        context.SaveChanges();
                        break;
                    case "Sick Leave":
                        a.sick_leave = Convert.ToInt32(a.halfday + duration);
                        a.work_years = Convert.ToDouble(work_years_lbl.Text);
                        context.SaveChanges();
                        break;
                    default:
                        //MessageBox.Show("ERROR!");
                        break;
                }

            }
            
        }

        private void authorize_row()
        {
            using (leave_managementEntities context = new leave_managementEntities())
            {
                try
                {
                    var a = context.leaves1.Find(lbl_leave_id.Text);
                    a.authorized_by = lbl_name.Text;
                    a.status = "authorized";
                    context.SaveChanges();
                    MessageBox.Show("The request has been authorized", "Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    populate_employees(lbl_post.Text);


                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];
                lbl_emp_id.Text = Convert.ToString(selectedRow.Cells[1].Value);
                lbl_leave_id.Text = Convert.ToString(selectedRow.Cells[0].Value);
                get_email();
            }


            using (leave_managementEntities context = new leave_managementEntities())
            {
                var query = from o in context.leaves1
                            where o.leave_id == lbl_leave_id.Text
                            select new
                            {
                                o.start_date,
                                o.end_date,
                                o.type
                            };

                var query2 = from o in context.employees
                             where o.emp_id == lbl_emp_id.Text
                             select new
                             {
                                 o.name
                             };

                foreach (var item in query)
                {
                    lbl_from.Text = item.start_date.ToString();
                    lbl_to.Text = item.end_date.ToString();
                    lbl_leave_type.Text = item.type;
                }

                foreach (var item in query2)
                {
                    lbl_emp_name.Text = item.name;
                }

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //new scr_employee_details(lbl_emp_id.Text).Show();
            pnl_employee_details _pnl_employee_details = new pnl_employee_details(Owner, lbl_emp_id.Text, false);
            _pnl_employee_details.swipe(true);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //new scr_leave_hours(lbl_emp_id.Text).Show();
            pnl_leave_availability _pnl_leave_availability = new pnl_leave_availability(Owner, lbl_emp_id.Text);
            _pnl_leave_availability.swipe(true);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reject this request?", "Reject", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                reject_row();
                send_email(lbl_email.Text, false);
            }                
        }

        private void reject_row()
        {
            using (leave_managementEntities context = new leave_managementEntities())
            {
                try
                {
                    var a = context.leaves1.Find(lbl_leave_id.Text);
                    a.authorized_by = lbl_name.Text;
                    a.status = "rejected";
                    context.SaveChanges();
                    MessageBox.Show("The leave request is rejected.", "Rejected", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                    populate_employees(lbl_post.Text);


                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}
