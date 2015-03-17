namespace EmpLog
{
    partial class EmployeeHistoryUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.create_history_record_btn = new System.Windows.Forms.Button();
            this.end_date_lbl = new System.Windows.Forms.Label();
            this.start_date_lbl = new System.Windows.Forms.Label();
            this.end_date_txtbx = new System.Windows.Forms.DateTimePicker();
            this.start_date_txtbx = new System.Windows.Forms.DateTimePicker();
            this.history_background_panel = new System.Windows.Forms.Panel();
            this.employee_records_data_grid = new System.Windows.Forms.DataGridView();
            this.eId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new DataGridViewDateTimePicker();
            this.Time = new DataGridViewTimePicker();
            this.In_Out = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_record_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDateTimePicker1 = new DataGridViewDateTimePicker();
            this.dataGridViewDateTimePicker2 = new DataGridViewDateTimePicker();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDatePickerColumn1 = new DataGridViewDateTimePicker();
            this.dataGridViewDatePickerColumn2 = new DataGridViewDateTimePicker();
            this.calendarColumn1 = new DataGridViewDateTimePicker();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history_background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_records_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // create_history_record_btn
            // 
            this.create_history_record_btn.Location = new System.Drawing.Point(487, 27);
            this.create_history_record_btn.Name = "create_history_record_btn";
            this.create_history_record_btn.Size = new System.Drawing.Size(120, 23);
            this.create_history_record_btn.TabIndex = 11;
            this.create_history_record_btn.Text = "Create Record";
            this.create_history_record_btn.UseVisualStyleBackColor = true;
            this.create_history_record_btn.Click += new System.EventHandler(this.create_history_record_btn_Click);
            // 
            // end_date_lbl
            // 
            this.end_date_lbl.AutoSize = true;
            this.end_date_lbl.Location = new System.Drawing.Point(241, 3);
            this.end_date_lbl.Name = "end_date_lbl";
            this.end_date_lbl.Size = new System.Drawing.Size(67, 17);
            this.end_date_lbl.TabIndex = 10;
            this.end_date_lbl.Text = "End Date";
            // 
            // start_date_lbl
            // 
            this.start_date_lbl.AutoSize = true;
            this.start_date_lbl.Location = new System.Drawing.Point(9, 3);
            this.start_date_lbl.Name = "start_date_lbl";
            this.start_date_lbl.Size = new System.Drawing.Size(72, 17);
            this.start_date_lbl.TabIndex = 9;
            this.start_date_lbl.Text = "Start Date";
            // 
            // end_date_txtbx
            // 
            this.end_date_txtbx.Location = new System.Drawing.Point(261, 28);
            this.end_date_txtbx.Name = "end_date_txtbx";
            this.end_date_txtbx.Size = new System.Drawing.Size(200, 22);
            this.end_date_txtbx.TabIndex = 8;
            this.end_date_txtbx.ValueChanged += new System.EventHandler(this.end_date_txtbx_ValueChanged);
            // 
            // start_date_txtbx
            // 
            this.start_date_txtbx.Location = new System.Drawing.Point(12, 28);
            this.start_date_txtbx.Name = "start_date_txtbx";
            this.start_date_txtbx.Size = new System.Drawing.Size(200, 22);
            this.start_date_txtbx.TabIndex = 7;
            this.start_date_txtbx.ValueChanged += new System.EventHandler(this.start_date_txtbx_ValueChanged);
            // 
            // history_background_panel
            // 
            this.history_background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.history_background_panel.Controls.Add(this.employee_records_data_grid);
            this.history_background_panel.Location = new System.Drawing.Point(12, 59);
            this.history_background_panel.Name = "history_background_panel";
            this.history_background_panel.Size = new System.Drawing.Size(726, 422);
            this.history_background_panel.TabIndex = 12;
            // 
            // employee_records_data_grid
            // 
            this.employee_records_data_grid.AllowUserToAddRows = false;
            this.employee_records_data_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employee_records_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_records_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_records_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eId,
            this.aId,
            this.Employee_Name,
            this.Date,
            this.Time,
            this.In_Out,
            this.Total_Time});
            this.employee_records_data_grid.Location = new System.Drawing.Point(-2, -2);
            this.employee_records_data_grid.MultiSelect = false;
            this.employee_records_data_grid.Name = "employee_records_data_grid";
            this.employee_records_data_grid.RowTemplate.Height = 24;
            this.employee_records_data_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employee_records_data_grid.Size = new System.Drawing.Size(721, 424);
            this.employee_records_data_grid.TabIndex = 0;
            this.employee_records_data_grid.Visible = false;
            this.employee_records_data_grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_records_data_grid_CellValueChanged);
            this.employee_records_data_grid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.employee_records_data_grid_UserDeletedRow);
            // 
            // eId
            // 
            this.eId.HeaderText = "eId";
            this.eId.Name = "eId";
            this.eId.Visible = false;
            // 
            // aId
            // 
            this.aId.HeaderText = "aId";
            this.aId.Name = "aId";
            this.aId.Visible = false;
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employee_Name.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.Width = 225;
            // 
            // Time
            // 
            dataGridViewCellStyle4.Format = "T";
            this.Time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // In_Out
            // 
            this.In_Out.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.In_Out.HeaderText = "In/Out";
            this.In_Out.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.In_Out.Name = "In_Out";
            this.In_Out.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.In_Out.Width = 75;
            // 
            // Total_Time
            // 
            this.Total_Time.HeaderText = "Total_Time";
            this.Total_Time.Name = "Total_Time";
            this.Total_Time.ReadOnly = true;
            this.Total_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total_Time.Width = 115;
            // 
            // show_record_btn
            // 
            this.show_record_btn.Location = new System.Drawing.Point(613, 27);
            this.show_record_btn.Name = "show_record_btn";
            this.show_record_btn.Size = new System.Drawing.Size(120, 23);
            this.show_record_btn.TabIndex = 14;
            this.show_record_btn.Text = "Show Records";
            this.show_record_btn.UseVisualStyleBackColor = true;
            this.show_record_btn.Click += new System.EventHandler(this.show_record_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(12, 480);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(726, 23);
            this.reset_btn.TabIndex = 15;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "eId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "aId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewDateTimePicker1
            // 
            this.dataGridViewDateTimePicker1.HeaderText = "Date";
            this.dataGridViewDateTimePicker1.Name = "dataGridViewDateTimePicker1";
            this.dataGridViewDateTimePicker1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDateTimePicker1.Width = 225;
            // 
            // dataGridViewDateTimePicker2
            // 
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewDateTimePicker2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDateTimePicker2.HeaderText = "Time";
            this.dataGridViewDateTimePicker2.Name = "dataGridViewDateTimePicker2";
            this.dataGridViewDateTimePicker2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewDatePickerColumn1
            // 
            this.dataGridViewDatePickerColumn1.HeaderText = "Date";
            this.dataGridViewDatePickerColumn1.Name = "dataGridViewDatePickerColumn1";
            this.dataGridViewDatePickerColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDatePickerColumn1.Width = 225;
            // 
            // dataGridViewDatePickerColumn2
            // 
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewDatePickerColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDatePickerColumn2.HeaderText = "Time";
            this.dataGridViewDatePickerColumn2.Name = "dataGridViewDatePickerColumn2";
            this.dataGridViewDatePickerColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.HeaderText = "Date";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total_Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // EmployeeHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.start_date_txtbx);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.show_record_btn);
            this.Controls.Add(this.create_history_record_btn);
            this.Controls.Add(this.end_date_lbl);
            this.Controls.Add(this.start_date_lbl);
            this.Controls.Add(this.end_date_txtbx);
            this.Controls.Add(this.history_background_panel);
            this.Name = "EmployeeHistoryUserControl";
            this.Size = new System.Drawing.Size(752, 521);
             this.history_background_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employee_records_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_history_record_btn;
        private System.Windows.Forms.Label end_date_lbl;
        private System.Windows.Forms.Label start_date_lbl;
        private System.Windows.Forms.DateTimePicker end_date_txtbx;
        public System.Windows.Forms.DateTimePicker start_date_txtbx;
        private System.Windows.Forms.Panel history_background_panel;
        private System.Windows.Forms.DataGridView employee_records_data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewDateTimePicker calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button show_record_btn;
        private System.Windows.Forms.Button reset_btn;
        private DataGridViewDateTimePicker dataGridViewDatePickerColumn1;
        private DataGridViewDateTimePicker dataGridViewDatePickerColumn2;
        private DataGridViewDateTimePicker dataGridViewDateTimePicker1;
        private DataGridViewDateTimePicker dataGridViewDateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eId;
        private System.Windows.Forms.DataGridViewTextBoxColumn aId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private DataGridViewDateTimePicker Date;
        private DataGridViewTimePicker Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn In_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Time;
    }
}
