namespace LMS_Project
{
    partial class scr_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scr_login));
            this.lbl_1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.error_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.uname_txt = new MetroFramework.Controls.MetroTextBox();
            this.password_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(917, 25);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(101, 20);
            this.lbl_1.TabIndex = 16;
            this.lbl_1.Text = "employee post";
            this.lbl_1.Visible = false;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel4.Controls.Add(this.error_lbl);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Controls.Add(this.metroButton1);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.uname_txt);
            this.metroPanel4.Controls.Add(this.password_txt);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(598, 109);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(396, 357);
            this.metroPanel4.TabIndex = 15;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.error_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.error_lbl.Location = new System.Drawing.Point(159, 126);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(193, 17);
            this.error_lbl.Style = MetroFramework.MetroColorStyle.Red;
            this.error_lbl.TabIndex = 12;
            this.error_lbl.Text = "*Invalid user name or password";
            this.error_lbl.UseCustomBackColor = true;
            this.error_lbl.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 55);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "User name";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Password";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(271, 291);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 30);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Log in";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 185);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(156, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Don\'t have an account? ";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.MediumBlue;
            this.metroLabel2.Location = new System.Drawing.Point(253, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Sign in";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // uname_txt
            // 
            // 
            // 
            // 
            this.uname_txt.CustomButton.Image = null;
            this.uname_txt.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.uname_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uname_txt.CustomButton.Name = "";
            this.uname_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uname_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname_txt.CustomButton.TabIndex = 1;
            this.uname_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname_txt.CustomButton.UseSelectable = true;
            this.uname_txt.CustomButton.Visible = false;
            this.uname_txt.Lines = new string[0];
            this.uname_txt.Location = new System.Drawing.Point(194, 49);
            this.uname_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uname_txt.MaxLength = 32767;
            this.uname_txt.Name = "uname_txt";
            this.uname_txt.PasswordChar = '\0';
            this.uname_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname_txt.SelectedText = "";
            this.uname_txt.SelectionLength = 0;
            this.uname_txt.SelectionStart = 0;
            this.uname_txt.ShortcutsEnabled = true;
            this.uname_txt.Size = new System.Drawing.Size(169, 26);
            this.uname_txt.TabIndex = 6;
            this.uname_txt.UseSelectable = true;
            this.uname_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uname_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password_txt
            // 
            // 
            // 
            // 
            this.password_txt.CustomButton.Image = null;
            this.password_txt.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.password_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.CustomButton.Name = "";
            this.password_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_txt.CustomButton.TabIndex = 1;
            this.password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_txt.CustomButton.UseSelectable = true;
            this.password_txt.CustomButton.Visible = false;
            this.password_txt.Lines = new string[0];
            this.password_txt.Location = new System.Drawing.Point(194, 87);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.MaxLength = 32767;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '●';
            this.password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_txt.SelectedText = "";
            this.password_txt.SelectionLength = 0;
            this.password_txt.SelectionStart = 0;
            this.password_txt.ShortcutsEnabled = true;
            this.password_txt.Size = new System.Drawing.Size(169, 26);
            this.password_txt.TabIndex = 7;
            this.password_txt.UseSelectable = true;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(41, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(511, 445);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(263, 17);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(234, 66);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // scr_login
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(1062, 573);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.metroPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "scr_login";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.scr_login_Activated);
            this.Load += new System.EventHandler(this.scr_login_Load);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel error_lbl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox uname_txt;
        private MetroFramework.Controls.MetroTextBox password_txt;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;


    }
}

