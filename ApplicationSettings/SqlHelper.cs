using Hotel_Management_System.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.ApplicationSettings
{
    public class SqlHelper
    {
        SqlConnection cn;

        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

        public bool isConnected
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
