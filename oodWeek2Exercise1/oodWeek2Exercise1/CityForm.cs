using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodWeek2Exercise1
{
    public partial class CityForm : Form, IMapMutatable
    {
        private List<Street> streets;

        public CityForm()
        {
            InitializeComponent();

            this.streets = new List<Street>();
        }

        private void btnChangeCity_Click(object sender, EventArgs e)
        {
            lbStreets.Items.Clear();
        }

        public void StreetAdded (Street street)
        {
            if (street.City == txbCity.Text)
            {
                this.streets.Add(street);
                UpdateGUI();
            }
        }

        public void StreetRemoved (Street street)
        {
            this.streets.Remove(street);
            UpdateGUI();
        }

        private void UpdateGUI ()
        {
            lbStreets.Items.Clear();
            foreach (Street s in this.streets)
            {
                lbStreets.Items.Add(s);
            }
        }
    }
}