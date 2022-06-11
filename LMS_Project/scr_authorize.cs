using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace LMS_Project
{
    public partial class scr_authorize : MetroFramework.Forms.MetroForm
    {
        public scr_authorize(string name, string type,string sender_empid)
        {
            InitializeComponent();
          /*  lbl_emp_id.Visible = false;
            lbl_leave_id.Visible = false;
            lbl_name.Visible = false;
            lbl_post.Visible = false;
            lbl_email.Visible = false;
            lbl_sender_email.Visible = false;
            sender_emp_id.Visible = false;*/

            sender_emp_id.Text = sender_empid;

            if(metroGrid1.RowCount==0)
            {
                metroButton2.Visible = false;
                metroButton3.Visible = false;
            }

            lbl_post.Text = type;
            get_sender();

            if (lbl_post.Text == "employee")
            {
                populate_employees(type);   
            }
            else if(lbl_post.Text == "manager")
            {
                populate_employees(type);
            }

            lbl_name.Text = name;
            get_email();
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
                            };

                foreach (var item in query)
                {
                    lbl_sender_email.Text = item.email;
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
            authorize_row();
            send_email(lbl_email.Text);
        }

        private void get_email()
        {
            using (leave_managementEntities a = new leave_managementEntities())
            {
                var query = from o in a.employees
                            where o.emp_id == lbl_emp_id.Text
                            select new
                            {
                                o.email
                            };

                foreach (var item in query)
                {
                    lbl_email.Text = item.email;
                }
            }
        }

        private void send_email(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("skoditu@gmail.com", "hd162092");
                MailMessage msg = new MailMessage();
                msg.To.Add("skodi95@gmail.com");
                msg.From = new MailAddress("skoditu@gmail.com");
                msg.Subject = "Approved";
                msg.IsBodyHtml = true;
                msg.Body = "<div class=\"header\"><pre><h1 align =\"center\" style=\"color:darkblue;\" ><img src=\"C:\\Users\\toshiba\\Desktop\\logo.jpg\"><b> <i>Leave Request</i> </b> </h1>			</pre><hr></div><div class=\"body\"><div class=\"body-head\"><h3> Your leave request has been approved. </h3></div><div class=\"body-body\"><p>	Details:<br/>&nbsp&nbsp&nbsp&nbsp Name:@@emp_name@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Type:@@leave_type@@<br/>&nbsp&nbsp&nbsp&nbsp No of Days:@@calculated_days@@<br/>&nbsp&nbsp&nbsp&nbsp Leave Reference No:@@leave_no@@<br/>		</p></div><hr><pre>Regards,<br/>Manager</pre>	</div>	"
   ;
                client.Send(msg);

                MessageBox.Show("email sent!");


               /* MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("skoditu@gmail.com");
                mail.To.Add("skodi95@gmail.com");
                mail.Subject = "Approved";
                mail.Body = "Your leave has been approved.";
                //Attachment attachment = new Attachment(filename);
                //mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("skoditu@gmail.com", "955881958v");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("success");*/
            }
            catch (SmtpException exp)
            {
                MessageBox.Show(exp.Message);
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
                    MessageBox.Show("Authorized");

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
            }
        }
    }
}
