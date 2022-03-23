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
    public partial class frmEmployee : Form
    {
        private frmMain frmMain;
        private EmployeeManager employeeManager;
        private DepartmentManager departmentManager;
        private int id;

        public frmEmployee(frmMain frmMain, EmployeeManager employeeManager, DepartmentManager departmentManager)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.employeeManager = employeeManager;
            this.departmentManager = departmentManager;
            this.id = 0;
        }

        public frmEmployee(frmMain frmMain, EmployeeManager employeeManager, DepartmentManager departmentManager, int id)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.employeeManager = employeeManager;
            this.departmentManager = departmentManager;
            this.id = id;
        }
    }
}
