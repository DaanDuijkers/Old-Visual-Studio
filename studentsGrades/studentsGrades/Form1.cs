using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentsGrades
{
    public partial class Form1 : Form
    {
        Form2 form;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGrade.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbStudent.Text != string.Empty)
            {
                string student = txbStudent.Text;
                string grade = cmbGrade.SelectedItem.ToString();


                string studentgrade = student + " (" + grade + ")";

                form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Please enter a student");
            }
        }
    }
}
