namespace EmpLog
{
    partial class EditEmployeeUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.set_active_btn = new System.Windows.Forms.Button();
            this.remove_row_btn = new System.Windows.Forms.Button();
            this.add_row_btn = new System.Windows.Forms.Button();
            this.remove_employee_btn = new System.Windows.Forms.Button();
            this.show_password_cb = new System.Windows.Forms.CheckBox();
            this.employee_numbers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.exit_employee_btn = new System.Windows.Forms.Button();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.is_admin_cb = new System.Windows.Forms.CheckBox();
            this.rfid_txtbx = new System.Windows.Forms.MaskedTextBox();
            this.rfid_lbl = new System.Windows.Forms.Label();
            this.first_name_lbl = new System.Windows.Forms.Label();
            this.first_name_txtbx = new System.Windows.Forms.TextBox();
            this.last_name_lbl = new System.Windows.Forms.Label();
            this.last_name_txtbx = new System.Windows.Forms.TextBox();
            this.employee_submit_btn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_numbers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.set_active_btn);
            this.panel1.Controls.Add(this.remove_row_btn);
            this.panel1.Controls.Add(this.add_row_btn);
            this.panel1.Controls.Add(this.remove_employee_btn);
            this.panel1.Controls.Add(this.show_password_cb);
            this.panel1.Controls.Add(this.employee_numbers);
            this.panel1.Controls.Add(this.exit_employee_btn);
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.password_txtbx);
            this.panel1.Controls.Add(this.is_admin_cb);
            this.panel1.Controls.Add(this.rfid_txtbx);
            this.panel1.Controls.Add(this.rfid_lbl);
            this.panel1.Controls.Add(this.first_name_lbl);
            this.panel1.Controls.Add(this.first_name_txtbx);
            this.panel1.Controls.Add(this.last_name_lbl);
            this.panel1.Controls.Add(this.last_name_txtbx);
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(480, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 379);
            this.panel1.TabIndex = 16;
            // 
            // set_active_btn
            // 
            this.set_active_btn.Location = new System.Drawing.Point(286, 349);
            this.set_active_btn.Name = "set_active_btn";
            this.set_active_btn.Size = new System.Drawing.Size(141, 23);
            this.set_active_btn.TabIndex = 28;
            this.set_active_btn.Text = "Set Active";
            this.set_active_btn.UseVisualStyleBackColor = true;
            this.set_active_btn.Visible = false;
            this.set_active_btn.Click += new System.EventHandler(this.set_active_btn_Click);
            // 
            // remove_row_btn
            // 
            this.remove_row_btn.Location = new System.Drawing.Point(50, 194);
            this.remove_row_btn.Name = "remove_row_btn";
            this.remove_row_btn.Size = new System.Drawing.Size(22, 23);
            this.remove_row_btn.TabIndex = 26;
            this.remove_row_btn.Text = "-";
            this.remove_row_btn.UseVisualStyleBackColor = true;
            this.remove_row_btn.Click += new System.EventHandler(this.remove_number_btn_Click);
            // 
            // add_row_btn
            // 
            this.add_row_btn.Location = new System.Drawing.Point(22, 194);
            this.add_row_btn.Name = "add_row_btn";
            this.add_row_btn.Size = new System.Drawing.Size(22, 23);
            this.add_row_btn.TabIndex = 25;
            this.add_row_btn.Text = "+";
            this.add_row_btn.UseVisualStyleBackColor = true;
            this.add_row_btn.Click += new System.EventHandler(this.add_row_btn_Click);
            // 
            // remove_employee_btn
            // 
            this.remove_employee_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_employee_btn.Location = new System.Drawing.Point(286, 349);
            this.remove_employee_btn.Name = "remove_employee_btn";
            this.remove_employee_btn.Size = new System.Drawing.Size(141, 23);
            this.remove_employee_btn.TabIndex = 15;
            this.remove_employee_btn.TabStop = false;
            this.remove_employee_btn.Text = "Remove Employee";
            this.remove_employee_btn.UseVisualStyleBackColor = true;
            this.remove_employee_btn.Click += new System.EventHandler(this.remove_employee_btn_Click);
            // 
            // show_password_cb
            // 
            this.show_password_cb.AutoSize = true;
            this.show_password_cb.Location = new System.Drawing.Point(247, 203);
            this.show_password_cb.Name = "show_password_cb";
            this.show_password_cb.Size = new System.Drawing.Size(129, 21);
            this.show_password_cb.TabIndex = 21;
            this.show_password_cb.Text = "Show Password";
            this.show_password_cb.UseVisualStyleBackColor = true;
            this.show_password_cb.Visible = false;
            this.show_password_cb.CheckedChanged += new System.EventHandler(this.show_password_cb_CheckedChanged);
            // 
            // employee_numbers
            // 
            this.employee_numbers.AllowUserToAddRows = false;
            this.employee_numbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employee_numbers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employee_numbers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employee_numbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_numbers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.employee_numbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_numbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EID,
            this.number,
            this.type});
            this.employee_numbers.EnableHeadersVisualStyles = false;
            this.employee_numbers.Location = new System.Drawing.Point(22, 228);
            this.employee_numbers.Margin = new System.Windows.Forms.Padding(8);
            this.employee_numbers.MultiSelect = false;
            this.employee_numbers.Name = "employee_numbers";
            this.employee_numbers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employee_numbers.RowHeadersWidth = 25;
            this.employee_numbers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.employee_numbers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.employee_numbers.RowTemplate.Height = 24;
            this.employee_numbers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employee_numbers.Size = new System.Drawing.Size(195, 116);
            this.employee_numbers.TabIndex = 22;
            this.employee_numbers.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.employee_numbers_UserDeletedRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "EID";
            this.EID.Name = "EID";
            this.EID.Visible = false;
            this.EID.Width = 55;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            dataGridViewCellStyle1.Format = "(   )   -   -";
            this.number.DefaultCellStyle = dataGridViewCellStyle1;
            this.number.HeaderText = "Number";
            this.number.Mask = "(999) 000-0000";
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.number.Width = 83;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.type.HeaderText = "Type";
            this.type.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Fax",
            "Other..."});
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.type.Width = 65;
            // 
            // exit_employee_btn
            // 
            this.exit_employee_btn.BackColor = System.Drawing.Color.Red;
            this.exit_employee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_employee_btn.Location = new System.Drawing.Point(372, -2);
            this.exit_employee_btn.Name = "exit_employee_btn";
            this.exit_employee_btn.Size = new System.Drawing.Size(32, 23);
            this.exit_employee_btn.TabIndex = 24;
            this.exit_employee_btn.TabStop = false;
            this.exit_employee_btn.Text = "X";
            this.exit_employee_btn.UseVisualStyleBackColor = false;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(19, 203);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(69, 17);
            this.password_lbl.TabIndex = 22;
            this.password_lbl.Text = "Password";
            this.password_lbl.Visible = false;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(101, 202);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(140, 22);
            this.password_txtbx.TabIndex = 20;
            this.password_txtbx.UseSystemPasswordChar = true;
            this.password_txtbx.Visible = false;
            // 
            // is_admin_cb
            // 
            this.is_admin_cb.AutoSize = true;
            this.is_admin_cb.Location = new System.Drawing.Point(22, 159);
            this.is_admin_cb.Name = "is_admin_cb";
            this.is_admin_cb.Size = new System.Drawing.Size(83, 21);
            this.is_admin_cb.TabIndex = 19;
            this.is_admin_cb.Text = "Is Admin";
            this.is_admin_cb.UseVisualStyleBackColor = true;
            this.is_admin_cb.CheckedChanged += new System.EventHandler(this.is_admin_cb_CheckedChanged);
            // 
            // rfid_txtbx
            // 
            this.rfid_txtbx.Location = new System.Drawing.Point(101, 14);
            this.rfid_txtbx.Mask = "0000000000";
            this.rfid_txtbx.Name = "rfid_txtbx";
            this.rfid_txtbx.Size = new System.Drawing.Size(140, 22);
            this.rfid_txtbx.TabIndex = 16;
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.Location = new System.Drawing.Point(19, 19);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(39, 17);
            this.rfid_lbl.TabIndex = 10;
            this.rfid_lbl.Text = "RFID";
            // 
            // first_name_lbl
            // 
            this.first_name_lbl.AutoSize = true;
            this.first_name_lbl.Location = new System.Drawing.Point(19, 70);
            this.first_name_lbl.Name = "first_name_lbl";
            this.first_name_lbl.Size = new System.Drawing.Size(76, 17);
            this.first_name_lbl.TabIndex = 0;
            this.first_name_lbl.Text = "First Name";
            // 
            // first_name_txtbx
            // 
            this.first_name_txtbx.Location = new System.Drawing.Point(101, 65);
            this.first_name_txtbx.Name = "first_name_txtbx";
            this.first_name_txtbx.Size = new System.Drawing.Size(140, 22);
            this.first_name_txtbx.TabIndex = 5;
            // 
            // last_name_lbl
            // 
            this.last_name_lbl.AutoSize = true;
            this.last_name_lbl.Location = new System.Drawing.Point(19, 117);
            this.last_name_lbl.Name = "last_name_lbl";
            this.last_name_lbl.Size = new System.Drawing.Size(76, 17);
            this.last_name_lbl.TabIndex = 1;
            this.last_name_lbl.Text = "Last Name";
            // 
            // last_name_txtbx
            // 
            this.last_name_txtbx.Location = new System.Drawing.Point(101, 112);
            this.last_name_txtbx.Name = "last_name_txtbx";
            this.last_name_txtbx.Size = new System.Drawing.Size(140, 22);
            this.last_name_txtbx.TabIndex = 5;
            // 
            // employee_submit_btn
            // 
            this.employee_submit_btn.Location = new System.Drawing.Point(175, 400);
            this.employee_submit_btn.Name = "employee_submit_btn";
            this.employee_submit_btn.Size = new System.Drawing.Size(133, 23);
            this.employee_submit_btn.TabIndex = 15;
            this.employee_submit_btn.TabStop = false;
            this.employee_submit_btn.Text = "Submit";
            this.employee_submit_btn.UseVisualStyleBackColor = true;
            this.employee_submit_btn.Click += new System.EventHandler(this.employee_submit_btn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // EditEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employee_submit_btn);
            this.Name = "EditEmployeeUserControl";
            this.Size = new System.Drawing.Size(457, 426);
            this.Load += new System.EventHandler(this.EditEmployeeUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_numbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label rfid_lbl;
        private System.Windows.Forms.Label first_name_lbl;
        private System.Windows.Forms.Label last_name_lbl;
        private System.Windows.Forms.CheckBox show_password_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button add_row_btn;
        private System.Windows.Forms.Button remove_row_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private JThomas.Controls.DataGridViewMaskedTextColumn number;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.MaskedTextBox rfid_txtbx;
        private System.Windows.Forms.TextBox first_name_txtbx;
        private System.Windows.Forms.TextBox last_name_txtbx;
        private System.Windows.Forms.Button employee_submit_btn;
        private System.Windows.Forms.CheckBox is_admin_cb;
        private System.Windows.Forms.Button remove_employee_btn;
        private System.Windows.Forms.DataGridView employee_numbers;
        private System.Windows.Forms.Button exit_employee_btn;
        private System.Windows.Forms.Button set_active_btn;
    }
}
