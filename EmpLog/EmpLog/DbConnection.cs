using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLog
{
    class DbConnection
    {
        private String Server = "localhost";
        private String Database = "emplog";
        private String UID = "root";
        private String Password = "zm526226";

        public String getDbString()
        {
            return "Server=" + Server + ";Database=" + Database + ";UID=" + UID + ";Password=" + Password;
        }
    }
}
