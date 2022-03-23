using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class EmployeeManager
    {
        private List<Employee> employees;
        private EmployeeSQL employeeSQL;

        public EmployeeManager(DepartmentManager departmentManager)
        {
            this.employees = new List<Employee>();
            this.employeeSQL = new EmployeeSQL(departmentManager);
        }

        public List<Employee> GetAll()
        {
            return this.employees;
        }

        public Employee Get (int id)
        {
            foreach (Employee e in employees)
            {
                if (e.Department.ID == id)
                {
                    return e;
                }
            }

            return null;
        }

        public List<Employee> Search (int departmentId)
        {
            List<Employee> selectedEmployees = new List<Employee>();

            foreach (Employee e in employees)
            {
                if (e.Department.ID == departmentId)
                {
                    selectedEmployees.Add(e);
                }
            }

            return selectedEmployees;
        }
    }
}