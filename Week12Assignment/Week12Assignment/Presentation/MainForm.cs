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
    public partial class MainForm : Form
    {
        private PersonManager personManager;
        private WorkshopManager workshopManager;

        private WorkshopForm workshopForm;
        private PersonForm personForm;
        private ReservationForm reservationForm;

        public MainForm()
        {
            InitializeComponent();

            personManager = new PersonManager();
            workshopManager = new WorkshopManager();

            GetPersons();
            GetWorkshops();
        }

        #region Workshop
        public void GetWorkshops ()
        {
            BindingList<Workshop> dataSource = new BindingList<Workshop>(workshopManager.GetAll());
            dgvWorkshops.DataSource = dataSource;
        }

        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            workshopForm = new WorkshopForm(this, workshopManager, personManager);
            workshopForm.Show();
        }

        private void btnEditWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                Workshop selected = (Workshop)dgvWorkshops.CurrentRow.DataBoundItem;

                if (selected.Started == false)
                {
                    workshopForm = new WorkshopForm(this, workshopManager, personManager, selected);
                    workshopForm.Show();
                }
                else
                {
                    MessageBox.Show("This workshop has already started");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                workshopManager.Remove((Workshop)dgvWorkshops.CurrentRow.DataBoundItem);
                MessageBox.Show("Workshop removed");
                GetWorkshops();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            reservationForm = new ReservationForm(workshopManager, personManager, (Workshop)dgvWorkshops.CurrentRow.DataBoundItem);
            reservationForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (workshopManager.Start((Workshop)dgvWorkshops.CurrentRow.DataBoundItem) == true)
                {
                    MessageBox.Show("Workshop");
                    GetWorkshops();
                }
                else
                {
                    MessageBox.Show("Already started");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Person
        public void GetPersons ()
        {
            BindingList<Person> dataSource = new BindingList<Person>(personManager.GetAll());
            dgvPersons.DataSource = dataSource;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            personForm = new PersonForm (this, personManager);
            personForm.Show();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            try
            {
                personForm = new PersonForm(this, personManager, (Person)dgvPersons.CurrentRow.DataBoundItem);
                personForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            try
            {
                personManager.Remove((Person)dgvPersons.CurrentRow.DataBoundItem);
                MessageBox.Show("Person removed");
                GetPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}