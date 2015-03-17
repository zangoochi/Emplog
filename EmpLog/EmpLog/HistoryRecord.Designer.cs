namespace EmpLog
{
    partial class HistoryRecordForm
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.in_out_lbl = new System.Windows.Forms.Label();
            this.name_cbx = new System.Windows.Forms.ComboBox();
            this.time_picker_txtbx = new System.Windows.Forms.DateTimePicker();
            this.date_picker_txtbx = new System.Windows.Forms.DateTimePicker();
            this.in_out_cbx = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(13, 13);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(45, 17);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(14, 61);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(38, 17);
            this.date_lbl.TabIndex = 2;
            this.date_lbl.Text = "Date";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(12, 94);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(39, 17);
            this.time_lbl.TabIndex = 3;
            this.time_lbl.Text = "Time";
            // 
            // in_out_lbl
            // 
            this.in_out_lbl.AutoSize = true;
            this.in_out_lbl.Location = new System.Drawing.Point(13, 139);
            this.in_out_lbl.Name = "in_out_lbl";
            this.in_out_lbl.Size = new System.Drawing.Size(46, 17);
            this.in_out_lbl.TabIndex = 4;
            this.in_out_lbl.Text = "In/Out";
            // 
            // name_cbx
            // 
            this.name_cbx.FormattingEnabled = true;
            this.name_cbx.Location = new System.Drawing.Point(65, 13);
            this.name_cbx.Name = "name_cbx";
            this.name_cbx.Size = new System.Drawing.Size(184, 24);
            this.name_cbx.TabIndex = 5;
            // 
            // time_picker_txtbx
            // 
            this.time_picker_txtbx.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_picker_txtbx.Location = new System.Drawing.Point(65, 94);
            this.time_picker_txtbx.Name = "time_picker_txtbx";
            this.time_picker_txtbx.ShowUpDown = true;
            this.time_picker_txtbx.Size = new System.Drawing.Size(110, 22);
            this.time_picker_txtbx.TabIndex = 6;
            // 
            // date_picker_txtbx
            // 
            this.date_picker_txtbx.Location = new System.Drawing.Point(74, 55);
            this.date_picker_txtbx.Name = "date_picker_txtbx";
            this.date_picker_txtbx.Size = new System.Drawing.Size(245, 22);
            this.date_picker_txtbx.TabIndex = 7;
            // 
            // in_out_cbx
            // 
            this.in_out_cbx.FormattingEnabled = true;
            this.in_out_cbx.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.in_out_cbx.Location = new System.Drawing.Point(74, 139);
            this.in_out_cbx.Name = "in_out_cbx";
            this.in_out_cbx.Size = new System.Drawing.Size(101, 24);
            this.in_out_cbx.TabIndex = 8;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(88, 194);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(134, 23);
            this.submit_btn.TabIndex = 9;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(65, 171);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 17);
            this.error_lbl.TabIndex = 10;
            // 
            // HistoryRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 246);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.in_out_cbx);
            this.Controls.Add(this.date_picker_txtbx);
            this.Controls.Add(this.time_picker_txtbx);
            this.Controls.Add(this.name_cbx);
            this.Controls.Add(this.in_out_lbl);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "HistoryRecordForm";
            this.Text = "HistoryRecord";
            this.Load += new System.EventHandler(this.HistoryRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label in_out_lbl;
        private System.Windows.Forms.ComboBox name_cbx;
        private System.Windows.Forms.DateTimePicker time_picker_txtbx;
        private System.Windows.Forms.DateTimePicker date_picker_txtbx;
        private System.Windows.Forms.ComboBox in_out_cbx;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label error_lbl;
    }
}