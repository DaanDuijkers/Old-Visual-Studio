using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class DepartmentSQL
    {
        GlobalDBMediator globalDBMediator;

        public DepartmentSQL()
        {
            globalDBMediator = new GlobalDBMediator();
        }

        public void AddDepartment(Department department)
        {
            string sqlStatement = "INSERT INTO departments (Name, Active) VALUES (@Name, @Active)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Name", department.Name);
            sqlCommand.Parameters.AddWithValue("@Active", true);
            int n = this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();

            string sqlStatement = "SELECT * FROM departments ORDER BY ID ASC";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            MySqlDataReader reader = null;

            int id;
            string name;
            bool active;

            try
            {
                reader = this.globalDBMediator.OpenExecuteReader(sqlCommand);

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    name = Convert.ToString(reader["Name"]);

                    departments.Add(new Department(id, name));
                }
            }
            finally
            {
                this.globalDBMediator.CloseExecuteReader(reader);
            }

            return departments;
        }

        public Department GetID(int id)
        {
            Department department;

            string sqlStatement = "SELECT * FROM departments WHERE ID = @ID ORDER BY ID ASC";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = null;

            string name;

            try
            {
                reader = this.globalDBMediator.OpenExecuteReader(sqlCommand);

                id = Convert.ToInt32(reader["ID"]);
                name = Convert.ToString(reader["Name"]);

                department = new Department(id, name);
            }
            finally
            {
                this.globalDBMediator.CloseExecuteReader(reader);
            }
            return department;
        }

        public void Edit(Department department)
        {
            string sqlStatement = "UPDATE departments SET Name = @Name WHERE ID = @ID";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Name", department.Name);
        }

        public void Reactivate(int id)
        {
            string sqlStatement = "UPDATE departments SET Active = @Active WHERE ID = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@active", true);
            sqlCommand.Parameters.AddWithValue("@id", id);

            this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public void Deactivate(int id)
        {
            string sqlStatement = "UPDATE departments SET Active = @Active WHERE ID = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@active", false);
            sqlCommand.Parameters.AddWithValue("@id", id);

            this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }
    }
}