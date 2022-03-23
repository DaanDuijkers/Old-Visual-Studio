using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStreetApp
{
    public partial class Form1 : Form
    {
        private List<Street> streets;
        private List<IMapClient> childForms;

        public Form1()
        {
            InitializeComponent();

            this.childForms = new List<IMapClient>();
            NotifierForm nf = new NotifierForm();
            this.childForms.Add(nf);
            nf.Visible = true;
            this.streets = new List<Street>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string street = txbStreetName.Text;
            string city = txbCity.Text;
            Street s = new Street(street, city);

            if (!streets.Contains(s) && street != string.Empty && city != string.Empty)
            {
                streets.Add(s);
                foreach (IMapClient childForm in childForms)
                {
                    childForm.StreetAdded(s);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string street = txbStreetName.Text;
            string city = txbCity.Text;
            Street s = FindInStreets(street, city);

            if (s != null)
            {
                streets.Remove(s);
                foreach (IMapClient childForm in childForms)
                {
                    childForm.StreetRemoved(s);
                }
            }
        }

        private Street FindInStreets (string street, string city)
        {
            foreach (Street s in this.streets)
            {
                if (s.Name == street && s.City == city)
                {
                    return s;
                }
            }

            return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txbStreetName.Text;
            string city = txbCity.Text;
            Street s = FindInStreets(street, city);

            if (s != null)
            {
                MessageBox.Show("Found: " + s.ToString());
            }
            else
            {
                MessageBox.Show("Not found: " + street + " " + city);
            }

        }

        private void btnSpawnCity_Click(object sender, EventArgs e)
        {
            string city = lblCity.Text;
            if (city == string.Empty)
            {
                CityForm cf = new CityForm(city);
                this.childForms.Add(cf);
                cf.Visible = true;

                foreach (Street s in streets)
                {
                    cf.StreetAdded(s);
                }
            }
        }
    }
}
