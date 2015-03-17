using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpLog
{

    public partial class EditEmployeeUserControl : UserControl
    {
        protected internal String empId;
        private MySqlDataAdapter da;
        private DataTable dt;
        public EditEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void is_admin_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (is_admin_cb.Checked == true)
            {
                add_row_btn.Top += 50;
                remove_row_btn.Top += 50;
                employee_numbers.Top += 50;
                password_txtbx.Visible = true;
                show_password_cb.Visible = true;
                password_lbl.Visible = true;
            }
            else
            {
                add_row_btn.Top -= 50;
                remove_row_btn.Top -= 50;
                employee_numbers.Top -= 50;
                password_txtbx.Visible = false;
                show_password_cb.Visible = false;
                password_lbl.Visible = false;
            }
        }
        private void set_active_btn_Click(object sender, EventArgs e)
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
                //SQL Command with format text @first, @last
                cmd.CommandText = "UPDATE employee SET is_Active = true WHERE Id = @Id ";

                //Define what @first and @last are
                cmd.Parameters.AddWithValue("@Id", empId);


                //Execute command
                cmd.ExecuteNonQuery();

                //Close the edit employee window when finished
                this.Dispose();
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

        private void remove_employee_btn_Click(object sender, EventArgs e)
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
                //SQL Command with format text @first, @last
                cmd.CommandText = "UPDATE employee SET is_Active = false, RFID=null WHERE Id = @Id ";

                //Define what @first and @last are
                cmd.Parameters.AddWithValue("@Id", empId);
               

                //Execute command
                cmd.ExecuteNonQuery();

                //Close the edit employee window when finished
                this.Dispose();
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

        private void show_password_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_cb.Checked == true)
            {
                password_txtbx.UseSystemPasswordChar = false;
            }
            else
            {
                password_txtbx.UseSystemPasswordChar = true;
            }
        }

        private void employee_submit_btn_Click(object sender, EventArgs e)
        {
            string firstName, lastName, RFID;
            firstName = first_name_txtbx.Text;
            lastName = last_name_txtbx.Text;
            RFID = rfid_txtbx.Text;
            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
            MySqlCommand cmd;

            connection.Open();
            try
            {

                /* ------------------------------------------------------------------------------------------- 
                    Create new employee record with first name, last name, and RFID number
                 --------------------------------------------------------------------------------------------*/
                cmd = connection.CreateCommand();
                cmd.Parameters.AddWithValue("@Id", empId);
                
                if (RFID != "")
                {
                    //SQL Command with format text @first, @last
                    cmd.CommandText = "UPDATE employee SET RFID = @rfid WHERE Id = @Id";

                    //Define what @first and @last are
                    cmd.Parameters.AddWithValue("@rfid", RFID);
                    //Execute command
                    cmd.ExecuteNonQuery();
                }

                if (firstName != "")
                {
                    //SQL Command with format text @first, @last
                    cmd.CommandText = "UPDATE employee SET First_Name = @first WHERE Id = @Id";

                    //Define what @first and @last are
                    cmd.Parameters.AddWithValue("@first", firstName);
                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                if (lastName != "")
                {
                    //SQL Command with format text @first, @last
                    cmd.CommandText = "UPDATE employee SET Last_Name = @last WHERE Id = @Id";

                    //Define what @first and @last are
                    cmd.Parameters.AddWithValue("@last", lastName);
                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                //Once employee is created we must get the id so that we can use as foreign key for contact information
                cmd.CommandText = "SELECT Id FROM employee WHERE first_name = @first AND last_name = @last";
                string employeeId = "";
                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    employeeId = (read["Id"].ToString());

                }
                read.Close();
                cmd.Parameters.AddWithValue("@employee", employeeId);

                if (is_admin_cb.Checked == true)
                {
                    cmd.CommandText = "SELECT EID FROM admin";
                    cmd.ExecuteNonQuery();
                    read = cmd.ExecuteReader();

                    bool isAdmin = false;
                    while (read.Read())
                    {
                        employeeId = (read["EID"].ToString());
                        if (employeeId == empId)
                        {
                            isAdmin = true;
                        }
                    }
                    read.Close();
                    Crypto encrypt = new Crypto();
                    string password = encrypt.Encrypt(password_txtbx.Text);

                    if (isAdmin == true)
                    {
                        cmd.CommandText = "UPDATE admin SET Password = @password WHERE EID = @employee";
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        
                        cmd.CommandText = "INSERT INTO admin (EID, Password) VALUES (@Id, @password)";
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                    Crypto cipher = new Crypto();
                    password = cipher.Decrypt(password);
                    password_txtbx.Text = password;
                    remove_employee_btn.Hide();
                }
                else
                {
                    cmd.CommandText = "DELETE FROM admin WHERE EID = @Id";
                    cmd.ExecuteNonQuery();
                    remove_employee_btn.Show();
                }
                    CleanRows();
                    da.Update(dt);
            }
            catch (Exception)
            {
                // Define a new top-level error message.
                string str = "An Error has occured. Please check that both the number and type fields are filled out appropriately.";
                MessageBox.Show(str);
                employee_submit_btn.Enabled = false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void EditEmployeeUserControl_Load(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM employee WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", empId);

                string employeeId = "";
                string employeeRFID = "";
                string employeeFirst = "";
                string employeeLast = "";
                string employeeIsActive = "";
                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    employeeId = (read["Id"].ToString());
                    employeeRFID = (read["rfid"].ToString());
                    employeeFirst = (read["First_Name"].ToString());
                    employeeLast = (read["Last_Name"].ToString());
                    employeeIsActive = (read["is_Active"].ToString());

                }
                read.Close();
                //-----------------------------------------------------------------------------------------------

                if (employeeId != "")
                {
                    rfid_txtbx.Text = employeeRFID;
                    first_name_txtbx.Text = employeeFirst;
                    last_name_txtbx.Text = employeeLast;
                    if (employeeIsActive == "True")
                    {
                        set_active_btn.Visible = false;
                    }
                    else
                    {
                        set_active_btn.Visible = true;
                        remove_employee_btn.Visible = false;
                    }

                    FillDataGridView(connection, employeeId);



                    //-----------------------------------------------------------------------------------------------

                    cmd.CommandText = "SELECT * FROM admin WHERE EID = @Id";
                    read = cmd.ExecuteReader();

                    //Add Password to edit employee if employee is admin
                    string password = "";
                    while (read.Read())
                    {
                        password = read["Password"].ToString();
                    }
                    read.Close();

                    if (password != "")
                    {
                        is_admin_cb.Checked = true;
                        Crypto cipher = new Crypto();
                        password = cipher.Decrypt(password);
                         password_txtbx.Text = password;
                        remove_employee_btn.Hide();
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

        private void FillDataGridView(MySqlConnection connection, string employeeId)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter("SELECT Id,EID,number,type FROM contact_info WHERE EID = @Id", connection);
            da.SelectCommand.Parameters.AddWithValue("@Id", employeeId);

            //tell the sqldataadapter, how to deal with insert, update and delete

            MySqlCommandBuilder scb = new MySqlCommandBuilder(da);

            da.Fill(dt);

            employee_numbers.DataSource = dt;
            int width = 0;
            int height = 0;
            foreach (DataGridViewColumn col in employee_numbers.Columns) width += col.Width;
            foreach (DataGridViewRow row in employee_numbers.Rows) height += row.Height;
            employee_numbers.Size = new Size(width, height + 30);
        }

        private void employee_numbers_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CleanRows();
            employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height - 30);
        }

        private void add_row_btn_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["EID"] = empId;
            employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height + 30);
            dt.Rows.Add(row);
        }

        private void remove_number_btn_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[dt.Rows.Count - 1];
                if (dr["Id"].ToString() == "")
                {
                    dr.Delete();
                    employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height - 30);
                }
            }
        }
        
        private void CleanRows()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dt.Rows[i][0].ToString() == "")
                    {
                        if ((dt.Rows[i][2].ToString() == "" && dt.Rows[i][3].ToString() == ""))
                        {
                            dt.Rows[i].Delete();
                            employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height - 30);
                            --i;
                        }
                        else if ((dt.Rows[i][2].ToString() == "" || dt.Rows[i][2].ToString() == "(___) ___-____") || dt.Rows[i][3].ToString() == "")
                        {
                            //A record exists that is partially filled out
                            Exception e = new Exception();
                            throw new Exception(@"[Cannot have empty number string]",e);
                        }
                    }
                }
            }
        }
    }
}
