using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class DepartmentManager
    {
        private List<Department> departments;

        public List<Department> GetAll()
        {
            return this.departments;
        }

        public Department Get(int id)
        {
            foreach (Department d in departments)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }

            return null;
        }
    }
}