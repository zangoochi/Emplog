using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EmpLog
{
    public partial class EmplogForm : Form
    {
        private int next_label_location = 1;
        private int counter = 0;
        public EmplogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       

        //If Textbox changes then check if the right amount then check if any employee records match
        private void rfid_txtbx_TextChanged(object sender, EventArgs e)
        {
            //Check textbox lenght so that we are not running code unless we are sure there are enough numbers given
            if (rfid_txtbx.Text.Length == 10)
            {
                //Start new connection
                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString());
                MySqlCommand cmd;

                connection.Open();
                try
                {
                    /* ------------------------------------------------------------------------------------------- 
                        Create new employee record with first name, last name, and RFID number
                     --------------------------------------------------------------------------------------------*/
                    cmd = connection.CreateCommand();

                    //Check if any employees exist in database 
                    cmd.CommandText = "SELECT * FROM employee WHERE RFID = @rfid";

                    //Check using the rfid parameter
                    cmd.Parameters.AddWithValue("@rfid", rfid_txtbx.Text);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //Variables to gather employee information
                    string employeeId, employeeFirst, employeeLast, employeeInOut, isActive;
                    employeeId = employeeFirst = employeeLast = employeeInOut = isActive = "";

                    MySqlDataReader read = cmd.ExecuteReader();

                    //Reads output from SQL query
                    while (read.Read())
                    {
                        employeeId = (read["Id"].ToString());
                        employeeFirst = (read["First_Name"].ToString());
                        employeeLast = (read["Last_Name"].ToString());
                        employeeInOut = (read["In_Out"].ToString());
                        isActive = (read["is_Active"].ToString());
                    }
                    read.Close();

                    //If employee exists then update active to be true
                    if (employeeId != "" && isActive != "False")
                    {
                        cmd.CommandText = "UPDATE employee SET In_Out = @value WHERE Id = @employee_id";

                        if (employeeInOut == "False")
                        {
                            employeeInOut = "IN";
                            cmd.Parameters.AddWithValue("@value", true);
                        }
                        else
                        {
                            employeeInOut = "OUT";
                            cmd.Parameters.AddWithValue("@value", false);
                        }
                        cmd.Parameters.AddWithValue("@employee_id", employeeId);

                        //Execute command
                        cmd.ExecuteNonQuery();
                        DateTime dt = DateTime.Now;
                        TimeSpan time = new TimeSpan(dt.Hour, dt.Minute, dt.Second); 
                        cmd.CommandText = "INSERT INTO attendance (EID, in_out, Date, Time) VALUES (@eid, @inout, @date, @time)";
                        cmd.Parameters.AddWithValue("@eid", employeeId);
                        cmd.Parameters.AddWithValue("@inout", employeeInOut);
                        cmd.Parameters.AddWithValue("@date", dt.Date);
                        cmd.Parameters.AddWithValue("@time", time);

                        cmd.ExecuteNonQuery();

                        //Add new label for the employee
                        AddNewLabel(employeeFirst + ' ' + employeeLast + ' ' + ' ' + employeeInOut + ' ' + dt.ToLongDateString() + ' ' + dt.ToLongTimeString(), history_panel, history_lbl.Bottom);

                        no_record_error.Hide();
                        rfid_txtbx.ResetText();

                    }
                    else
                    {
                        if (employeeId == "")
                        {
                            rfid_txtbx.ResetText();
                            no_record_error.Show();
                        }
                        else
                        {
                            rfid_txtbx.ResetText();
                            string str = "There are no employees!";
                            MessageBox.Show(str, "No active employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(str, "No active employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Lookup employee in a new form. Labels are clickable using delegation with the click event
        private void employee_lookup_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            form.StartPosition = FormStartPosition.CenterScreen;

            System.Windows.Forms.ComboBox combobx = new System.Windows.Forms.ComboBox();
            combobx.Width += 45;
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
                cmd.CommandText = "SELECT * FROM employee WHERE is_Active = true";

               read = cmd.ExecuteReader();

                Dictionary<String, String> employees = new Dictionary<String, String>();

                combobx.DisplayMember = "Value";
                combobx.ValueMember = "Key";

                while (read.Read())
                {
                    employees.Add(read["Id"].ToString(), read["First_Name"].ToString() + ' ' + read["Last_Name"].ToString());
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
                connection.Open();

                //SQL get employee by Id
                cmd.CommandText = "SELECT * FROM employee WHERE Id = @id";

                //Define @id
                cmd.Parameters.AddWithValue("@id", cbxValue);

                //Execute command
                cmd.ExecuteNonQuery();

                //Variables for specific employee that is being clicked
                string eId, eFirst, eLast, eInOut;
                eId = eFirst = eLast = eInOut = "";

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    eId = (read["Id"].ToString());
                    eFirst = (read["First_Name"].ToString());
                    eLast = (read["Last_Name"].ToString());
                    eInOut = (read["In_Out"].ToString());
                }
                read.Close();

                if (eId != "")
                {
                    //Update employee to be used in time clock
                    cmd.CommandText = "UPDATE employee SET In_Out = @val WHERE Id = @e_id";

                    if (eInOut == "False")
                    {
                        eInOut = "IN";
                        cmd.Parameters.AddWithValue("@val", true);
                    }
                    else
                    {
                        eInOut = "OUT";
                        cmd.Parameters.AddWithValue("@val", false);
                    }
                    cmd.Parameters.AddWithValue("@e_id", eId);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    DateTime dt = DateTime.Now;
                    TimeSpan time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                    cmd.CommandText = "INSERT INTO attendance (EID, in_out, Date, Time) VALUES (@eid, @inout, @date, @time)";
                    cmd.Parameters.AddWithValue("@eid", eId);
                    cmd.Parameters.AddWithValue("@inout", eInOut);
                    cmd.Parameters.AddWithValue("@date", dt.Date);
                    cmd.Parameters.AddWithValue("@time", time);

                    cmd.ExecuteNonQuery();


                    AddNewLabel(eFirst + ' ' + eLast + ' ' + ' ' + eInOut + ' ' + DateTime.Now.ToLongDateString() + ' ' + DateTime.Now.ToLongTimeString(), history_panel, history_lbl.Bottom);
                    rfid_txtbx.ResetText();
                }
                form.Close();
            };

            form.Controls.Add(combobx);
            form.Controls.Add(btn);
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.Show(this);
        }

        //Create Label using text, place of control such as panel, form, etc and the location of label 
        public System.Windows.Forms.Label AddNewLabel(string txt, Control control, int location)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            control.Controls.Add(lbl);
            lbl.Name = "Label" + counter.ToString();
            lbl.Top = next_label_location + location + 10;
            lbl.Left = history_lbl.Left;
            lbl.Text = txt;
            lbl.Width = 600;

            next_label_location = next_label_location + 25;
            counter += 1;
            return lbl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time_lbl.Text = now.ToLongDateString() + ' ' + now.ToLongTimeString();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            create_password_form();
        }

        private void create_password_form()
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            form.StartPosition = FormStartPosition.CenterScreen;

            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = "Password";
            lbl.Top = 30;
            lbl.Left = 30;

            System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
            tb.Name = "password_txtbx";
            tb.Top = 30;
            Padding tbPadding = new Padding();
            tbPadding.All = 30;
            tb.Margin = tbPadding;
            tb.Width += 45;
            tb.UseSystemPasswordChar = true;

            tb.TextChanged += delegate
            {
                 //Check textbox lenght so that we are not running code unless we are sure there are enough numbers given
               
                    //Start new connection

                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
                MySqlCommand cmd;
                    cmd = connection.CreateCommand();

                    connection.Open();
                    try
                    {
                        /* ------------------------------------------------------------------------------------------- 
                            Create new employee record with first name, last name, and RFID number
                         --------------------------------------------------------------------------------------------*/
                        

                        //Check if any employees exist in database 
                        cmd.CommandText = "SELECT * FROM admin WHERE Password = @password";

                        Crypto encrypt = new Crypto();
                        string password = encrypt.Encrypt(tb.Text);
                        //Check using the rfid parameter
                        cmd.Parameters.AddWithValue("@password", password);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        //Variables to gather employee information
                        string Id;
                        Id =  "";

                        MySqlDataReader read = cmd.ExecuteReader();

                        //Reads output from SQL query
                        while (read.Read())
                        {
                            Id = (read["Id"].ToString());
                            
                        }
                        read.Close();

                        //If employee exists then update active to be true
                        if (Id != "")
                        {
                            form.Close();
                            AdminForm aform = new AdminForm();
                            aform.Show();

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
                
            };

            tb.Left = lbl.Right;

            form.Controls.Add(lbl);
            form.Controls.Add(tb);

            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.Show(this);
        }

        private void EmpLogLogo_Click(object sender, EventArgs e)
        {
            create_password_form();
        }

    }
}
