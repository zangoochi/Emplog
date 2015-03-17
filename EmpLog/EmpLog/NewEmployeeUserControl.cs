using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpLog
{
    public partial class NewEmployeeUserControl : UserControl
    {
        private MySqlDataAdapter da;
        private DataTable dt;
        public NewEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void employee_submit_btn_Click(object sender, EventArgs e)
        {
            string firstName, lastName, RFID;

            if (first_name_txtbx.Text != "" && last_name_txtbx.Text != "" && rfid_txtbx.Text != "")
            {
                firstName = first_name_txtbx.Text;
                lastName = last_name_txtbx.Text;
                RFID = rfid_txtbx.Text;

                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
                MySqlCommand cmd;
                MySqlTransaction transaction = null;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();

                    //Begin Transaction for creating employee and then updating their contact info
                    transaction = connection.BeginTransaction();

                    //SQL Command with format text @first, @last
                    cmd.CommandText = "INSERT INTO employee (RFID, first_name, last_name, Is_active) VALUES (@rfid, @first,@last,true)";

                    //Define what @first and @last are
                    cmd.Parameters.AddWithValue("@rfid", RFID);
                    cmd.Parameters.AddWithValue("@first", firstName);
                    cmd.Parameters.AddWithValue("@last", lastName);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //Once employee is created we must get the id so that we can use as foreign key for contact information
                    cmd.CommandText = "SELECT Id FROM employee WHERE first_name = @first AND last_name = @last";
                    string employeeId = "";
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        employeeId = (read["Id"].ToString());

                    }
                    read.Close();

                    Crypto encrypt = new Crypto();
                    string password = encrypt.Encrypt(password_txtbx.Text);

                    if (is_admin_cb.Checked == true)
                    {
                        cmd.CommandText = "INSERT INTO admin(EID, Password) VALUES (@employee, @password)";
                        cmd.Parameters.AddWithValue("@employee", employeeId);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }

                    //Set all EID to the empployeeId that was created
                    foreach (DataRow row in dt.Rows) row["EID"] = employeeId;

                    CleanRows();
                    //Remove unneccessary Rows
                    if (passed == true)
                    {
                        //Store DataTable in temporary DataTable
                        DataTable temp = dt;
                        //--------------------------------------------------------------------------
                        //Updates Insert, Delete, Update commands for specific employee. 
                        //Removes all data in datatable
                        FillDataGridView(connection, employeeId);

                        //repopulate DataTable
                        dt = temp;
                        
                        da.Update(dt);

                        //Commit transaction 
                        transaction.Commit();

                        this.Dispose();
                    }
                    //Gets called when there is a partially filled out number. Rollback transaction to beginning so 
                    //All the data is not submitted multiple times, thus creating multiple records
                    else
                    {
                        // Define a new top-level error message.
                        string str = "An Error has occured. Please check that both the number and type fields are filled out appropriately.";
                        MessageBox.Show(str);
                        transaction.Rollback();
                        passed = true;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is MySqlException)
                    {
                        try
                        {
                           // Define a new top-level error message.
                           string str = "An Error has occured. Please check that both the number and type fields are filled out appropriately.";
                           MessageBox.Show(str);
                           transaction.Rollback();
                            passed = true;
                        }
                        catch (MySqlException ex1)
                        {
                            MessageBox.Show("Error: {0}", ex1.ToString());
                        }
                    }
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

        //If admin checkbox is checked then move all objects below down to make room to show password textbox
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

        //Displays password as text instead of "*"
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

        //Fills the DataGridView with the data from the DataTable. Used to update Insert, Delete, Update Commands
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
        private bool passed = true;
        //Removes any rows whose fields are blank. If both fields exist then do not remove them because 
        //They will be added with submit.
        //Used to remove unneccessary rows that will interfer with DataAdapter.Update() method
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
                            passed = false;
                        }
                    }
                }
            }
        }

        //Add blank row to the DataTable
        private void add_row_btn_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height + 30);
            dt.Rows.Add(row);
        }

        private void remove_row_btn_Click(object sender, EventArgs e)
        {
            //If rows exist and are not submitted, then allow the button to remove them
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

        //Used just to get the basic table structure to allow us to add new rows to the DataTable
        private void NewEmployeeUserControl_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString());
            connection.Open();
            try
            {
               FillDataGridView(connection, ""); 
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

        private void employee_numbers_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CleanRows();
            employee_numbers.Size = new Size(employee_numbers.Width, employee_numbers.Height - 30);
        }
    }
}
