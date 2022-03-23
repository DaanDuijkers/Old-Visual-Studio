using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class GlobalDBMediator
    {
        private MySqlConnection myDBConnection;

        public GlobalDBMediator()
        {
            string dbConnectionInfo = @"Server=localhost:81;Uid=root;Database=mymediabazaar;Pwd=;";

            this.myDBConnection = new MySqlConnection(dbConnectionInfo);
        }

        public MySqlConnection GetDBConnection()
        {
            return this.myDBConnection;
        }

        public long ExecuteCount(MySqlCommand sqlCountCommand)
        {
            try
            {
                this.myDBConnection.Open();
                long count = (long)sqlCountCommand.ExecuteScalar();

                return count;
            }
            finally
            {
                this.myDBConnection.Close();
            }
        }

        public int ExecuteNonQuery(MySqlCommand sqlNonQueryCommand)
        {
            try
            {
                this.myDBConnection.Open();
                int numberAffectedRows = sqlNonQueryCommand.ExecuteNonQuery();

                return numberAffectedRows;
            }
            finally
            {
                this.myDBConnection.Close();
            }
        }

        public MySqlDataReader OpenExecuteReader(MySqlCommand sqlReaderCommand)
        {
            this.myDBConnection.Open();
            MySqlDataReader reader = sqlReaderCommand.ExecuteReader();

            return reader;
        }

        public void CloseExecuteReader(MySqlDataReader reader)
        {
            if (reader != null)
            {
                reader.Close();
            }

            this.myDBConnection.Close();
        }
    }
}