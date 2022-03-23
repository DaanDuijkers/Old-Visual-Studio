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
    public partial class CityForm : Form, IMapClient
    {
        private string city;
        private List<string> streets;

        public CityForm(string city)
        {
            InitializeComponent();
            this.city = city;
            lblCity.Text += city;
            this.streets = new List<string>();
        }

        public void StreetAdded(Street s)
        {
            if (s.City == city)
            {
                streets.Add(s.Name);
                ShowInListBox();
            }
        }

        public void StreetRemoved(Street s)
        {
            if (s.City == city)
            {
                streets.Remove(s.Name);
                ShowInListBox();
            }
        }

        private void ShowInListBox()
        {
            lbStreets.Items.Clear();
            foreach (string street in streets)
            {
                lbStreets.Items.Add(street);
            }
        }
    }
}
