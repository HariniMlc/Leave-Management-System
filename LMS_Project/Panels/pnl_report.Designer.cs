namespace LMS_Project
{
    partial class pnl_report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.leavemanagementDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leave_managementDataSet3 = new LMS_Project.leave_managementDataSet3();
            this.lbl_leave_type = new MetroFramework.Controls.MetroLabel();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.lbl_department = new MetroFramework.Controls.MetroLabel();
            this.lbl_empid = new MetroFramework.Controls.MetroLabel();
            this.lbl_employees = new MetroFramework.Controls.MetroLabel();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.annual_panel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.year_picker = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_empid = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.custom_pnl = new MetroFramework.Controls.MetroPanel();
            this.end_date = new MetroFramework.Controls.MetroDateTime();
            this.start_date = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.status_cmb = new MetroFramework.Controls.MetroComboBox();
            this.leavetype_cmb = new MetroFramework.Controls.MetroComboBox();
            this.duration_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.employee_cmb = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.leavemanagementDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_managementDataSet3)).BeginInit();
            this.panel.SuspendLayout();
            this.annual_panel.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.custom_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth Lt BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 51);
            this.label1.TabIndex = 34;
            this.label1.Text = "Create Reports";
            // 
            // leavemanagementDataSet3BindingSource
            // 
            this.leavemanagementDataSet3BindingSource.DataSource = this.leave_managementDataSet3;
            this.leavemanagementDataSet3BindingSource.Position = 0;
            // 
            // leave_managementDataSet3
            // 
            this.leave_managementDataSet3.DataSetName = "leave_managementDataSet3";
            this.leave_managementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_leave_type
            // 
            this.lbl_leave_type.AutoSize = true;
            this.lbl_leave_type.Location = new System.Drawing.Point(718, 36);
            this.lbl_leave_type.Name = "lbl_leave_type";
            this.lbl_leave_type.Size = new System.Drawing.Size(73, 20);
            this.lbl_leave_type.TabIndex = 37;
            this.lbl_leave_type.Text = "leave type";
            this.lbl_leave_type.Visible = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(718, 63);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 20);
            this.lbl_status.TabIndex = 38;
            this.lbl_status.Text = "status";
            this.lbl_status.Visible = false;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(1021, 63);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(82, 20);
            this.lbl_department.TabIndex = 39;
            this.lbl_department.Text = "department";
            this.lbl_department.Visible = false;
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.Location = new System.Drawing.Point(1051, 36);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(52, 20);
            this.lbl_empid.TabIndex = 41;
            this.lbl_empid.Text = "emp id";
            this.lbl_empid.Visible = false;
            // 
            // lbl_employees
            // 
            this.lbl_employees.AutoSize = true;
            this.lbl_employees.Location = new System.Drawing.Point(583, 36);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(77, 20);
            this.lbl_employees.TabIndex = 42;
            this.lbl_employees.Text = "employees";
            this.lbl_employees.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.annual_panel);
            this.panel.Controls.Add(this.metroPanel4);
            this.panel.Controls.Add(this.metroButton1);
            this.panel.Controls.Add(this.custom_pnl);
            this.panel.Controls.Add(this.status_cmb);
            this.panel.Controls.Add(this.leavetype_cmb);
            this.panel.Controls.Add(this.duration_cmb);
            this.panel.Controls.Add(this.metroLabel6);
            this.panel.Controls.Add(this.metroLabel5);
            this.panel.Controls.Add(this.metroLabel4);
            this.panel.Controls.Add(this.metroLabel3);
            this.panel.Controls.Add(this.employee_cmb);
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(89, 106);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1130, 642);
            this.panel.TabIndex = 43;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // annual_panel
            // 
            this.annual_panel.Controls.Add(this.metroLabel1);
            this.annual_panel.Controls.Add(this.year_picker);
            this.annual_panel.HorizontalScrollbarBarColor = true;
            this.annual_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.annual_panel.HorizontalScrollbarSize = 10;
            this.annual_panel.Location = new System.Drawing.Point(329, 225);
            this.annual_panel.Name = "annual_panel";
            this.annual_panel.Size = new System.Drawing.Size(467, 138);
            this.annual_panel.TabIndex = 17;
            this.annual_panel.VerticalScrollbarBarColor = true;
            this.annual_panel.VerticalScrollbarHighlightOnWheel = false;
            this.annual_panel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Year";
            // 
            // year_picker
            // 
            this.year_picker.FormattingEnabled = true;
            this.year_picker.ItemHeight = 24;
            this.year_picker.Location = new System.Drawing.Point(105, 35);
            this.year_picker.Name = "year_picker";
            this.year_picker.Size = new System.Drawing.Size(121, 30);
            this.year_picker.TabIndex = 16;
            this.year_picker.UseSelectable = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.Controls.Add(this.txt_name);
            this.metroPanel4.Controls.Add(this.txt_empid);
            this.metroPanel4.Controls.Add(this.metroButton2);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(329, 70);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(512, 138);
            this.metroPanel4.TabIndex = 15;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 83);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(110, 20);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Employee name";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(201, 78);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(277, 25);
            this.txt_name.TabIndex = 12;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_empid
            // 
            // 
            // 
            // 
            this.txt_empid.CustomButton.Image = null;
            this.txt_empid.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txt_empid.CustomButton.Name = "";
            this.txt_empid.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_empid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empid.CustomButton.TabIndex = 1;
            this.txt_empid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empid.CustomButton.UseSelectable = true;
            this.txt_empid.CustomButton.Visible = false;
            this.txt_empid.Lines = new string[0];
            this.txt_empid.Location = new System.Drawing.Point(201, 37);
            this.txt_empid.MaxLength = 32767;
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.PasswordChar = '\0';
            this.txt_empid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empid.SelectedText = "";
            this.txt_empid.SelectionLength = 0;
            this.txt_empid.SelectionStart = 0;
            this.txt_empid.ShortcutsEnabled = true;
            this.txt_empid.Size = new System.Drawing.Size(145, 25);
            this.txt_empid.TabIndex = 11;
            this.txt_empid.UseSelectable = true;
            this.txt_empid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(378, 37);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 25);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Find";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 42);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(86, 20);
            this.metroLabel10.TabIndex = 8;
            this.metroLabel10.Text = "Employee Id";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(861, 469);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 33);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Create";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // custom_pnl
            // 
            this.custom_pnl.Controls.Add(this.end_date);
            this.custom_pnl.Controls.Add(this.start_date);
            this.custom_pnl.Controls.Add(this.metroLabel8);
            this.custom_pnl.Controls.Add(this.metroLabel7);
            this.custom_pnl.HorizontalScrollbarBarColor = true;
            this.custom_pnl.HorizontalScrollbarHighlightOnWheel = false;
            this.custom_pnl.HorizontalScrollbarSize = 10;
            this.custom_pnl.Location = new System.Drawing.Point(329, 224);
            this.custom_pnl.Name = "custom_pnl";
            this.custom_pnl.Size = new System.Drawing.Size(467, 138);
            this.custom_pnl.TabIndex = 14;
            this.custom_pnl.VerticalScrollbarBarColor = true;
            this.custom_pnl.VerticalScrollbarHighlightOnWheel = false;
            this.custom_pnl.VerticalScrollbarSize = 10;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(108, 73);
            this.end_date.MinimumSize = new System.Drawing.Size(4, 30);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(318, 30);
            this.end_date.TabIndex = 11;
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(108, 27);
            this.start_date.MinimumSize = new System.Drawing.Size(4, 30);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(318, 30);
            this.start_date.TabIndex = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(36, 37);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 20);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "From";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(36, 83);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(23, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "To";
            // 
            // status_cmb
            // 
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.ItemHeight = 24;
            this.status_cmb.Location = new System.Drawing.Point(75, 472);
            this.status_cmb.Name = "status_cmb";
            this.status_cmb.Size = new System.Drawing.Size(206, 30);
            this.status_cmb.TabIndex = 12;
            this.status_cmb.UseSelectable = true;
            this.status_cmb.SelectedIndexChanged += new System.EventHandler(this.status_cmb_SelectedIndexChanged);
            // 
            // leavetype_cmb
            // 
            this.leavetype_cmb.FormattingEnabled = true;
            this.leavetype_cmb.ItemHeight = 24;
            this.leavetype_cmb.Location = new System.Drawing.Point(75, 397);
            this.leavetype_cmb.Name = "leavetype_cmb";
            this.leavetype_cmb.Size = new System.Drawing.Size(206, 30);
            this.leavetype_cmb.TabIndex = 11;
            this.leavetype_cmb.UseSelectable = true;
            this.leavetype_cmb.SelectedIndexChanged += new System.EventHandler(this.leavetype_cmb_SelectedIndexChanged);
            // 
            // duration_cmb
            // 
            this.duration_cmb.FormattingEnabled = true;
            this.duration_cmb.ItemHeight = 24;
            this.duration_cmb.Location = new System.Drawing.Point(75, 270);
            this.duration_cmb.Name = "duration_cmb";
            this.duration_cmb.Size = new System.Drawing.Size(206, 30);
            this.duration_cmb.TabIndex = 10;
            this.duration_cmb.UseSelectable = true;
            this.duration_cmb.SelectedIndexChanged += new System.EventHandler(this.duration_cmb_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(75, 449);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 20);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Status";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(75, 374);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Leave Type";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(75, 243);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Duration";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(75, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Employees";
            // 
            // employee_cmb
            // 
            this.employee_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_cmb.FormattingEnabled = true;
            this.employee_cmb.ItemHeight = 24;
            this.employee_cmb.Location = new System.Drawing.Point(75, 111);
            this.employee_cmb.Name = "employee_cmb";
            this.employee_cmb.Size = new System.Drawing.Size(206, 30);
            this.employee_cmb.TabIndex = 5;
            this.employee_cmb.UseSelectable = true;
            this.employee_cmb.SelectedIndexChanged += new System.EventHandler(this.employee_cmb_SelectedIndexChanged);
            // 
            // pnl_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_employees);
            this.Controls.Add(this.lbl_empid);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_leave_type);
            this.Controls.Add(this.label1);
            this.Name = "pnl_report";
            this.Size = new System.Drawing.Size(1285, 844);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_leave_type, 0);
            this.Controls.SetChildIndex(this.lbl_status, 0);
            this.Controls.SetChildIndex(this.lbl_department, 0);
            this.Controls.SetChildIndex(this.lbl_empid, 0);
            this.Controls.SetChildIndex(this.lbl_employees, 0);
            this.Controls.SetChildIndex(this.panel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.leavemanagementDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_managementDataSet3)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.annual_panel.ResumeLayout(false);
            this.annual_panel.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.custom_pnl.ResumeLayout(false);
            this.custom_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource leavemanagementDataSet3BindingSource;
        private leave_managementDataSet3 leave_managementDataSet3;
        private MetroFramework.Controls.MetroLabel lbl_leave_type;
        private MetroFramework.Controls.MetroLabel lbl_status;
        private MetroFramework.Controls.MetroLabel lbl_department;
        private MetroFramework.Controls.MetroLabel lbl_empid;
        private MetroFramework.Controls.MetroLabel lbl_employees;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroTextBox txt_empid;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel custom_pnl;
        private MetroFramework.Controls.MetroDateTime end_date;
        private MetroFramework.Controls.MetroDateTime start_date;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox status_cmb;
        private MetroFramework.Controls.MetroComboBox leavetype_cmb;
        private MetroFramework.Controls.MetroComboBox duration_cmb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroComboBox employee_cmb;
        private MetroFramework.Controls.MetroComboBox year_picker;
        private MetroFramework.Controls.MetroPanel annual_panel;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}
