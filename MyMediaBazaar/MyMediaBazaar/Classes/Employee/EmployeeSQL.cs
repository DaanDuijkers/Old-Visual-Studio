using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class EmployeeSQL
    {
        private GlobalDBMediator globalDBMediator;
        private DepartmentManager departmentManager;

        public EmployeeSQL(DepartmentManager departmentManager)
        {
            this.globalDBMediator = new GlobalDBMediator();
            this.departmentManager = departmentManager;
        }

        public void Add(Employee employee)
        {
            string sqlStatement = "INSERT INTO employees (FName, LName, Gender, Birthdate, Name, Email, Password, Address, Phone, Postal, BSN, Hometown, Role, Salery, Department, EmergencyPhone, EmergencyName, Active, Hours) VALUES (@FName, @LName, @Gender, @Birthdate, @Name, @Email, MD5('@Password'), @Address, @Phone, @Postal, @BSN, @Hometown, @Role, @Salery, @Department, @EmergencyPhone, @EmergencyName, @Active, @Hours)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@FName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@LName", employee.SurName);
            sqlCommand.Parameters.AddWithValue("@Gender", employee.Gender);
            sqlCommand.Parameters.AddWithValue("@Birthdate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@Name", employee.Username);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
            sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Postal", employee.Postal);
            sqlCommand.Parameters.AddWithValue("@BSN", employee.BSN);
            sqlCommand.Parameters.AddWithValue("@Hometown", employee.Town);
            sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
            sqlCommand.Parameters.AddWithValue("@Salery", employee.Wage);
            sqlCommand.Parameters.AddWithValue("@Department", employee.Department.ID);
            sqlCommand.Parameters.AddWithValue("@EmergencyPhone", employee.ContactPhone);
            sqlCommand.Parameters.AddWithValue("@EmergencyName", employee.ContactName);
            sqlCommand.Parameters.AddWithValue("@Active", true);
            sqlCommand.Parameters.AddWithValue("@Hours", employee.Hours);

            int n = this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public void Edit(Employee employee)
        {
            string sqlStatement = "UPDATE employees SET FName = @FName, LName = @LName, Gender = @Gender, Birthdate = @Birthdate, Name = @Name, Email = @Email, Password = @Password, Address = @Address, Phone = @Phone, Postal = @Postal, BSN = @BSN, HomeTown = @HomeTown, Role = @Role, Salery = @Salery, Department = @Department, EmergencyPhone = @EmergencyPhone, EmergencyName = @EmergencyName, Hours = @Hours WHERE ID = @ID";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@FName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@LName", employee.SurName);
            sqlCommand.Parameters.AddWithValue("@Gender", Convert.ToString(employee.Gender));
            sqlCommand.Parameters.AddWithValue("@Birthdate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@Name", employee.Username);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Password", employee.Password);
            sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Postal", employee.Postal);
            sqlCommand.Parameters.AddWithValue("@BSN", employee.BSN);
            sqlCommand.Parameters.AddWithValue("@Hometown", employee.Town);
            sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
            sqlCommand.Parameters.AddWithValue("@Salery", employee.Wage);
            sqlCommand.Parameters.AddWithValue("@Department", employee.Department.ID);
            sqlCommand.Parameters.AddWithValue("@EmergencyPhone", employee.ContactPhone);
            sqlCommand.Parameters.AddWithValue("@EmergencyName", employee.ContactName);
            sqlCommand.Parameters.AddWithValue("@Hours", employee.Hours);
            sqlCommand.Parameters.AddWithValue("@ID", employee.ID);

            int n = this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public void Deactivate(int id)
        {
            string sqlStatement = "UPDATE employees SET Active = @Active WHERE ID = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@active", false);
            sqlCommand.Parameters.AddWithValue("@id", id);

            this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public void Reactivate(int id)
        {
            string sqlStatement = "UPDATE employees SET Active = @Active WHERE ID = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@active", true);
            sqlCommand.Parameters.AddWithValue("@id", id);

            this.globalDBMediator.ExecuteNonQuery(sqlCommand);
        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            string sqlStatement = "SELECT * FROM employees ORDER BY ID ASC";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());

            MySqlDataReader reader = null;

            int id, bsn, hours;
            double wage;
            bool active;
            Gender gender;
            DateTime birthDate;
            string firstName, surName, email, phone, address, postal, town, username, password, contactName, contactPhone;
            Role role;
            Department department;

            try
            {
                reader = this.globalDBMediator.OpenExecuteReader(sqlCommand);

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    firstName = Convert.ToString(reader["FName"]);
                    surName = Convert.ToString(reader["LName"]);
                    gender = (Gender)Enum.Parse(typeof(Gender), (string)reader["Gender"]);
                    birthDate = Convert.ToDateTime(reader["Birthdate"]);
                    username = Convert.ToString(reader["Name"]);
                    email = Convert.ToString(reader["Email"]);
                    password = Convert.ToString(reader["Password"]);
                    address = Convert.ToString(reader["Address"]);
                    phone = Convert.ToString(reader["Phone"]);
                    postal = Convert.ToString(reader["Postal"]);
                    bsn = Convert.ToInt32(reader["BSN"]);
                    town = Convert.ToString(reader["Hometown"]);
                    role = (Role)Enum.Parse(typeof(Role), (string)reader["Role"]);
                    wage = Convert.ToDouble(reader["Salery"]);
                    department = departmentManager.Get(Convert.ToInt32(reader["DepartmentID"]));
                    contactPhone = Convert.ToString(reader["EmergencyPhone"]);
                    contactName = Convert.ToString(reader["EmergencyName"]);
                    hours = Convert.ToInt32(reader["Hours"]);
                    active = Convert.ToBoolean(reader["Active"]);

                    employees.Add(new Employee(id, bsn, hours, department, wage, active, gender, role, birthDate, firstName, surName, email, phone, address, postal, town, username, password, contactName, contactPhone));
                }
            }
            finally
            {
                this.globalDBMediator.CloseExecuteReader(reader);
            }

            return employees;
        }

        public Employee Get(int id)
        {
            Employee employee;

            string sqlStatement = "SELECT * FROM employees WHERE ID = @ID ORDER BY ID ASC";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.globalDBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = null;

            int bsn, hours;
            double wage;
            bool active;
            Gender gender;
            DateTime birthDate;
            string firstName, surName, email, phone, address, postal, town, username, password, contactName, contactPhone, preferredShifts;
            Role role;
            Department department;

            try
            {
                reader = this.globalDBMediator.OpenExecuteReader(sqlCommand);

                firstName = Convert.ToString(reader["FName"]);
                surName = Convert.ToString(reader["LName"]);
                gender = (Gender)Enum.Parse(typeof(Gender), (string)reader["Gender"]);
                birthDate = Convert.ToDateTime(reader["Birthdate"]);
                username = Convert.ToString(reader["Name"]);
                email = Convert.ToString(reader["Email"]);
                password = Convert.ToString(reader["Password"]);
                address = Convert.ToString(reader["Address"]);
                phone = Convert.ToString(reader["Phone"]);
                postal = Convert.ToString(reader["Postal"]);
                bsn = Convert.ToInt32(reader["BSN"]);
                town = Convert.ToString(reader["Hometown"]);
                role = (Role)Enum.Parse(typeof(Role), (string)reader["Role"]);
                wage = Convert.ToDouble(reader["Salery"]);
                department = departmentManager.Get(Convert.ToInt32(reader["DepartmentID"]));
                contactPhone = Convert.ToString(reader["EmergencyPhone"]);
                contactName = Convert.ToString(reader["EmergencyName"]);
                hours = Convert.ToInt32(reader["Hours"]);
                active = Convert.ToBoolean(reader["Active"]);
                preferredShifts = Convert.ToString(reader["preferredHours"]);

                employee = new Employee(id, bsn, hours, department, wage, active, gender, role, birthDate, firstName, surName, email, phone, address, postal, town, username, password, contactName, contactPhone);
            }
            finally
            {
                this.globalDBMediator.CloseExecuteReader(reader);
            }

            return employee;
        }
    }
}