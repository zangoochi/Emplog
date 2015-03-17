namespace EmpLog
{
    partial class EmplogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmplogForm));
            this.rfid_lbl = new System.Windows.Forms.Label();
            this.rfid_txtbx = new System.Windows.Forms.MaskedTextBox();
            this.history_lbl = new System.Windows.Forms.Label();
            this.history_panel = new System.Windows.Forms.Panel();
            this.employee_lookup_btn = new System.Windows.Forms.Button();
            this.no_record_error = new System.Windows.Forms.Label();
            this.EmpLogLogo = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.history_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_lbl.Location = new System.Drawing.Point(8, 165);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(52, 24);
            this.rfid_lbl.TabIndex = 0;
            this.rfid_lbl.Text = "RFID";
            // 
            // rfid_txtbx
            // 
            this.rfid_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txtbx.Location = new System.Drawing.Point(62, 162);
            this.rfid_txtbx.Name = "rfid_txtbx";
            this.rfid_txtbx.Size = new System.Drawing.Size(149, 27);
            this.rfid_txtbx.TabIndex = 1;
            this.rfid_txtbx.TextChanged += new System.EventHandler(this.rfid_txtbx_TextChanged);
            // 
            // history_lbl
            // 
            this.history_lbl.AutoSize = true;
            this.history_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_lbl.Location = new System.Drawing.Point(3, 9);
            this.history_lbl.Name = "history_lbl";
            this.history_lbl.Size = new System.Drawing.Size(108, 36);
            this.history_lbl.TabIndex = 2;
            this.history_lbl.Text = "History";
            // 
            // history_panel
            // 
            this.history_panel.AutoScroll = true;
            this.history_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.history_panel.Controls.Add(this.history_lbl);
            this.history_panel.Location = new System.Drawing.Point(230, 66);
            this.history_panel.Name = "history_panel";
            this.history_panel.Size = new System.Drawing.Size(604, 432);
            this.history_panel.TabIndex = 3;
            // 
            // employee_lookup_btn
            // 
            this.employee_lookup_btn.Location = new System.Drawing.Point(12, 230);
            this.employee_lookup_btn.Name = "employee_lookup_btn";
            this.employee_lookup_btn.Size = new System.Drawing.Size(185, 29);
            this.employee_lookup_btn.TabIndex = 4;
            this.employee_lookup_btn.Text = "Employee Lookup";
            this.employee_lookup_btn.UseVisualStyleBackColor = true;
            this.employee_lookup_btn.Click += new System.EventHandler(this.employee_lookup_btn_Click);
            // 
            // no_record_error
            // 
            this.no_record_error.AutoSize = true;
            this.no_record_error.ForeColor = System.Drawing.Color.Red;
            this.no_record_error.Location = new System.Drawing.Point(99, 192);
            this.no_record_error.Name = "no_record_error";
            this.no_record_error.Size = new System.Drawing.Size(125, 17);
            this.no_record_error.TabIndex = 5;
            this.no_record_error.Text = "*No Record Found";
            this.no_record_error.Visible = false;
            // 
            // EmpLogLogo
            // 
            this.EmpLogLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpLogLogo.Image = ((System.Drawing.Image)(resources.GetObject("EmpLogLogo.Image")));
            this.EmpLogLogo.Location = new System.Drawing.Point(12, 8);
            this.EmpLogLogo.Name = "EmpLogLogo";
            this.EmpLogLogo.Padding = new System.Windows.Forms.Padding(3);
            this.EmpLogLogo.Size = new System.Drawing.Size(180, 132);
            this.EmpLogLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EmpLogLogo.TabIndex = 8;
            this.EmpLogLogo.TabStop = false;
            this.EmpLogLogo.Click += new System.EventHandler(this.EmpLogLogo_Click);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.time_lbl.Location = new System.Drawing.Point(230, 10);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(2, 34);
            this.time_lbl.TabIndex = 9;
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmplogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 510);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.EmpLogLogo);
            this.Controls.Add(this.no_record_error);
            this.Controls.Add(this.employee_lookup_btn);
            this.Controls.Add(this.rfid_txtbx);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.history_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmplogForm";
            this.Text = " ";
            this.history_panel.ResumeLayout(false);
            this.history_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rfid_lbl;
        private System.Windows.Forms.MaskedTextBox rfid_txtbx;
        private System.Windows.Forms.Label history_lbl;
        private System.Windows.Forms.Panel history_panel;
        private System.Windows.Forms.Button employee_lookup_btn;
        private System.Windows.Forms.Label no_record_error;
        private System.Windows.Forms.PictureBox EmpLogLogo;
        public System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}