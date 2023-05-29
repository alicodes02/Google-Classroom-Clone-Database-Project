using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project
{
    internal class DBConnection
    {
        private SqlConnection conn;

        public DBConnection()
        {
            conn = new SqlConnection("Data Source=MISKYSE\\SQLEXPRESS;Initial Catalog=Classroom;Integrated Security=True");
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
