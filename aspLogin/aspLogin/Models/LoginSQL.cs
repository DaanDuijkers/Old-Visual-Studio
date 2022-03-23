using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspLogin
{
    public class LoginSQL : GlobalDBMediator
    {
        LoginSQL() { }

        public Person Login(Person person)
        {
            Person exists = null;

            string sqlStatement = "SELECT * FROM person WHERE Username = @Username AND Password = @Password;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Username", person.Username);
            sqlCommand.Parameters.AddWithValue("@Password", person.Password);

            MySqlDataReader reader = null;

            int id;
            string username, password, email, postal;
            bool isActive, isAdmin;

            try
            {
                reader = this.OpenExecuteReader(sqlCommand);

                id = Convert.ToInt32(reader["ID"]);
                username = Convert.ToString(reader["Username"]);
                password = Convert.ToString(reader["Password"]);
                email = Convert.ToString(reader["Email"]);
                postal = Convert.ToString(reader["Postal"]);
                isActive = Convert.ToBoolean(reader["IsActive"]);
                isAdmin = Convert.ToBoolean(reader["IsAdmin"]);

                exists = new Person(id, username, password, email, postal, isActive, isAdmin);
            }
            finally
            {
                this.CloseExecuteReader(reader);
            }

            return exists;
        }
    }
}