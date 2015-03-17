using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpLog
{
    public partial class HistoryRecordForm : Form
    {
        public HistoryRecordForm()
        {
            InitializeComponent();
        }
        private void HistoryRecordForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Select Id, First_Name, Last_Name FROM employee WHERE is_Active=true";

                MySqlDataReader read = cmd.ExecuteReader();
  
                Dictionary<String, String> employees = new Dictionary<String, String>();
               
                name_cbx.DisplayMember = "Value";
                name_cbx.ValueMember = "Key";

                while (read.Read())
                {
                   employees.Add(read["Id"].ToString(), read["First_Name"].ToString() + ' ' + read["Last_Name"].ToString());
                }
                read.Close();
                if (employees.Count == 0)
                {
                    this.Close();
                    // Define a new top-level error message.
                    string str = "There are no active employees!";
                    MessageBox.Show(str, "No record found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    name_cbx.DataSource = new BindingSource(employees, null);
                }


            }
            catch(Exception)
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

        private void submit_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(new DbConnection().getDbString()); 
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();

                if (name_cbx.Text != "" && in_out_cbx.Text != "")
                {
                    error_lbl.Text = "";
                    error_lbl.Visible = false;

                    cmd.CommandText = "INSERT INTO attendance (EID, in_out, Date, Time) VALUES (@eid, @inOut, @date, @time)";
                    cmd.Parameters.AddWithValue("@eid", name_cbx.SelectedValue);
                    cmd.Parameters.AddWithValue("@inOut", in_out_cbx.Text);
                    DateTime date = Convert.ToDateTime(date_picker_txtbx.Text);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    DateTime dt = Convert.ToDateTime(time_picker_txtbx.Text);
                    TimeSpan time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    error_lbl.Visible = true;
                    error_lbl.Text = "*Please fill out all boxes!";
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
}
