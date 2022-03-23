using System.Data.SqlClient;

namespace LoginTest
{
    internal class clsDatabase
    {
        public static SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Inlog Systeem;
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