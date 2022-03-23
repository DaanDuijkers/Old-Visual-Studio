using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingServer
{
    class Database
    {
        public static SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Chat;
            Integrated Security=true;
        ");
        public static SqlCommand cmd;
        public static SqlDataAdapter adapt;

        public static SqlConnection Connect()
        {
            return con;
        }

        public static SqlCommand Command()
        {
            return cmd;
        }

        public static SqlDataAdapter DataAdapter()
        {
            return adapt;
        }
    }
}
