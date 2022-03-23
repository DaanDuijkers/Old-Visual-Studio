using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week15_Demo
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txbFirstName.Text;
            txbFirstName.Text = string.Empty;
            string lastName = txbLastName.Text;
            txbLastName.Text = string.Empty;
            string gender = txbGender.Text;
            txbGender.Text = string.Empty;
            int birthyear = Convert.ToInt32(txbBirthYear.Text);
            txbBirthYear.Text = string.Empty;

            Person p = new Person(firstName, lastName, gender, birthyear);

            people.Add(p);

            lbList.Items.Add(p.getInfo());
        }
    }
}
