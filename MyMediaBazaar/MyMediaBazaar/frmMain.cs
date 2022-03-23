using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMediaBazaar
{
    public partial class frmMain : Form
    {
        private DepartmentManager departmentManager;
        private EmployeeManager employeeManager;

        public frmMain()
        {
            InitializeComponent();

            this.departmentManager = new DepartmentManager();
            this.employeeManager = new EmployeeManager(this.departmentManager);

            GetAllEmployees();
        }

        #region Employees;
        public void GetAllEmployees()
        {
            dgvEmployees.Rows.Clear();

            foreach (Employee e in employeeManager.GetAll())
            {
                if (e.Active == true)
                {
                    int rowId = dgvEmployees.Rows.Add();
                    DataGridViewRow row = dgvEmployees.Rows[rowId];

                    row.Cells["ID"].Value = e.ID;
                    row.Cells["userName"].Value = e.Username;
                    row.Cells["firstName"].Value = e.FirstName;
                    row.Cells["surName"].Value = e.SurName;
                    row.Cells["department"].Value = e.Department.Name;
                    row.Cells["email"].Value = e.Email;
                    row.Cells["phone"].Value = e.Phone;
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployee frmEmployee = new frmEmployee(this, employeeManager, departmentManager);
                frmEmployee.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvEmployees.Rows[dgvEmployees.CurrentRow.Index].Cells[0].Value);
                frmEmployee frmEmployee = new frmEmployee(this, employeeManager, departmentManager, id);
                frmEmployee.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Departments;

        #endregion

    }
}
