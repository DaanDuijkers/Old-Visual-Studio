using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8Assignment
{
    public partial class Form1 : Form
    {
        List<string> cities = new List<string> ();

        public Form1()
        {
            InitializeComponent();
        }

        private bool Exists(string city)
        {
            if (cities != null)
            {
                foreach (String s in cities)
                {
                    if (city == s)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void RefreshListbox ()
        {
            lbCities.Items.Clear();
            foreach (String s in cities)
            {
                lbCities.Items.Add(cities.IndexOf(s) + ": " + s);
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (txbAddCity.Text != string.Empty)
            {
                string city = txbAddCity.Text;
                txbAddCity.Text = string.Empty;

                if (Exists(city) == false)
                {
                    cities.Add(city);

                    RefreshListbox();
                }
                else
                {
                    MessageBox.Show("City is already recorded");
                }
            }
            else
            {
                MessageBox.Show("Please enter a city");
            }
        }

        private void btnRemoveIndex_Click(object sender, EventArgs e)
        {
            if (txbRemoveIndex.Text != string.Empty)
            {
                int index = Convert.ToInt32(txbRemoveIndex.Text);
                txbRemoveIndex.Text = string.Empty;

                if (index >= cities.Count)
                {
                    MessageBox.Show("There is no city with this indexnumber");
                }
                else
                {
                    cities.RemoveAt(index);
                    RefreshListbox();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            if (txbRemoveCity.Text != string.Empty)
            {
                string city = txbRemoveCity.Text;
                txbRemoveCity.Text = string.Empty;

                if (Exists(city) == true)
                {
                    cities.Remove(city);
                    RefreshListbox();
                }
                else
                {
                    MessageBox.Show("There is no record of this city");
                }
            }
            else
            {
                MessageBox.Show("Please enter a city");
            }
        }

        private void btnSortCity_Click(object sender, EventArgs e)
        {
            if (cities.Count > 1)
            {
                cities.Sort();

                RefreshListbox();
            }
            else
            {
                MessageBox.Show("There aren't enough cities to sort");
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbCities.SelectedItem != null)
            {
                int selected = lbCities.SelectedIndex;

                cities.RemoveAt(selected);
                RefreshListbox();
            }
            else
            {
                MessageBox.Show("Please select a city in the listbox");
            }
        }

        private void txbRemoveIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
