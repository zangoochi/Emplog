namespace EmpLog
{
    partial class GetEmployeeUserControl
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
            this.employee_lookup_btn = new System.Windows.Forms.Button();
            this.rfid_txtbx = new System.Windows.Forms.MaskedTextBox();
            this.rfid_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rfid_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_lookup_btn
            // 
            this.employee_lookup_btn.Location = new System.Drawing.Point(8, 75);
            this.employee_lookup_btn.Name = "employee_lookup_btn";
            this.employee_lookup_btn.Size = new System.Drawing.Size(291, 33);
            this.employee_lookup_btn.TabIndex = 24;
            this.employee_lookup_btn.Text = "Employee Lookup";
            this.employee_lookup_btn.UseVisualStyleBackColor = true;
            this.employee_lookup_btn.Click += new System.EventHandler(this.employee_lookup_btn_Click);
            // 
            // rfid_txtbx
            // 
            this.rfid_txtbx.Location = new System.Drawing.Point(130, 22);
            this.rfid_txtbx.Name = "rfid_txtbx";
            this.rfid_txtbx.Size = new System.Drawing.Size(100, 22);
            this.rfid_txtbx.TabIndex = 22;
            this.rfid_txtbx.TextChanged += new System.EventHandler(this.rfid_txtbx_TextChanged);
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.Location = new System.Drawing.Point(48, 27);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(39, 17);
            this.rfid_lbl.TabIndex = 21;
            this.rfid_lbl.Text = "RFID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rfid_error);
            this.panel1.Location = new System.Drawing.Point(51, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 43);
            this.panel1.TabIndex = 23;
            // 
            // rfid_error
            // 
            this.rfid_error.AutoSize = true;
            this.rfid_error.ForeColor = System.Drawing.Color.Red;
            this.rfid_error.Location = new System.Drawing.Point(103, 24);
            this.rfid_error.Name = "rfid_error";
            this.rfid_error.Size = new System.Drawing.Size(105, 17);
            this.rfid_error.TabIndex = 18;
            this.rfid_error.Text = "No RFID Found";
            this.rfid_error.Visible = false;
            // 
            // GetEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employee_lookup_btn);
            this.Controls.Add(this.rfid_txtbx);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.panel1);
            this.Name = "GetEmployeeUserControl";
            this.Size = new System.Drawing.Size(312, 126);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employee_lookup_btn;
        private System.Windows.Forms.Label rfid_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rfid_error;
        private System.Windows.Forms.MaskedTextBox rfid_txtbx;
    }
}
