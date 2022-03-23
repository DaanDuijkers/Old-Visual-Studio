using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodWeek5Assignment
{
    public partial class PersonDetails : Form
    {
        private Form1 form1;
        private PersonManager personManager;
        private ProductManager productManager;
        private Person edit;

        public PersonDetails(Form1 form1, PersonManager personManager, ProductManager productManager)
        {
            InitializeComponent();

            this.form1 = form1;
            this.personManager = personManager;
            this.productManager = productManager;
            this.edit = null;

            btnPromote.Enabled = false;
            btnPromote.Visible = false;
        }

        public PersonDetails (Form1 form1, PersonManager personManager, ProductManager productManager, Person edit)
        {
            InitializeComponent();

            this.form1 = form1;
            this.personManager = personManager;
            this.productManager = productManager;
            this.edit = edit;

            txbUsername.Text = edit.Username;
            txbPassword.Text = edit.Password;
            txbEmail.Text = edit.Email;
            txbPostal.Text = edit.Postal;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.edit == null)
                {
                    if (txbUsername.Text != string.Empty && txbPassword.Text != string.Empty && txbEmail.Text != string.Empty && txbPostal.Text != string.Empty)
                    {
                        if (this.edit == null)
                        {
                            if (personManager.Add(new Person(txbUsername.Text,
                                txbPassword.Text,
                                txbEmail.Text,
                                txbPostal.Text,
                                productManager)) == true)
                            {
                                MessageBox.Show("New user was added!");
                                form1.GetPersons();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                        else
                        {
                            edit.Username = txbUsername.Text;
                            edit.Password = txbPassword.Text;
                            edit.Email = txbEmail.Text;
                            edit.Postal = txbPostal.Text;

                            if (personManager.Edit(edit.ID, edit) == true)
                            {
                                form1.GetPersons();
                                this.Close();
                            }
                        }
                    }
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            try
            {
                edit.IsAdmin = true;
                form1.GetPersons();
                this.Close();
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
