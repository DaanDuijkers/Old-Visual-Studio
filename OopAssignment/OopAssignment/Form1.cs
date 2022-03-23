using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAssignment
{
    public partial class Form1 : Form
    {
        private Shelter shelter;

        public Form1()
        {
            InitializeComponent();

            shelter = new Shelter();
            cmbSpecies.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbSize.SelectedIndex = 0;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txbCustomerName.Text != string.Empty && txbZipcode.Text != string.Empty && txbCity.Text != string.Empty)
            {
                string customerName = txbCustomerName.Text;
                string zipCode = txbZipcode.Text;
                string city = txbCity.Text;

                txbCustomerName.Text = string.Empty;
                txbZipcode.Text = string.Empty;
                txbCity.Text = string.Empty;

                shelter.AddCustomer(customerName, zipCode, city);
                CustomerList();
            }
            else
            {
                MessageBox.Show("Please enter a customer name, zipcode, and city!");
            }
        }

        private void CustomerList ()
        {
            lbCustomer.Items.Clear();
            lbSelectCustomer.Items.Clear();
            foreach (string c in shelter.GetCustomers())
            {
                lbCustomer.Items.Add(c);
                lbSelectCustomer.Items.Add(c);
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (txbAnimalName.Text != string.Empty && txbAge.Text != string.Empty)
            {
                try
                {
                    string animalName = txbAnimalName.Text;
                    int species = cmbSpecies.SelectedIndex;
                    int age = Convert.ToInt32(txbAge.Text);
                    string gender = cmbGender.SelectedItem.ToString();
                    string notes = txbNotes.Text;
                    string size = cmbSize.SelectedItem.ToString();

                    txbAnimalName.Text = string.Empty;
                    txbAge.Text = string.Empty;
                    txbNotes.Text = string.Empty;

                    if (species == 0)
                    {
                        shelter.AddDog(animalName, age, gender, notes);
                    }
                    else if (species == 1)
                    {
                        shelter.AddCat(animalName, age, gender, notes);
                    }
                    else if (species == 2)
                    {
                        shelter.AddBird(animalName, age, gender, notes, size);
                    }

                    AnimalList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the animal and it's age!");
            }
        }

        private void AnimalList()
        {
            lbAnimal.Items.Clear();
            lbSelectAnimal.Items.Clear();
            foreach (string a in shelter.GetAnimals())
            {
                lbAnimal.Items.Add(a);
                lbSelectAnimal.Items.Add(a);
            }
        }

        private void btnAddAdoption_Click(object sender, EventArgs e)
        {
            if (lbSelectAnimal.SelectedIndex != -1 && lbSelectCustomer.SelectedIndex != -1)
            {
                if (lbSelectAnimal.SelectedItems.Count <= 3)
                {
                    int customerNumber = lbSelectCustomer.SelectedIndex;
                    List<int> animalNumbers = new List<int>();
                    foreach (string sa in lbSelectAnimal.Items)
                    {
                        animalNumbers.Add(lbSelectAnimal.SelectedIndex);
                    }

                    shelter.AddAdoption(customerNumber, animalNumbers);

                    lbAdoptions.Items.Clear();
                    foreach (string ab in shelter.GetAdoptions())
                    {
                        lbAdoptions.Items.Add(ab);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot adopt more than three animals at once!");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer and one to three animals!");
            }
        }

        private void AllCustomers()
        {
            string filePath = "../../Customers.txt";
            List<string> allCustomers = new List<string>();
            lbAllCustomers.Items.Clear();

            allCustomers = File.ReadAllLines(filePath).ToList();
            //allCustomers.Add

            /*foreach (String c in allCustomers)
            {
                lbAllCustomers.Items.Add(c);
            }*/

            File.WriteAllLines(filePath, allCustomers);
        }
    }
}