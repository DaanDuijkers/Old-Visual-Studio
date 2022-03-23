using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Assignment
{
    public partial class PersonForm : Form
    {
        private MainForm mainForm;
        private PersonManager personManager;
        private Person person;
        private bool edit;

        public PersonForm(MainForm mainForm, PersonManager personManager)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.personManager = personManager;
            this.edit = false;

            cmbType.SelectedIndex = 0;
        }

        public PersonForm (MainForm mainForm, PersonManager personManager, Person person)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.personManager = personManager;
            this.person = person;
            this.edit = true;

            txbPSN.Text = person.PSN;
            cmbType.Text = person.Type;
            txbFirstName.Text = person.FirstName;
            txbLastName.Text = person.LastName;
            txbClass.Text = person.ClassName;
            txbEmail.Text = person.Email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbPSN.Text != string.Empty && txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && txbClass.Text != string.Empty && txbEmail.Text != string.Empty)
                {
                    if (edit == false)
                    {
                        if (personManager.Add(new Person(txbPSN.Text, cmbType.Text, txbFirstName.Text, txbLastName.Text, txbClass.Text, txbEmail.Text)) == true)
                        {
                            MessageBox.Show("Person was added!");
                            mainForm.GetPersons();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A person wiht this PSN already exists");
                        }
                    }
                    else if (edit == true)
                    {
                        if (personManager.Edit(this.person, new Person(txbPSN.Text, cmbType.Text, txbFirstName.Text, txbLastName.Text, txbClass.Text, txbEmail.Text)) == true)
                        {
                            MessageBox.Show("Data was updated!");
                            mainForm.GetPersons();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A person with this PSN already exists");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}