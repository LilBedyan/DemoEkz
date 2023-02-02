using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoEkz
{
    class DBConn
    {
        SqlConnection connect = new SqlConnection(@"Data Source = LAPTOP-VLAD\LILBEDYAN; Initial Catalog = Trade; Integrated Security = true");

        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connect;
        }
    }
}
