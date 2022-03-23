using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4ReadWriteTextFile
{
    public partial class Form1 : Form
    {
        StudentManager studentManager;

        public Form1()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student(txbName.Text, txbGrade.Text);
            studentManager.AddStudent(s);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();

            foreach (Student s in studentManager.GetStudents())
            {
                lbStudents.Items.Add(s);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            studentManager.WriteToTextFile();
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            studentManager.ReadFromTextFile();
        }
    }
}
