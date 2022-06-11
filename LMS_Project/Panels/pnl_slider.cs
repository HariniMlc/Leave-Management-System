using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace LMS_Project
{
    public partial class pnl_slider : MetroFramework.Controls.MetroUserControl
    {
        Form _owner = null;
        bool _loaded = false;

        #region Events
        public event EventHandler Closed;
        public event EventHandler Shown;

        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;

            if (handler != null) handler(this, e);
        }

        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;

            if (handler != null) handler(this, e);
        }
        #endregion

        public pnl_slider()
        {
            InitializeComponent();
        }

        public pnl_slider(Form owner) : this()
        {
            this.Visible = false;
            _owner = owner;
            owner.Controls.Add(this);
            this.BringToFront();
            owner.Resize += owner_Resize;
            this.Click += pnl_slider_Click;

            ResizeForm();
        }

        void pnl_slider_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        void owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = _owner.Width;
            this.Height = _owner.Height;
            this.Location = new Point(_loaded ? 0 : _owner.Width, 0);
        }

        public void swipe(bool show = true)
        {
            this.Visible = true;
            Transition _transasition = new Transitions.Transition(new TransitionType_EaseInEaseOut(500));
            _transasition.add(this, "Left", show ? 0 : this.Width);
            _transasition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                closed(new EventArgs());
                _owner.Resize -= owner_Resize;
                _owner.Controls.Remove(this);
                //this.Dispose();
            }
            else
            {
                _loaded = true;
                //  ResizeForm();
                shown(new EventArgs());
            }
        }

        private void metroPanel2_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

    }
}