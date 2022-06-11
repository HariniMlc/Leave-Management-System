namespace LMS_Project
{
    partial class pnl_authorize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sender_emp_id = new MetroFramework.Controls.MetroLabel();
            this.lbl_sender_email = new MetroFramework.Controls.MetroLabel();
            this.lbl_email = new MetroFramework.Controls.MetroLabel();
            this.lbl_post = new MetroFramework.Controls.MetroLabel();
            this.lbl_leave_id = new MetroFramework.Controls.MetroLabel();
            this.lbl_emp_id = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lbl_name = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.leave_managementDataSet = new LMS_Project.leave_managementDataSet();
            this.leavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leavesTableAdapter = new LMS_Project.leave_managementDataSetTableAdapters.leavesTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.leave_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.email_password_lbl = new MetroFramework.Controls.MetroLabel();
            this.lbl_emp_name = new MetroFramework.Controls.MetroLabel();
            this.lbl_from = new MetroFramework.Controls.MetroLabel();
            this.lbl_to = new MetroFramework.Controls.MetroLabel();
            this.lbl_leave_type = new MetroFramework.Controls.MetroLabel();
            this.work_years_lbl = new MetroFramework.Controls.MetroLabel();
            this.lbl_joined_date = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.leave_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sender_emp_id
            // 
            this.sender_emp_id.AutoSize = true;
            this.sender_emp_id.Location = new System.Drawing.Point(934, 19);
            this.sender_emp_id.Name = "sender_emp_id";
            this.sender_emp_id.Size = new System.Drawing.Size(109, 20);
            this.sender_emp_id.TabIndex = 41;
            this.sender_emp_id.Text = "sender\'s emp_id";
            // 
            // lbl_sender_email
            // 
            this.lbl_sender_email.AutoSize = true;
            this.lbl_sender_email.Location = new System.Drawing.Point(772, 19);
            this.lbl_sender_email.Name = "lbl_sender_email";
            this.lbl_sender_email.Size = new System.Drawing.Size(52, 20);
            this.lbl_sender_email.TabIndex = 40;
            this.lbl_sender_email.Text = "sender";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(593, 22);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 20);
            this.lbl_email.TabIndex = 39;
            this.lbl_email.Text = "email";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Location = new System.Drawing.Point(593, 50);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(34, 20);
            this.lbl_post.TabIndex = 38;
            this.lbl_post.Text = "Post";
            // 
            // lbl_leave_id
            // 
            this.lbl_leave_id.AutoSize = true;
            this.lbl_leave_id.Location = new System.Drawing.Point(772, 50);
            this.lbl_leave_id.Name = "lbl_leave_id";
            this.lbl_leave_id.Size = new System.Drawing.Size(63, 20);
            this.lbl_leave_id.TabIndex = 37;
            this.lbl_leave_id.Text = "Leave ID";
            // 
            // lbl_emp_id
            // 
            this.lbl_emp_id.AutoSize = true;
            this.lbl_emp_id.Location = new System.Drawing.Point(934, 50);
            this.lbl_emp_id.Name = "lbl_emp_id";
            this.lbl_emp_id.Size = new System.Drawing.Size(54, 20);
            this.lbl_emp_id.TabIndex = 36;
            this.lbl_emp_id.Text = "emp_id";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(80, 607);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(203, 37);
            this.metroButton3.TabIndex = 35;
            this.metroButton3.Text = "Employee\'s available Leaves";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(80, 560);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(203, 37);
            this.metroButton2.TabIndex = 34;
            this.metroButton2.Text = "Employee Details";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(1072, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 20);
            this.lbl_name.TabIndex = 33;
            this.lbl_name.Text = "Name";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(807, 560);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 37);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "Authorize";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // leave_managementDataSet
            // 
            this.leave_managementDataSet.DataSetName = "leave_managementDataSet";
            this.leave_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leavesBindingSource
            // 
            this.leavesBindingSource.DataMember = "leaves";
            this.leavesBindingSource.DataSource = this.leave_managementDataSet;
            // 
            // leavesTableAdapter
            // 
            this.leavesTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leave_id,
            this.empidDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.leavesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(50, 153);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1053, 328);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.White;
            this.metroGrid1.TabIndex = 42;
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
            // 
            // leave_id
            // 
            this.leave_id.DataPropertyName = "leave_id";
            this.leave_id.HeaderText = "leave_id";
            this.leave_id.Name = "leave_id";
            this.leave_id.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth Lt BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 51);
            this.label1.TabIndex = 54;
            this.label1.Text = "Authorize Leaves";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(963, 560);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(140, 37);
            this.metroButton4.TabIndex = 55;
            this.metroButton4.Text = "Reject";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // email_password_lbl
            // 
            this.email_password_lbl.AutoSize = true;
            this.email_password_lbl.Location = new System.Drawing.Point(934, 81);
            this.email_password_lbl.Name = "email_password_lbl";
            this.email_password_lbl.Size = new System.Drawing.Size(159, 20);
            this.email_password_lbl.TabIndex = 56;
            this.email_password_lbl.Text = "sender\'s email password";
            this.email_password_lbl.Visible = false;
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Location = new System.Drawing.Point(313, 560);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(76, 20);
            this.lbl_emp_name.TabIndex = 57;
            this.lbl_emp_name.Text = "emp name";
            this.lbl_emp_name.Visible = false;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(313, 592);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(84, 20);
            this.lbl_from.TabIndex = 58;
            this.lbl_from.Text = "metroLabel1";
            this.lbl_from.Visible = false;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(313, 615);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(84, 20);
            this.lbl_to.TabIndex = 59;
            this.lbl_to.Text = "metroLabel1";
            this.lbl_to.Visible = false;
            // 
            // lbl_leave_type
            // 
            this.lbl_leave_type.AutoSize = true;
            this.lbl_leave_type.Location = new System.Drawing.Point(313, 647);
            this.lbl_leave_type.Name = "lbl_leave_type";
            this.lbl_leave_type.Size = new System.Drawing.Size(84, 20);
            this.lbl_leave_type.TabIndex = 60;
            this.lbl_leave_type.Text = "metroLabel1";
            this.lbl_leave_type.Visible = false;
            // 
            // work_years_lbl
            // 
            this.work_years_lbl.AutoSize = true;
            this.work_years_lbl.Location = new System.Drawing.Point(967, 120);
            this.work_years_lbl.Name = "work_years_lbl";
            this.work_years_lbl.Size = new System.Drawing.Size(84, 20);
            this.work_years_lbl.TabIndex = 61;
            this.work_years_lbl.Text = "metroLabel1";
            this.work_years_lbl.Visible = false;
            // 
            // lbl_joined_date
            // 
            this.lbl_joined_date.AutoSize = true;
            this.lbl_joined_date.Location = new System.Drawing.Point(866, 114);
            this.lbl_joined_date.Name = "lbl_joined_date";
            this.lbl_joined_date.Size = new System.Drawing.Size(84, 20);
            this.lbl_joined_date.TabIndex = 62;
            this.lbl_joined_date.Text = "metroLabel1";
            this.lbl_joined_date.Visible = false;
            // 
            // pnl_authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_joined_date);
            this.Controls.Add(this.work_years_lbl);
            this.Controls.Add(this.lbl_leave_type);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_emp_name);
            this.Controls.Add(this.email_password_lbl);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.sender_emp_id);
            this.Controls.Add(this.lbl_sender_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.lbl_leave_id);
            this.Controls.Add(this.lbl_emp_id);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.metroButton1);
            this.Name = "pnl_authorize";
            this.Size = new System.Drawing.Size(1554, 919);
            this.Controls.SetChildIndex(this.metroButton1, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.metroButton2, 0);
            this.Controls.SetChildIndex(this.metroButton3, 0);
            this.Controls.SetChildIndex(this.lbl_emp_id, 0);
            this.Controls.SetChildIndex(this.lbl_leave_id, 0);
            this.Controls.SetChildIndex(this.lbl_post, 0);
            this.Controls.SetChildIndex(this.lbl_email, 0);
            this.Controls.SetChildIndex(this.lbl_sender_email, 0);
            this.Controls.SetChildIndex(this.sender_emp_id, 0);
            this.Controls.SetChildIndex(this.metroGrid1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.metroButton4, 0);
            this.Controls.SetChildIndex(this.email_password_lbl, 0);
            this.Controls.SetChildIndex(this.lbl_emp_name, 0);
            this.Controls.SetChildIndex(this.lbl_from, 0);
            this.Controls.SetChildIndex(this.lbl_to, 0);
            this.Controls.SetChildIndex(this.lbl_leave_type, 0);
            this.Controls.SetChildIndex(this.work_years_lbl, 0);
            this.Controls.SetChildIndex(this.lbl_joined_date, 0);
            ((System.ComponentModel.ISupportInitialize)(this.leave_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel sender_emp_id;
        private MetroFramework.Controls.MetroLabel lbl_sender_email;
        private MetroFramework.Controls.MetroLabel lbl_email;
        private MetroFramework.Controls.MetroLabel lbl_post;
        private MetroFramework.Controls.MetroLabel lbl_leave_id;
        private MetroFramework.Controls.MetroLabel lbl_emp_id;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel lbl_name;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource leavesBindingSource;
        private leave_managementDataSet leave_managementDataSet;
        private leave_managementDataSetTableAdapters.leavesTableAdapter leavesTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel email_password_lbl;
        private MetroFramework.Controls.MetroLabel lbl_emp_name;
        private MetroFramework.Controls.MetroLabel lbl_from;
        private MetroFramework.Controls.MetroLabel lbl_to;
        private MetroFramework.Controls.MetroLabel lbl_leave_type;
        private MetroFramework.Controls.MetroLabel work_years_lbl;
        private MetroFramework.Controls.MetroLabel lbl_joined_date;
    }
}
