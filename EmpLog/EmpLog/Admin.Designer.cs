namespace EmpLog
{
    partial class AdminForm
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
            this.admin_tabs = new System.Windows.Forms.TabControl();
            this.create_employee_page = new System.Windows.Forms.TabPage();
            this.edit_employee_page = new System.Windows.Forms.TabPage();
            this.employeeId_lbl = new System.Windows.Forms.Label();
            this.employee_history_page = new System.Windows.Forms.TabPage();
            this.admin_tabs.SuspendLayout();
            this.edit_employee_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_tabs
            // 
            this.admin_tabs.Controls.Add(this.create_employee_page);
            this.admin_tabs.Controls.Add(this.edit_employee_page);
            this.admin_tabs.Controls.Add(this.employee_history_page);
            this.admin_tabs.Location = new System.Drawing.Point(12, 12);
            this.admin_tabs.Name = "admin_tabs";
            this.admin_tabs.SelectedIndex = 0;
            this.admin_tabs.Size = new System.Drawing.Size(767, 562);
            this.admin_tabs.TabIndex = 0;
            // 
            // create_employee_page
            // 
            this.create_employee_page.Location = new System.Drawing.Point(4, 25);
            this.create_employee_page.Name = "create_employee_page";
            this.create_employee_page.Padding = new System.Windows.Forms.Padding(3);
            this.create_employee_page.Size = new System.Drawing.Size(759, 533);
            this.create_employee_page.TabIndex = 3;
            this.create_employee_page.Text = "New Employee";
            // 
            // edit_employee_page
            // 
            this.edit_employee_page.Controls.Add(this.employeeId_lbl);
            this.edit_employee_page.Location = new System.Drawing.Point(4, 25);
            this.edit_employee_page.Name = "edit_employee_page";
            this.edit_employee_page.Padding = new System.Windows.Forms.Padding(3);
            this.edit_employee_page.Size = new System.Drawing.Size(759, 533);
            this.edit_employee_page.TabIndex = 1;
            this.edit_employee_page.Text = "Edit Employee";
            // 
            // employeeId_lbl
            // 
            this.employeeId_lbl.AutoSize = true;
            this.employeeId_lbl.Location = new System.Drawing.Point(14, -15);
            this.employeeId_lbl.Name = "employeeId_lbl";
            this.employeeId_lbl.Size = new System.Drawing.Size(0, 17);
            this.employeeId_lbl.TabIndex = 17;
            this.employeeId_lbl.Visible = false;
            // 
            // employee_history_page
            // 
            this.employee_history_page.Location = new System.Drawing.Point(4, 25);
            this.employee_history_page.Name = "employee_history_page";
            this.employee_history_page.Padding = new System.Windows.Forms.Padding(3);
            this.employee_history_page.Size = new System.Drawing.Size(759, 533);
            this.employee_history_page.TabIndex = 2;
            this.employee_history_page.Text = "Employee History";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 583);
            this.Controls.Add(this.admin_tabs);
            this.Name = "AdminForm";
            this.Text = " ";
            this.admin_tabs.ResumeLayout(false);
            this.edit_employee_page.ResumeLayout(false);
            this.edit_employee_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admin_tabs;
        private System.Windows.Forms.TabPage edit_employee_page;
        private System.Windows.Forms.TabPage employee_history_page;
        public System.Windows.Forms.Label employeeId_lbl;
        private System.Windows.Forms.TabPage create_employee_page;
    }
}