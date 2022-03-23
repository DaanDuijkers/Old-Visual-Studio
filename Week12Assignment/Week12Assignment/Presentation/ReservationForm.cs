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
    public partial class ReservationForm : Form
    {
        WorkshopManager workshopManager;
        PersonManager personManager;
        Workshop workshop;

        public ReservationForm(WorkshopManager workshopManager, PersonManager personManager, Workshop workshop)
        {
            InitializeComponent();

            this.workshopManager = workshopManager;
            this.personManager = personManager;
            this.workshop = workshop;
            GetAll();
        }

        private void GetAll ()
        {

            int availableSeats = 0;
            foreach (Seat s in workshop.Seats)
            {
                if (s.Occupant == null)
                {
                    availableSeats++;
                }
            }
            lblName.Text = "Name: " + workshop.Name;
            lblSeats.Text = "Seats: " + availableSeats;

            BindingList<Person> personsDataSource = new BindingList<Person> (personManager.GetAll());
            dgvPersons.DataSource = personsDataSource;
            BindingList<Seat> seatsDataSource = new BindingList<Seat>(workshopManager.Get(workshop).Seats);
            dgvSeats.DataSource = seatsDataSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = workshopManager.Reserve(workshop, (Person)dgvPersons.CurrentRow.DataBoundItem);

                if (response == Response.Success)
                {
                    MessageBox.Show("Person added");
                    GetAll();
                }
                else if (response == Response.WorkshopLocked)
                {
                    MessageBox.Show("Workshop is locked");
                }
                else if (response == Response.AlreadyRegistered)
                {
                    MessageBox.Show("Person already registered");
                }
                else if (response == Response.NoEmptySlots)
                {
                    MessageBox.Show("Workshop is full");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (workshopManager.CancelReservation(workshop, (Person)dgvPersons.CurrentRow.DataBoundItem) == true)
                {
                    MessageBox.Show("Person was removed");
                    GetAll();
                }
                else
                {
                    MessageBox.Show("Workshop is locked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}