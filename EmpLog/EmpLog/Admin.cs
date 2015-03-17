using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EmpLog
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            /*___________________________________________________________________________________
            |TAB1: New Employee Tab
            |Creating a new employee on in the admin page. When a new user is created the form
            |is then disposed of and a label is presented to the user for successful employee
            |creation. After 4 seconds, a new form is presented.
            |____________________________________________________________________________________*/
            NewEmployeeUserControl newEmployee = new NewEmployeeUserControl();
            Point point = new Point();
            point.X = edit_employee_page.Width / 2 - newEmployee.Width / 2;
            point.Y = edit_employee_page.Height / 2 - newEmployee.Height / 2;

            newEmployee.Location = point;
            create_employee_page.Controls.Add(newEmployee);
            newEmployee.Disposed += delegate
            {
                new_employee_dispose();
            };


            /*___________________________________________________________________________________
            |TAB2: Edit Employee Tab
            |Editing an employee on the admin page. When an employee is edited, a label is presented
            |displaying successful update. If a user is removed, a label is presented as successful 
            |removal. Also give option to close out of employee window and return to employee lookup
            |____________________________________________________________________________________*/
            GetEmployeeUserControl getEmployee = new GetEmployeeUserControl();
            point = new Point();
            point.X = edit_employee_page.Width / 2 - getEmployee.Width / 2;
            point.Y = edit_employee_page.Height / 2 - getEmployee.Height / 2;

            getEmployee.Location = point;
            edit_employee_page.Controls.Add(getEmployee);

            getEmployee.Disposed += delegate
            {
                get_employee_dispose(getEmployee);
            };

            /*___________________________________________________________________________________
            |TAB3: Employee History Tab
            |Show employee history based on a given start and end date. 
            |Only displays all active employee's history unless otherwise specified.
            |
            |____________________________________________________________________________________*/
            EmployeeHistoryUserControl employeeHistory = new EmployeeHistoryUserControl();
            point = new Point();
            point.X = edit_employee_page.Width / 2 - employeeHistory.Width / 2;
            point.Y = edit_employee_page.Height / 2 - employeeHistory.Height / 2;

            employeeHistory.Location = point;
            employee_history_page.Controls.Add(employeeHistory);
        }


        //
        private void get_employee_dispose(GetEmployeeUserControl getEmployee)
        {
            edit_employee_page.Controls.Remove(getEmployee);

            EditEmployeeUserControl user = new EditEmployeeUserControl();
            user = getEmployee.GetEmployeeInfo();
            
            user.Disposed += delegate
            {
                edit_employee_page.Controls.Remove(user);

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
                    cmd.CommandText = "SELECT is_Active FROM employee WHERE Id = @id";

                    //Define what @first and @last are
                    cmd.Parameters.AddWithValue("@Id", user.empId);


                    //Execute command
                    cmd.ExecuteNonQuery();
                    MySqlDataReader read = cmd.ExecuteReader();
                    String isActive = "";
                    while (read.Read())
                    {
                        isActive = (read["is_Active"].ToString());

                    }
                    read.Close();

                    Label lbl = new Label();
                    lbl.Width += 150;
                    if (isActive == "False")
                    {
                        lbl.Text = "Successfully Removed Employee";
                    }
                    else
                    {
                        lbl.Text = "Successfully Set Employee To Active";
                    }

                    Point point = new Point();
                    point.X = edit_employee_page.Width / 2 - lbl.Width / 2;
                    point.Y = edit_employee_page.Height / 2 - lbl.Height / 2;

                    lbl.Location = point;

                    edit_employee_page.Controls.Add(lbl);

                    var t = new Timer();
                    t.Interval = 2000; // it will Tick in 3 seconds
                    t.Tick += (s, e) =>
                    {
                        edit_employee_page.Controls.Remove(lbl);
                        getEmployee = new GetEmployeeUserControl();
                        getEmployee.Disposed += delegate
                        {
                            get_employee_dispose(getEmployee);
                        };
                        point = new Point();
                        point.X = edit_employee_page.Width / 2 - getEmployee.Width / 2;
                        point.Y = edit_employee_page.Height / 2 - getEmployee.Height / 2;

                        getEmployee.Location = point;
                        edit_employee_page.Controls.Add(getEmployee);

                        t.Stop();
                    };
                    t.Start();


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
            user.Controls["employee_submit_btn"].Click += delegate
            {
                if (user.Controls["employee_submit_btn"].Enabled == true)
                {
                    Label lbl = new Label();
                    lbl.Width += 150;
                    lbl.Text = "Successfully Updated Employee";

                    Point point = new Point();
                    point.X = edit_employee_page.Width / 2 - lbl.Width / 2;
                    point.Y = edit_employee_page.Height / 2 - lbl.Height / 2;

                    lbl.Location = point;

                    edit_employee_page.Controls.Add(lbl);
                    user.Hide();

                    var t = new Timer();
                    t.Interval = 2000; // it will Tick in 3 seconds
                    t.Tick += (s, e) =>
                    {
                        edit_employee_page.Controls.Remove(lbl);
                        user.Show();
                        t.Stop();
                    };
                    t.Start();
                }
                user.Controls["employee_submit_btn"].Enabled = true;
            };

            user.Controls["panel1"].Controls["exit_employee_btn"].Click += delegate
            {
                edit_employee_page.Controls.Remove(user);
                getEmployee = new GetEmployeeUserControl();
                getEmployee.Disposed += delegate
                {
                    get_employee_dispose(getEmployee);
                };
                Point point = new Point();
                point.X = edit_employee_page.Width / 2 - getEmployee.Width / 2;
                point.Y = edit_employee_page.Height / 2 - getEmployee.Height / 2;

                getEmployee.Location = point;
                edit_employee_page.Controls.Add(getEmployee);
            };
            Point p = new Point();
            p.X = edit_employee_page.Width / 2 - user.Width / 2;
            p.Y = edit_employee_page.Height / 2 - user.Height / 2;

            user.Location = p;
            edit_employee_page.Controls.Add(user);
        }

        private void new_employee_dispose()
        {
            NewEmployeeUserControl newEmployee;
            Label lbl = new Label();
            lbl.Width += 150;
            lbl.Text = "Successfully Created Employee";


            Point point = new Point();
            point.X = create_employee_page.Width / 2 - lbl.Width / 2;
            point.Y = create_employee_page.Height / 2 - lbl.Height / 2;

            lbl.Location = point;


            create_employee_page.Controls.Add(lbl);

            var t = new Timer();
            t.Interval = 2000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                newEmployee = new NewEmployeeUserControl();
                newEmployee.Disposed += delegate
                {
                    new_employee_dispose();
                };
                point = new Point();
                point.X = create_employee_page.Width / 2 - newEmployee.Width / 2;
                point.Y = create_employee_page.Height / 2 - newEmployee.Height / 2;

                newEmployee.Location = point;
                create_employee_page.Controls.Remove(lbl);
                create_employee_page.Controls.Add(newEmployee);
                t.Stop();
            };
            t.Start();
        }
    }
}
