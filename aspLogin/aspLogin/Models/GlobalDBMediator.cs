using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspLogin
{
    public class GlobalDBMediator
    {
        protected MySqlConnection myDBConnection;

        public GlobalDBMediator()
        {
            string dbConnectionInfo = @"Server=studmysql01.fhict.local;Uid=dbi435906;Database=dbi435906;Pwd=Rene1995;";

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