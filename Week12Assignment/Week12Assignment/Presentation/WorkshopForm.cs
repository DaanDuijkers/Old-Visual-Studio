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
    public partial class WorkshopForm : Form
    {
        private MainForm mainForm;
        private WorkshopManager workshopManager;
        private PersonManager personManager;
        private Workshop workshop;
        private bool edit;

        public WorkshopForm(MainForm mainForm, WorkshopManager workshopManager, PersonManager personManager)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.workshopManager = workshopManager;
            this.personManager = personManager;
            this.edit = false;

            cmbType.SelectedIndex = 0;

            foreach (Person p in personManager.GetAll())
            {
                cmbTeacherPSN.Items.Add(p.PSN);
            }
            if (cmbTeacherPSN.Items.Count >= 1)
            {
                cmbTeacherPSN.SelectedIndex = 0;
            }
        }

        public WorkshopForm(MainForm mainForm, WorkshopManager workshopManager, PersonManager personManager, Workshop workshop)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.workshopManager = workshopManager;
            this.personManager = personManager;
            this.workshop = workshop;
            this.edit = true;

            foreach (Person p in personManager.GetAll())
            {
                cmbTeacherPSN.Items.Add(p.PSN);
            }

            txbName.Text = workshop.Name;
            numSeats.Value = workshop.Seats.Count;
            cmbTeacherPSN.Text = workshop.Teacher.PSN;
            rtxbDescription.Text = workshop.Description;
            cmbType.Enabled = false;
            dtpDate.Value = workshop.Date;

            if (workshop is BuildingWorkshop)
            {
                txbAddress.Text = ((BuildingWorkshop)workshop).Address;
                txbRoom.Text = ((BuildingWorkshop)workshop).Room;
                txbURL.Enabled = false;
            }
            else if (workshop is OnlineWorkshop)
            {
                txbAddress.Enabled = false;
                txbRoom.Enabled = false;
                txbURL.Text = ((OnlineWorkshop)workshop).URL;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbType.Text == "INBUILDING" || workshop.Type == "INBUILDING")
                {
                    if (txbName.Text != string.Empty && txbAddress.Text != string.Empty && txbRoom.Text != string.Empty)
                    {
                        if (edit == false)
                        {
                            Response newWorkshop = workshopManager.Add(new BuildingWorkshop(txbName.Text, rtxbDescription.Text, cmbType.Text, Convert.ToInt32(numSeats.Value), dtpDate.Value, personManager.Get(cmbTeacherPSN.Text), txbAddress.Text, txbRoom.Text));

                            if (newWorkshop == Response.Success)
                            {
                                MessageBox.Show("Workshop added!");
                                mainForm.GetWorkshops();
                                this.Close();
                            }
                            else if (newWorkshop == Response.NoEmptySlots)
                            {
                                MessageBox.Show("There cannot be 0 seats");
                            }
                            else if (newWorkshop == Response.PastCurrentTime)
                            {
                                MessageBox.Show("Date cannot be prior to current date");
                            }
                        }
                        else if (edit == true)
                        {
                            Response newWorkshop = workshopManager.Edit(this.workshop, new  BuildingWorkshop(txbName.Text, rtxbDescription.Text, workshop.Type,  Convert.ToInt32(numSeats.Value), dtpDate.Value, personManager.Get (cmbTeacherPSN.Text), txbAddress.Text, txbRoom.Text));

                            if (newWorkshop == Response.Success)
                            {
                                MessageBox.Show("Workshop updated!");
                                mainForm.GetWorkshops();
                                this.Close();
                            }
                            else if (newWorkshop == Response.NoEmptySlots)
                            {
                                MessageBox.Show("There cannot be 0 seats");
                            }
                            else if (newWorkshop == Response.PastCurrentTime)
                            {
                                MessageBox.Show("Date cannot be past current date");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in a name, address, and room");
                    }
                }
                else if (cmbType.Text == "ONLINE" || workshop.Type == "ONLINE")
                {
                    if (txbName.Text != string.Empty && txbURL.Text != string.Empty)
                    {
                        if (edit == false)
                        {
                            Response newWorkshop = workshopManager.Add(new OnlineWorkshop(txbName.Text, rtxbDescription.Text, cmbType.Text, Convert.ToInt32(numSeats.Value), dtpDate.Value, personManager.Get(cmbTeacherPSN.Text), txbURL.Text));

                            if (newWorkshop == Response.Success)
                            {
                                MessageBox.Show("Workshop added!");
                                mainForm.GetWorkshops();
                                this.Close();
                            }
                            else if (newWorkshop == Response.NoEmptySlots)
                            {
                                MessageBox.Show("There cannot be 0 seats");
                            }
                            else if (newWorkshop == Response.PastCurrentTime)
                            {
                                MessageBox.Show("Date cannot be past current date");
                            }
                        }
                        else if (edit == true)
                        {
                            Response newWorkshop = workshopManager.Edit(this.workshop, new OnlineWorkshop(txbName.Text, rtxbDescription.Text, workshop.Type, Convert.ToInt32(numSeats.Value), dtpDate.Value, personManager.Get(cmbTeacherPSN.Text), txbURL.Text));

                            if (newWorkshop == Response.Success)
                            {
                                MessageBox.Show("Workshop updated!");
                                mainForm.GetWorkshops();
                                this.Close();
                            }
                            else if (newWorkshop == Response.NoEmptySlots)
                            {
                                MessageBox.Show("There cannot be 0 seats");
                            }
                            else if (newWorkshop == Response.PastCurrentTime)
                            {
                                MessageBox.Show("Date cannot be past current date");
                            }
                            else if (newWorkshop == Response.NoTeacher)
                            {
                                MessageBox.Show("This person is not a teacher");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the name and URL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}