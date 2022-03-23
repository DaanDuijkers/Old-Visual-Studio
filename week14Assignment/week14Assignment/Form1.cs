using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week14Assignment
{
    public partial class Form1 : Form
    {
        ProjectGroup group;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string newMember = txbName.Text;
            txbName.Text = string.Empty;
            int newStudentNumber = Convert.ToInt32(txbStudentNr.Text);
            txbStudentNr.Text = string.Empty;

            group.AddMember(newMember, newStudentNumber);

            lbInfo.Items.Clear();
            lbInfo.Items.Add(group.GetInfo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            group = new ProjectGroup("Group 1");
            lbInfo.Items.Add(group.GetInfo());
        }
    }
}
