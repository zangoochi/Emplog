using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpLog
{
    public partial class EmployeeHistoryUserControl : UserControl
    {
        private bool show_employee = false;
        private String last_searched = "";
        public EmployeeHistoryUserControl()
        {
            InitializeComponent();
        }
        
        public void start_date_txtbx_ValueChanged(object sender, EventArgs e)
        {
            if (last_searched != "")
            {
                getEmployeeHistory(last_searched);
            }
            else
            {
                getEmployeeHistory();
            }

        }

        public void end_date_txtbx_ValueChanged(object sender, EventArgs e)
        {
            if (last_searched != "")
            {
                getEmployeeHistory(last_searched);
            }
            else
            {
                getEmployeeHistory();
            }
        }

        private void getEmployeeHistory(string selected = "")
        {
            employee_records_data_grid.Rows.Clear();

            if (start_date_txtbx.Value.Date <= end_date_txtbx.Value.Date)
            {
                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString());
                MySqlCommand cmd;

                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    DateTime beginDT = Convert.ToDateTime(start_date_txtbx.Text);
                    DateTime endDT = Convert.ToDateTime(end_date_txtbx.Text);

                    if (selected == "")
                    {
                        //SQL select all employees 
                        cmd.CommandText = "SELECT employee.Id as eId, attendance.Id as aId, First_Name, Last_Name, Date, Time, attendance.In_Out, employee.Is_active FROM employee INNER JOIN attendance ON attendance.EID = employee.Id WHERE Date >= @beginDate AND Date <= @endDate ORDER BY Last_Name ASC, First_Name ASC, Date ASC, Time ASC";
                        cmd.Parameters.AddWithValue("@beginDate", beginDT.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDT.Date);
                        //Execute command
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (last_searched == "")
                        {
                            //SQL select all employees 
                            cmd.CommandText = "SELECT employee.Id as eId, attendance.Id as aId, First_Name, Last_Name, Date, Time, attendance.In_Out, employee.Is_active FROM employee INNER JOIN attendance ON attendance.EID = employee.Id WHERE eId=@selected ORDER BY Last_Name ASC, First_Name ASC, Date ASC, Time ASC";
                            cmd.Parameters.AddWithValue("@selected", selected);
                            //Execute command
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            //SQL select all employees 
                            cmd.CommandText = "SELECT employee.Id as eId, attendance.Id as aId, First_Name, Last_Name, Date, Time, attendance.In_Out, employee.Is_active FROM employee INNER JOIN attendance ON attendance.EID = employee.Id WHERE eId=@selected AND Date >= @beginDate AND Date <= @endDate ORDER BY Last_Name ASC, First_Name ASC, Date ASC, Time ASC";
                            cmd.Parameters.AddWithValue("@selected", selected);
                            cmd.Parameters.AddWithValue("@beginDate", beginDT.Date);
                            cmd.Parameters.AddWithValue("@endDate", endDT.Date);
                            //Execute command
                            cmd.ExecuteNonQuery();
                        }
                    }

                    //Variables for employees
                    string employeeId, attendanceId, employeeFirst, employeeLast, inOut, isActive;
                    employeeId = attendanceId = employeeFirst = employeeLast = inOut = isActive = "";

                    MySqlDataReader read = cmd.ExecuteReader();

                    string eid = "";
                    TimeSpan total_time = new TimeSpan();
                    DateTime in_time = new DateTime();
                    DateTime in_date = new DateTime();
                    while (read.Read())
                    {
                        //Get employee information
                        employeeId = (read["eId"].ToString());
                        attendanceId = (read["aId"].ToString());
                        employeeFirst = (read["First_Name"].ToString());
                        employeeLast = (read["Last_Name"].ToString());
                        inOut = (read["in_out"].ToString());
                        isActive = (read["is_active"].ToString());

                        DateTime date = (Convert.ToDateTime(read["Date"].ToString()));
                        DateTime time = (Convert.ToDateTime(read["Time"].ToString()));

                        if (show_employee || isActive == "True")
                        {
                            if (eid != employeeId)
                            {
                                total_time = time.Subtract(time);

                                if (employee_records_data_grid.Rows.Count != 0)
                                {
                                    employee_records_data_grid.Rows.Add();
                                }
                                eid = employeeId;
                            }

                            if (inOut == "OUT")
                            {
                                total_time += time.Subtract(in_time);
                                total_time += date.Subtract(in_date);
                                employee_records_data_grid.Rows.Add(employeeId, attendanceId, employeeLast + ", " + employeeFirst, date.Date.ToLongDateString(), time.ToLongTimeString(), inOut, (total_time.Hours + (total_time.Days * 24)) + " h " + total_time.Minutes + " m " + total_time.Seconds + " s ");
                            }
                            else
                            {
                                in_time = time;
                                in_date = date;
                                employee_records_data_grid.Rows.Add(employeeId, attendanceId, employeeLast + ", " + employeeFirst, date.Date.ToLongDateString(), time.ToLongTimeString(), inOut, "");

                            }
                        }
                    }
                    read.Close();
                    if (employeeId != "" && attendanceId != "")
                    {
                        employee_records_data_grid.Visible = true;
                    }
                    else
                    {
                        employee_records_data_grid.Visible = false;
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

        private void employee_records_data_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (employee_records_data_grid.Rows.Count != 0)
            {
                MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
                MySqlCommand cmd;

                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();


                    //SQL select all employees 
                    cmd.CommandText = "SELECT employee.Id as eId, attendance.Id as aId FROM employee INNER JOIN attendance ON attendance.EID = employee.Id WHERE employee.Id = @eId AND attendance.Id = @aId";
                    cmd.Parameters.AddWithValue("@eId", employee_records_data_grid.Rows[e.RowIndex].Cells["eId"].Value);
                    cmd.Parameters.AddWithValue("@aId", employee_records_data_grid.Rows[e.RowIndex].Cells["aId"].Value);
                    //Execute command
                    cmd.ExecuteNonQuery();

                    //Variables for employees
                    string employeeId, attendanceId;
                    employeeId = attendanceId = "";

                    MySqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        //Get employee information
                        employeeId = (read["eId"].ToString());
                        attendanceId = (read["aId"].ToString());
                    }
                    read.Close();

                    if (employeeId != "" && attendanceId != "")
                    {
                        String name = employee_records_data_grid.Columns[e.ColumnIndex].Name;

                        cmd.CommandText = String.Format("UPDATE attendance SET {0} = @attendance_data WHERE Id = @aId", name);
                        if (name == "Date")
                        {
                            DateTime DTdate = Convert.ToDateTime(employee_records_data_grid.Rows[e.RowIndex].Cells["Date"].Value);
                            cmd.Parameters.AddWithValue("@attendance_data", DTdate.Date);
                        }
                        else if (name == "Time")
                        {
                            DateTime DTtime = Convert.ToDateTime(employee_records_data_grid.Rows[e.RowIndex].Cells["Time"].Value);
                            TimeSpan time = new TimeSpan(DTtime.Hour, DTtime.Minute, DTtime.Second);
                            cmd.Parameters.AddWithValue("@attendance_data", time);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@attendance_data", employee_records_data_grid.Rows[e.RowIndex].Cells[name].Value);
                        }

                        cmd.ExecuteNonQuery();

                    }

                    getEmployeeHistory();
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

        private void create_history_record_btn_Click(object sender, EventArgs e)
        {
            HistoryRecordForm form = new HistoryRecordForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Controls["submit_btn"].Click += delegate
            {
                if (form.Controls["error_lbl"].Text == "")
                {
                    getEmployeeHistory();
                    form.Close();
                }
            };
            form.Show();
        }

        private void employee_records_data_grid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
            MySqlCommand cmd;

            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM attendance WHERE Id = @aId";
                cmd.Parameters.AddWithValue("@aId", e.Row.Cells[1].Value);
                cmd.ExecuteNonQuery();
                getEmployeeHistory();

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

        private void show_record_btn_Click(object sender, EventArgs e)
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
            btn.Click += delegate
            {
                last_searched = "";
                String cbxValue = combobx.SelectedValue.ToString();

                if (cbxValue == "-1")
                {
                    show_employee = true;
                    employee_records_data_grid.Rows.Clear();
                    last_searched = "";
                    getEmployeeHistory();
                }
                else
                {
                    getEmployeeHistory(combobx.SelectedValue.ToString());
                    String start_date = employee_records_data_grid.Rows[0].Cells["Date"].Value.ToString();
                    String end_date = employee_records_data_grid.Rows[employee_records_data_grid.Rows.Count - 1].Cells["Date"].Value.ToString();
                    start_date_txtbx.Text = start_date;
                    end_date_txtbx.Text = end_date;
                    last_searched = combobx.SelectedValue.ToString();
                    getEmployeeHistory(combobx.SelectedValue.ToString());

                }
                form.Close();
            };
           

            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString());
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Select Id, First_Name, Last_Name FROM employee";

                MySqlDataReader read = cmd.ExecuteReader();

                Dictionary<String, String> employees = new Dictionary<String, String>();
                employees.Add("-1", "All Employee Records");

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
            form.Controls.Add(combobx);
            form.Controls.Add(btn);
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.Show(this);

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            start_date_txtbx.ResetText();
            end_date_txtbx.ResetText();
            show_employee = false;
            employee_records_data_grid.Rows.Clear();
        }
    }
}
