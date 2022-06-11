using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace LMS_Project
{
    public partial class pnl_start : pnl_slider
    {
        public pnl_start(Form owner) : base(owner)
        {
            InitializeComponent();
            //string message = lbl_title.Text;
            lbl_title.Text = "";
        }

        #region Title Animator

        int count = 0;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private string message = "Leave" + Environment.NewLine + "Management" + Environment.NewLine + "System";  

        private void SetTimer(int milliseconds)
        {            
            timer1.Tick+=new EventHandler(timer1_Tick);
            timer1.Interval = milliseconds;        
            timer1.Start();
        }
        private void timer1_Tick(Object o, EventArgs e)
        {
            //lbl_title.Text = lbl_title.Text.Substring(0, lbl_title.Text.Length - 1);

            if (count < message.Length)
            {
                lbl_title.Text += message[count];
                count++;
            }
            else
            {
                timer1.Stop();
                swipe(false);
            }
        }
        #endregion

        private void pnl_start_Load(object sender, EventArgs e)
        {
            SetTimer(50);
        }
    }
}
