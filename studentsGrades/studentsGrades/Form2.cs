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
    public partial class Form2 : Form
    {
        List<string> studentGradeList = new List<string>();

        public Form2()
        {
            InitializeComponent();


            foreach (string s in studentGradeList)
            {
                lbStudentGrades.Items.Add(s);
            }

        }
    }
}
