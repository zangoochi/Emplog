using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpLog
{
    public partial class GetEmployeeUserControl : UserControl
    {
        private int next_label_location = 1;
        private int counter = 0;

        EditEmployeeUserControl edit_employee_control = new EditEmployeeUserControl();

        public GetEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void rfid_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (rfid_txtbx.Text.Length == 10)
            {
                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
                MySqlCommand cmd;

                connection.Open();
                try
                {
                    /* ------------------------------------------------------------------------------------------- 
                        Create new employee record with first name, last name, and RFID number
                     --------------------------------------------------------------------------------------------*/
                    cmd = connection.CreateCommand();

                    //Once employee is created we must get the id so that we can use as foreign key for contact information
                    cmd.CommandText = "SELECT * FROM employee WHERE rfid = @rfid";
                    cmd.Parameters.AddWithValue("@rfid", rfid_txtbx.Text);

                    string employeeId = "";
                    
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        employeeId = (read["Id"].ToString());
                    }
                    read.Close();
                    //-----------------------------------------------------------------------------------------------

                    if(employeeId != "")
                    {
                       edit_employee_control.empId = employeeId;
                       edit_employee_control.Show();

                       this.Dispose();
                         
                    }
                    else
                    {
                        if (rfid_txtbx.Text != "")
                        {
                            rfid_error.Text = "No RFID Found";
                            rfid_error.Visible = true;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            } 
        }


        //Create Label using text, place of control such as panel, form, etc and the location of label 
        public System.Windows.Forms.Label AddNewLabel(string txt, Control control, int location)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            control.Controls.Add(lbl);
            lbl.Name = "Label" + counter.ToString();
            lbl.Top = next_label_location + location + 10;
            lbl.Text = txt;
            lbl.Width = 600;

            next_label_location = next_label_location + 25;
            counter += 1;
            return lbl;
        }

        private void employee_lookup_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            form.StartPosition = FormStartPosition.CenterScreen;

            System.Windows.Forms.ComboBox combobx = new System.Windows.Forms.ComboBox();
            combobx.Width += 85;
            combobx.Top = 30;
            combobx.Left = 30;
            Padding cbPadding = new Padding();
            cbPadding.All = 30;
            combobx.Margin = cbPadding;

            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Text = "Submit";
            btn.Width += 32;
            btn.Top = 60;
            btn.Left = 65;
            Padding btnPadding = new Padding();
            btnPadding.All = 30;
            btn.Margin = cbPadding;

            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString());
            MySqlCommand cmd;
            MySqlDataReader read;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM employee";

                read = cmd.ExecuteReader();

                Dictionary<String, String> employees = new Dictionary<String, String>();

                combobx.DisplayMember = "Value";
                combobx.ValueMember = "Key";
                String active = "";
                while (read.Read())
                {
                    active = read["is_Active"].ToString();
                    if (active == "True")
                    {
                        active = "(Active)";
                    }
                    else
                    {
                        active = "(Inactive)";
                    }
                    employees.Add(read["Id"].ToString(), read["First_Name"].ToString() + ' ' + read["Last_Name"].ToString() + ' ' + active);
                }
                read.Close();

                if (employees.Count == 0)
                {
                    form.Close();
                    // Define a new top-level error message.
                    string str = "There are no employees!";
                    MessageBox.Show(str, "No record found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    combobx.DataSource = new BindingSource(employees, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            btn.Click += delegate
            {
                string cbxValue = combobx.SelectedValue.ToString();
                edit_employee_control.empId = cbxValue.ToString();
                edit_employee_control.Show();

                this.Dispose();
                form.Dispose();
            };

            form.Controls.Add(combobx);
            form.Controls.Add(btn);
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.Show(this);
        }
        public EditEmployeeUserControl GetEmployeeInfo()
        {
            return edit_employee_control;
        }
    }
}
